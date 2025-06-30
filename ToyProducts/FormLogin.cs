using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ToyProducts
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ITP4915M.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //btnLogin
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ITP4915M.accdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Staffs WHERE Staff_Name = @userID and Staff_Password = @password";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", textUserName.Text);
                    command.Parameters.AddWithValue("@password", textUserPassword.Text);

                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // ✅ 讀取員工姓名與 ID
                        string userID = reader["Staff_Name"]!.ToString();
                        string userName = reader["Staff_Name"]!.ToString();

                        // ✅ 傳入 FormToyProducts
                        FormToyProducts formTarget = new FormToyProducts();
                        formTarget.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserID or Password, Please Try Again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textUserName.Text = "";
                        textUserPassword.Text = "";
                        textUserName.Focus();
                    }
                    reader.Close();
                }
            }

        }
    }
}
