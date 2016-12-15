using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Studrate
{
    public partial class wf_discLabList : Form
    {
        private string connectionString;
        public wf_discLabList()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StudentPlag"].ConnectionString;
            viewDiscipline();
        }

        public void viewDiscipline()
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
                    lbDiscipline.DisplayMember = "Nickname";
                    lbDiscipline.ValueMember = "Id_discipline";
                    lbDiscipline.DataSource = disciplineList;
                }
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        public void viewLab()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_selectLab = new SqlCommand("spViewLab", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(c_selectLab))
                {
                    c_selectLab.CommandType = CommandType.StoredProcedure;
                    c_selectLab.Parameters.AddWithValue("@id_discipline", lbDiscipline.SelectedValue);
                    DataTable labList = new DataTable();
                    adapter.Fill(labList);
                    lbLab.DisplayMember = "Lab_number";
                    lbLab.ValueMember = "Id_lab";
                    lbLab.DataSource = labList;
                }
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

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

        private void bLabAdd_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "wf_addLab")
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    return;
                }
            }
            wf_addLab t = new wf_addLab(this);            
            t.Show();
        }

        /// <summary>
        /// Update discipline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRefresh_Click(object sender, EventArgs e)
        {
            viewDiscipline();
        }

        /// <summary>
        /// Upade lab list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewLab();
        }

        private void bDisciplineDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_deleteDiscipline = new SqlCommand("spDeleteDiscipline", connection))
                {
                    connection.Open();
                    c_deleteDiscipline.CommandType = CommandType.StoredProcedure;
                    c_deleteDiscipline.Parameters.AddWithValue("@id_discipline", lbDiscipline.SelectedValue);
                    c_deleteDiscipline.ExecuteScalar();
                }
                lbLab.DataSource = null;
                viewDiscipline();
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }            
          
        }

        private void bLabDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_deleteLab = new SqlCommand("spDeleteLab", connection))
                {
                    connection.Open();
                    c_deleteLab.CommandType = CommandType.StoredProcedure;
                    c_deleteLab.Parameters.AddWithValue("@id_lab", lbLab.SelectedValue);
                    c_deleteLab.Parameters.AddWithValue("@id_discipline", lbDiscipline.SelectedValue);
                    c_deleteLab.ExecuteScalar();
                }
                viewLab();
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }            
        }

        /// <summary>
        /// Open studPlagList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbLab_DoubleClick(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "wf_studPlagList")
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    var a = (wf_studPlagList)f;
                    a.changeDiscAndLab(lbDiscipline.SelectedIndex, lbLab.SelectedIndex);
                    f.Focus();
                    return;
                }
            }
            wf_studPlagList t = new wf_studPlagList();
            t.changeDiscAndLab(lbDiscipline.SelectedIndex, lbLab.SelectedIndex);
            t.Show();
        }
    }
}
