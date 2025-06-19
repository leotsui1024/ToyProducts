using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ToyProducts
{
    public partial class NewPassword : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ITP4915M.accdb");

        public NewPassword()
        {
            InitializeComponent();
        }

        // 👉 登入按鈕事件
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string userID = txtUserID.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("新密碼與確認密碼不符", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtNewPassword.Focus();
                return;
            }

            if (!CheckPasswordStrength(newPassword))
            {
                MessageBox.Show("密碼必須包含：\n- 至少8個字符\n- 至少1個大寫字母\n- 至少1個數字",
                    "密碼強度不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 資料庫更新
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = @"UPDATE Staffs 
                                     SET Staff_Password = @newPassword 
                                     WHERE Staff_Name = @userID";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@userID", userID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("密碼更新成功", "完成",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("找不到指定使用者", "錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"密碼更新失敗：{ex.Message}", "嚴重錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 👉 密碼強度檢查
        private bool CheckPasswordStrength(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit);
        }

        // 👉 清空欄位
        private void ClearFields()
        {
            txtUserID.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        // 👉 連線字串
        private string GetConnectionString()
        {
            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ITP4915M.accdb";
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
