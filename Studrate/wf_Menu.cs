using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Studrate
{
    public partial class wf_Menu : Form
    {
        public wf_Menu()
        {
            InitializeComponent();
        }

        private void bAddData_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "wf_addData")
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    return;
                }
            }
            wf_addData t = new wf_addData();
            t.Show();
        }

        private void bDiscLabLis_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "wf_discLabList")
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    return;
                }
            }
            wf_discLabList t = new wf_discLabList();
            t.Show();
        }

        private void bStudPlagList_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "wf_studPlagList")
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    return;
                }
            }
            wf_studPlagList t = new wf_studPlagList();
            t.Show();
        }

        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        /// <summary>
        /// Clear all data existed in the database
        /// </summary>
        private void ClearAllData()
        {
            int n = Application.OpenForms.Count;
            for (int i = 1; i < n; i++)
                if (Application.OpenForms[1].Name != "wf_Menu")
                    Application.OpenForms[1].Close();

            string connectionString = ConfigurationManager.ConnectionStrings["StudentPlag"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand c_deleteAll = new SqlCommand("spDeleteAll", connection))
                {
                    connection.Open();
                    c_deleteAll.CommandType = CommandType.StoredProcedure;
                    c_deleteAll.ExecuteScalar();
                }
                MessageBox.Show("Data successfully deleted", "Completed");
            }
            catch (SqlException sqlExc)
            {
                new ErrorHandler(sqlExc.Number, sqlExc.Message);
            }
        }

        /// <summary>
        /// Ask about clear all data existed in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear all data existed in the database?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ClearAllData();
        }
    }
}
