using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        {
        }

        {
            }


            {
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", textUserName.Text);
                        command.Parameters.AddWithValue("@password", textUserPassword.Text);

                        OleDbDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            this.Hide();
                        }
                        else
                        {
                            textUserName.Text = "";
                            textUserPassword.Text = "";
                            textUserName.Focus();
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("登入時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textUserPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // 保留 UI 控制項事件空殼（若未用可刪）
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
