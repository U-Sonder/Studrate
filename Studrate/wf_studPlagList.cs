using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Studrate
{
    public partial class wf_studPlagList : Form
    {
        private string connectionString;
        public wf_studPlagList()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StudentPlag"].ConnectionString;
            comboFillDiscipline();            
        }
        
        private DataTable fullDataTable; // Data table for loaded from db for current discipline
        private DataTable seekDataTable; // Data table for seeking by Surname

        private void comboFillDiscipline()
        {            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_selectDiscipline = new SqlCommand("spViewDiscipline", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(c_selectDiscipline))
                {
                    c_selectDiscipline.CommandType = CommandType.StoredProcedure;
                    DataTable disciplineList = new DataTable();
                    adapter.Fill(disciplineList);
                    cbDiscipline.DisplayMember = "Nickname";
                    cbDiscipline.ValueMember = "Id_discipline";
                    cbDiscipline.DataSource = disciplineList;
                }
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        private void comboFillLab()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_selectLab = new SqlCommand("spViewLab", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(c_selectLab))
                {
                    c_selectLab.Parameters.AddWithValue("@id_discipline", cbDiscipline.SelectedValue);
                    c_selectLab.CommandType = CommandType.StoredProcedure;

                    DataTable labList = new DataTable();
                    labList.Columns.Add("Lab_number");
                    labList.Columns.Add("Id_lab", typeof(Int32));

                    DataRow dr = labList.NewRow();
                    dr["Lab_number"] = "All";
                    dr["Id_lab"] = -1;
                    labList.Rows.InsertAt(dr, 0);

                    adapter.Fill(labList);
                    cbLab.DisplayMember = "Lab_number";
                    cbLab.ValueMember = "Id_lab";
                    cbLab.DataSource = labList;
                }
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        private void comboFillCourse()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_selectCourse = new SqlCommand("spViewCourse", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(c_selectCourse))
                {
                    c_selectCourse.CommandType = CommandType.StoredProcedure;

                    DataTable courseList = new DataTable();
                    courseList.Columns.Add("Course");
                    DataRow dr = courseList.NewRow();
                    dr["Course"] = "All";
                    courseList.Rows.InsertAt(dr, 0);
                    adapter.Fill(courseList);
                    cbCourse.DisplayMember = "Course";
                    cbCourse.DataSource = courseList;
                }
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        private void comboFillClass()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_selectClass = new SqlCommand("spStudentClassByCourse", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(c_selectClass))
                {
                    c_selectClass.CommandType = CommandType.StoredProcedure;
                    c_selectClass.Parameters.AddWithValue("@Course", cbCourse.Text);

                    DataTable classList = new DataTable();
                    classList.Columns.Add("Class");
                    DataRow dr = classList.NewRow();
                    dr["Class"] = "All";
                    classList.Rows.InsertAt(dr, 0);
                    adapter.Fill(classList);
                    cbGroup.DisplayMember = "Class";
                    cbGroup.DataSource = classList;
                }
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        private void loadStudentList()
        {
            try
            {
                dgvStudent.Columns.Clear();
                dgvStudent.Refresh();
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_selectStudent = new SqlCommand("spStudPlagList", connection))
                {
                    c_selectStudent.CommandType = CommandType.StoredProcedure;
                    c_selectStudent.Parameters.AddWithValue("@discId", cbDiscipline.SelectedValue);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(c_selectStudent))
                    {
                        DataTable studentList = new DataTable();
                        adapter.Fill(studentList);
                        dgvStudent.DataSource = studentList;
                        fullDataTable = studentList.Copy();
                    }
                }
                dgvStudentOptions();
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        /// <summary>
        /// Display detailed information about student's 
        /// one lab work and compare with other students
        /// who are related with him
        /// </summary>
        /// <param name="id_student"></param>
        /// <param name="lab"></param>
        private void loadPlugByCell(int id_student, string lab)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_selectPlug = new SqlCommand("spPlagByCell", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(c_selectPlug))
                {
                    c_selectPlug.CommandType = CommandType.StoredProcedure;
                    c_selectPlug.Parameters.AddWithValue("@id_student", id_student);
                    c_selectPlug.Parameters.AddWithValue("@id_discipline", cbDiscipline.SelectedValue);
                    c_selectPlug.Parameters.AddWithValue("@lab", lab);

                    DataTable plagList = new DataTable();
                    adapter.Fill(plagList);
                    dgvPlag.DataSource = plagList;
                }
                dgvPlag.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        /// <summary>
        /// Find all sources for loading detailed information about 
        /// student and this lab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentCell.OwningColumn.Index > 6)
            {
                string lab = dgvStudent.CurrentCell.OwningColumn.Name;
                int id = (int)dgvStudent.CurrentRow.Cells[0].Value;
                loadPlugByCell(id, lab);
            }
        }

        /// <summary>
        /// Change dgv options for better view
        /// </summary>
        private void dgvStudentOptions()
        {
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvStudent.Columns[0].Visible = false;
            dgvLabSelected();
        }

        private void dgvLabSelected()
        {
            if ((int)cbLab.SelectedValue != -1)
                for (int i = 7; i < dgvStudent.ColumnCount; i++)
                {
                    dgvStudent.Columns[i].Visible = true;
                    if (char.IsDigit(dgvStudent.Columns[i].Name[0]))
                        if (dgvStudent.Columns[i].Name != cbLab.Text)
                        {
                            dgvStudent.Columns[i].Visible = false;
                        }
                }
            else
                for (int i = 7; i < dgvStudent.ColumnCount; i++)
                    dgvStudent.Columns[i].Visible = true;
        }


        /// <summary>
        /// Filtering with using LINQ
        /// by Course and Group
        /// </summary>
        private void dgvCourseAndGroup()
        {
            if (cbCourse.Text != "All" || cbGroup.Text != "All")
            {
                EnumerableRowCollection<DataRow> result;
 

                if (cbCourse.Text != "All" && cbGroup.Text == "All")
                    result = from myRow in fullDataTable.AsEnumerable()
                             where myRow.Field<string>("Course") == cbCourse.Text
                             select myRow;
                else if (cbCourse.Text == "All" && cbGroup.Text != "All")
                    result = from myRow in fullDataTable.AsEnumerable()
                             where myRow.Field<string>("Class") == cbGroup.Text
                             select myRow;
                else
                    result = from myRow in fullDataTable.AsEnumerable()
                             where myRow.Field<string>("Course") == cbCourse.Text 
                                 && myRow.Field<string>("Class") == cbGroup.Text
                             select myRow;

                if (result != null && result.Any())
                {
                    dgvStudent.DataSource = result.CopyToDataTable();
                    dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgvStudent.Columns[0].Visible = false;
                }
                else
                {
                    dgvStudent.Columns.Clear();
                    dgvStudent.Refresh();
                }
            }
            else if (cbCourse.Text == "All" && cbGroup.Text == "All")
            {
                DataTable copy = fullDataTable.Copy();
                dgvStudent.DataSource = copy;
                dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvStudent.Columns[0].Visible = false;
                copy.Dispose();
            }
            seekDataTable = ((DataTable)dgvStudent.DataSource).Copy();
        }


        private void cbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFillLab();
            loadStudentList();
            comboFillCourse();
         }

        private void cbLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLabSelected();
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFillClass();
            dgvCourseAndGroup();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCourseAndGroup();
        }

        /// <summary>
        /// Seeking by using LINQ
        /// by surname
        /// </summary>
        private void seekBySurname()
        {
            var result = from myRow in seekDataTable.AsEnumerable()
                         where myRow.Field<string>("Surname").ToLower().StartsWith(tbSurnameSeek.Text.ToLower())
                         select myRow;

            if (result != null && result.Any())
            {
                dgvStudent.DataSource = result.CopyToDataTable();
                dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvStudent.Columns[0].Visible = false;
            }
            else
            {
                dgvStudent.Columns.Clear();
                dgvStudent.Refresh();
            }
        }

        private void tbSurnameSeek_TextChanged(object sender, EventArgs e)
        {
            seekBySurname();
        }

        public void changeDiscAndLab(int disc, int lab)
        {
            cbDiscipline.SelectedIndex = disc;
            cbLab.SelectedIndex = lab + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("" + cbDiscipline.SelectedIndex + " --- " + cbLab.SelectedIndex);
        }
    }
}
