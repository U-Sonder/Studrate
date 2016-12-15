using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace Studrate
{
    public partial class wf_addData : Form
    {
        private string connectionString;
        private Stack<string> textFiles;

        public wf_addData()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StudentPlag"].ConnectionString;
            comboFillDiscipline();
        }        

        private int insertStudent(SqlCommand command, Match match)
        {
            command.Parameters["@surname"].Value = match.Groups[1].Value;
            command.Parameters["@class"].Value = match.Groups[2].Value;
            command.Parameters["@gradebook"].Value = match.Groups[3].Value;
            command.Parameters["@name"].Value = match.Groups[4].Value;
            command.Parameters["@patronymic"].Value = match.Groups[5].Value;
            return command.ExecuteNonQuery();
        }

        private int seekStudentId(SqlCommand command, Match match)
        {
            command.Parameters["@class"].Value = match.Groups[2].Value;
            command.Parameters["@gradebook"].Value = match.Groups[3].Value;
            var id = command.ExecuteScalar();
            if (id != null)
                return Convert.ToInt32(id);
            else
                return -1;
        }

        private int insertLab(SqlCommand command, int labNumber)
        {
            command.Parameters["@lab_number"].Value = labNumber;
            command.Parameters["@id_discipline"].Value = cbDiscipline.SelectedValue;
            return command.ExecuteNonQuery();
        }

        private int seekLabId(SqlCommand command, int labNumber)
        {
            command.Parameters["@lab_number"].Value = labNumber;
            command.Parameters["@id_discipline"].Value = cbDiscipline.SelectedValue;            
            var id = command.ExecuteScalar();
            if (id != null)
                return Convert.ToInt32(id);
            else
                return -1;
        }

        /// <summary>
        /// Open form - wf_addDiscipline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDisciplineAdd_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "wf_addDiscipline")
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    return;
                }
            }
            wf_addDiscipline t = new wf_addDiscipline(this);
            t.Show();
        }

        public void comboFillDiscipline()
        {
            string q_selectDiscipline = "SELECT Id_discipline, Nickname FROM Discipline;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand c_selectDiscipline = new SqlCommand(q_selectDiscipline, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(c_selectDiscipline))
            {
                DataTable disciplineList = new DataTable();
                adapter.Fill(disciplineList);
                cbDiscipline.DisplayMember = "Nickname";
                cbDiscipline.ValueMember = "Id_discipline";
                cbDiscipline.DataSource = disciplineList;
            }
        }

        /// <summary>
        /// Read files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            textFiles = new Stack<string>();
            textFiles.Clear();

            openFileDialog1.InitialDirectory = "e:\\Test";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    try
                    {
                        if ((myStream = File.Open(file, FileMode.Open)) != null)
                        {                            
                            using (myStream)
                            {
                                StreamReader sr = new StreamReader(myStream);
                                textFiles.Push(sr.ReadToEnd());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Check for error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAddPlag_Click(object sender, EventArgs e)
        {
            rtbErrorRow.Text = "";
            if (textFiles != null)
                foreach (string text in textFiles)
                {
                    parseFiles(text);
                }
            else
                MessageBox.Show("Firstly chose file", "Error");
        }

        /// <summary>
        /// Parse text file and input data into database
        /// </summary>
        /// <param name="textFile"></param>
        private void parseFiles(string textFile)
        {
            // Parse file
            string str = textFile;
            string patternStr = @"\/([a-z]+)-([a-z]{2}\d{2})(\d{2})-([a-z]+)-?([a-z]+)?_[a-z]{2}(\d)_\S+\/\s\((\d{1,2})%\)";
            Regex regex = new Regex(patternStr, RegexOptions.IgnoreCase);
            string[] rows = str.Split('\n');

            string patternLines = @"\|\s+(\d+)\s(?:matches lines.)";
            Regex regexLines = new Regex(patternLines);

            int rowStudent = 0,
                rowLab = 0,
                rowPlag = 0;
            //-----------------------------------------------------------
            //1-surname, 2-Class, 3-gradebook, 4-name, 5-patronymic, 6-lab, 7-%
            
            // Input rows into database            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_insertStudent = new SqlCommand("spInsertStudent", connection))
                using (SqlCommand c_insertLab = new SqlCommand("spInsertLab", connection))
                using (SqlCommand c_insertPlagiarism = new SqlCommand("spInsertPlagiarism", connection))
                using (SqlCommand c_seekStudentId = new SqlCommand("spSeekStudentId", connection))
                using (SqlCommand c_seekLabId = new SqlCommand("spSeekLabId", connection))
                {
                    connection.Open();

                    // Command type
                    c_insertStudent.CommandType = CommandType.StoredProcedure;
                    c_insertLab.CommandType = CommandType.StoredProcedure;
                    c_insertPlagiarism.CommandType = CommandType.StoredProcedure;
                    c_seekStudentId.CommandType = CommandType.StoredProcedure;
                    c_seekLabId.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    c_insertStudent.Parameters.Add("@name", SqlDbType.NVarChar);
                    c_insertStudent.Parameters.Add("@surname", SqlDbType.NVarChar);
                    c_insertStudent.Parameters.Add("@patronymic", SqlDbType.NVarChar);
                    c_insertStudent.Parameters.Add("@class", SqlDbType.NVarChar);
                    c_insertStudent.Parameters.Add("@gradebook", SqlDbType.NVarChar);

                    c_insertLab.Parameters.Add("@lab_number", SqlDbType.NVarChar);
                    c_insertLab.Parameters.Add("@id_discipline", SqlDbType.NVarChar);

                    c_insertPlagiarism.Parameters.Add("@id_discipline", SqlDbType.NVarChar);
                    c_insertPlagiarism.Parameters.Add("@id_lab", SqlDbType.NVarChar);
                    c_insertPlagiarism.Parameters.Add("@id_student1", SqlDbType.NVarChar);
                    c_insertPlagiarism.Parameters.Add("@id_student2", SqlDbType.NVarChar);
                    c_insertPlagiarism.Parameters.Add("@percent1", SqlDbType.NVarChar);
                    c_insertPlagiarism.Parameters.Add("@percent2", SqlDbType.NVarChar);
                    c_insertPlagiarism.Parameters.Add("@lines", SqlDbType.NVarChar);

                    c_seekStudentId.Parameters.Add("@class", SqlDbType.NVarChar);
                    c_seekStudentId.Parameters.Add("@gradebook", SqlDbType.NVarChar);

                    c_seekLabId.Parameters.Add("@id_discipline", SqlDbType.NVarChar);
                    c_seekLabId.Parameters.Add("@lab_number", SqlDbType.NVarChar);

                    // Add each row
                    foreach (var oneRow in rows)
                    {
                        Match match1 = regex.Match(oneRow);
                        Match match2 = regex.Match(oneRow).NextMatch();
                        Match matchLines = regexLines.Match(oneRow);
                        if (match1.Success && match2.Success && matchLines.Success)
                        {
                            int id1 = seekStudentId(c_seekStudentId, match1);
                            int id2 = seekStudentId(c_seekStudentId, match2);

                            if (id1 < 0)
                            {
                                rowStudent += insertStudent(c_insertStudent, match1);
                                id1 = seekStudentId(c_seekStudentId, match1);
                            }
                            if (id2 < 0)
                            {
                                rowStudent += insertStudent(c_insertStudent, match2);
                                id2 = seekStudentId(c_seekStudentId, match2);
                            }

                            if (match1.Groups[6].Value == match2.Groups[6].Value)
                            {
                                int labNumber = Convert.ToInt32(match1.Groups[6].Value);
                                int labId = seekLabId(c_seekLabId, labNumber);
                                if (labId < 0)
                                {
                                    rowLab += insertLab(c_insertLab, labNumber);
                                    labId = seekLabId(c_seekLabId, labNumber);
                                }

                                c_insertPlagiarism.Parameters["@id_discipline"].Value = cbDiscipline.SelectedValue;
                                c_insertPlagiarism.Parameters["@id_lab"].Value = labId;
                                c_insertPlagiarism.Parameters["@id_student1"].Value = id1;
                                c_insertPlagiarism.Parameters["@id_student2"].Value = id2;
                                c_insertPlagiarism.Parameters["@percent1"].Value = match1.Groups[7].Value;
                                c_insertPlagiarism.Parameters["@percent2"].Value = match2.Groups[7].Value;
                                c_insertPlagiarism.Parameters["@lines"].Value = matchLines.Groups[1].Value;
                                rowPlag += c_insertPlagiarism.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Error! Different lab's number at row: \n" + oneRow, "Error");
                            }
                        }
                        else
                        {
                            if (!oneRow.Contains("http") && oneRow.Trim().Length != 0)
                                rtbErrorRow.Text += oneRow;
                        }
                    }
                }
                MessageBox.Show("New students added: " + rowStudent
                    + "\nNew labs added: " + rowLab
                    + "\nPlags added: " + rowPlag, "Report");
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }

        }

        /// <summary>
        /// Save text file with invalid rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSave_Click(object sender, EventArgs e)
        {
            sfdErrorText.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfdErrorText.FilterIndex = 1;
            sfdErrorText.RestoreDirectory = true;

            if (sfdErrorText.ShowDialog() == DialogResult.OK)
            {
                string filename = sfdErrorText.FileName;
                File.WriteAllText(filename, rtbErrorRow.Text, Encoding.UTF8);
                MessageBox.Show("File saved");
            }
        }

    }
}
