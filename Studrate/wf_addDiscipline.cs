using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Studrate
{
    public partial class wf_addDiscipline : Form
    {
        private string connectionString;

        // Forms where this one is called
        private wf_discLabList Form_discLabList; 
        private wf_addData Form_addData;

        public wf_addDiscipline(wf_discLabList r)
        {            
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StudentPlag"].ConnectionString;
            Form_discLabList = r;
        }
        public wf_addDiscipline(wf_addData r)
        {            
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StudentPlag"].ConnectionString;
            Form_addData = r;
        }

        private void bAddDiscipline_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_insertDiscipline = new SqlCommand("spInsertDiscipline", connection))
                {
                    connection.Open();
                    c_insertDiscipline.CommandType = CommandType.StoredProcedure;
                    c_insertDiscipline.Parameters.AddWithValue("@nickname", tbNickname.Text);
                    c_insertDiscipline.Parameters.AddWithValue("@fullname", tbFullname.Text);
                    c_insertDiscipline.Parameters.AddWithValue("@course", tbCourse.Text);
                    c_insertDiscipline.ExecuteScalar();

                }
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
            Close();
        }

        /// <summary>
        /// Validation for input only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Input only number");
            }            
        }

        /// <summary>
        /// Reselect discipline and lab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wf_addDiscipline_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form_discLabList != null)
            {
                Form_discLabList.viewDiscipline();
                Form_discLabList.lbDiscipline.SelectedIndex = Form_discLabList.lbDiscipline.Items.Count - 1;
            }
            else if (Form_addData != null)
            {
                Form_addData.comboFillDiscipline();
                Form_addData.cbDiscipline.SelectedIndex = Form_addData.cbDiscipline.Items.Count - 1;
            }
        }
    }
}
