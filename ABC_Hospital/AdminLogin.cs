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

namespace ABC_Hospital
{
    public partial class AdminLogin : Form
    {
        public static AdminLogin AdminLoginInstance;
        public AdminLogin()
        {
            InitializeComponent();
            AdminLoginInstance = this;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HILYASHATIKA\SQLEXPRESS;Initial Catalog=ABC_Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AdLoginButton_Click(object sender, EventArgs e)

        {
            String  AdminID, Password;

            AdminID = AdminIdtextBox.Text;
            Password = AdminPasswordtextBox.Text;

            try
            {
                String querry = "SELECT * FROM AdminLogin WHERE AdminID = '" + AdminIdtextBox.Text + "' AND password = '" + AdminPasswordtextBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    AdminID = AdminIdtextBox.Text;
                    Password = AdminPasswordtextBox.Text;

                    // Page that needs to load next
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdminIdtextBox.Clear();
                    AdminPasswordtextBox.Clear();

                    AdminIdtextBox.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
