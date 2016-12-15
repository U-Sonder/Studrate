using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Studrate
{
    public partial class wf_addLab : Form
    {
        private string connectionString;

        // Forms where this one is called
        public wf_discLabList bigForm;

        public wf_addLab(wf_discLabList r)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StudentPlag"].ConnectionString;
            bigForm = r;
            comboFillDiscipline();
        }

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
                    cbDiscipline.SelectedIndex = bigForm.lbDiscipline.SelectedIndex;
                }
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        private void bAddLab_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_insertLab = new SqlCommand("spInsertLab", connection))
                {
                    connection.Open();
                    c_insertLab.CommandType = CommandType.StoredProcedure;
                    c_insertLab.Parameters.AddWithValue("@lab_number", tbLabNumber.Text);
                    c_insertLab.Parameters.AddWithValue("@id_discipline", cbDiscipline.SelectedValue);
                    c_insertLab.ExecuteScalar();
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
        /// <param name="e"></param>
        private void keyPressInt(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Input only number");
            }
        }

        private void tbLabNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressInt(e);
        }

        /// <summary>
        /// Reselect discipline and lab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wf_addLab_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bigForm.lbDiscipline.SelectedIndex != cbDiscipline.SelectedIndex)
                bigForm.lbDiscipline.SelectedIndex = cbDiscipline.SelectedIndex;
            else
                bigForm.viewLab();
        }
    }
}
