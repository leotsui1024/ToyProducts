using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ToyProducts
{
    public partial class FormToyProducts : Form
    {
        // local cache of the rows we need 暫存從資料庫抓出的書籍資料的表格
        private readonly DataTable dt = new DataTable();

        // current position in the table 追蹤目前選中的資料列索引
        private int rowIndex = 0;

        private string dbPath;
        private OleDbConnection con;

        public FormToyProducts()
        {
            InitializeComponent();
            dbPath = Path.Combine(Application.StartupPath, "ITP4915M.accdb");
            con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};");
        }


        private void LoadProductData()
        {
            try
            {
                if (!File.Exists(dbPath))
                {
                    MessageBox.Show("找不到資料庫檔案：" + dbPath, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sqlStr = "SELECT Product_ID, Product_Name, Product_Cost, Product_Price, Product_Quantity, Product_Category, Product_Status FROM ToyProducts";

                using (OleDbConnection conn = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStr, conn))
                {
                    dt.Clear();
                    adapter.Fill(dt);
                }

                dataproject.DataSource = dt;
                cboID.DataSource = dt;
                cboID.DisplayMember = "Product_ID";

                rowIndex = 0;
                UpdateTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤：" + ex.Message);
            }
        }

        private void UpdateTextBoxes()
        {
            textName.Text = dt.Rows[rowIndex]["Product_Name"].ToString();
            textCost.Text = dt.Rows[rowIndex]["Product_Cost"].ToString();
            textPrice.Text = dt.Rows[rowIndex]["Product_Price"].ToString();
            textQty.Text = dt.Rows[rowIndex]["Product_Quantity"].ToString();
            textPCat.Text = dt.Rows[rowIndex]["Product_Category"].ToString();
            textPStat.Text = dt.Rows[rowIndex]["Product_Status"].ToString();

            cboID.SelectedIndex = rowIndex; // 同步 ComboBox
        }


        private void ToyProducts_Load(object sender, EventArgs e)
        {
            LoadProductData();


        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        //選擇不同產品時自動更新資料
        {
            if (cboID.SelectedIndex >= 0)
            {
                rowIndex = cboID.SelectedIndex;
                UpdateTextBoxes();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnproduct_Click(object sender, EventArgs e) { }

        private void dataproject_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void textPStat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            rowIndex = 0;
            UpdateTextBoxes();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (rowIndex > 0)
            {
                rowIndex--;
                UpdateTextBoxes();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rowIndex < dt.Rows.Count - 1)
            {
                rowIndex++;
                UpdateTextBoxes();
            }
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            rowIndex = dt.Rows.Count - 1;
            UpdateTextBoxes();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0 || rowIndex < 0 || rowIndex >= dt.Rows.Count)
            {
                MessageBox.Show("目前無有效資料可更新。");
                return;
            }

            // 嘗試轉換數值欄位
            if (!int.TryParse(textNost.Text, out int cost) ||
                !int.TryParse(textNPrice.Text, out int price) ||
                !int.TryParse(textNQty.Text, out int qty))
            {
                MessageBox.Show("請確認成本、售價與庫存數量皆為有效數字！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 更新 DataTable 中的欄位值
            dt.Rows[rowIndex]["Product_Name"] = textNName.Text;
            dt.Rows[rowIndex]["Product_Cost"] = cost;
            dt.Rows[rowIndex]["Product_Price"] = price;
            dt.Rows[rowIndex]["Product_Quantity"] = qty;
            dt.Rows[rowIndex]["Product_Category"] = cboNPCat.Text;
            dt.Rows[rowIndex]["Product_Status"] = cboNPStat.Text;

            // 更新畫面顯示（同步至上方顯示欄位）
            UpdateTextBoxes();

            MessageBox.Show("✅ 已更新此筆產品資料（尚未儲存至資料庫）", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0 || rowIndex < 0 || rowIndex >= dt.Rows.Count)
            {
                MessageBox.Show("無可儲存的資料列。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateSql = @"
        UPDATE ToyProducts SET 
            Product_Name = ?, 
            Product_Cost = ?, 
            Product_Price = ?, 
            Product_Quantity = ?, 
            Product_Category = ?, 
            Product_Status = ?
        WHERE Product_ID = ?";

            try
            {
                using (OleDbConnection conn = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"))
                using (OleDbCommand cmd = new OleDbCommand(updateSql, conn))
                {
                    conn.Open();

                    // 加入參數（順序需與 SQL 中的 ? 對應）
                    cmd.Parameters.AddWithValue("?", dt.Rows[rowIndex]["Product_Name"]);
                    cmd.Parameters.AddWithValue("?", dt.Rows[rowIndex]["Product_Cost"]);
                    cmd.Parameters.AddWithValue("?", dt.Rows[rowIndex]["Product_Price"]);
                    cmd.Parameters.AddWithValue("?", dt.Rows[rowIndex]["Product_Quantity"]);
                    cmd.Parameters.AddWithValue("?", dt.Rows[rowIndex]["Product_Category"]);
                    cmd.Parameters.AddWithValue("?", dt.Rows[rowIndex]["Product_Status"]);
                    cmd.Parameters.AddWithValue("?", dt.Rows[rowIndex]["Product_ID"]);

                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("✅ 資料已成功儲存至 Access 資料庫！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("⚠ 資料未成功更新（找不到對應 Product_ID）。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫儲存錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReduction_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0 || rowIndex < 0 || rowIndex >= dt.Rows.Count)
            {
                MessageBox.Show("目前無資料可還原。");
                return;
            }

            textNName.Text = dt.Rows[rowIndex]["Product_Name"].ToString();
            textNost.Text = dt.Rows[rowIndex]["Product_Cost"].ToString();
            textNPrice.Text = dt.Rows[rowIndex]["Product_Price"].ToString();
            textNQty.Text = dt.Rows[rowIndex]["Product_Quantity"].ToString();
            cboNPCat.Text = dt.Rows[rowIndex]["Product_Category"].ToString();
            cboNPStat.Text = dt.Rows[rowIndex]["Product_Status"].ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductData();  // 重新從 Access 載入資料
            MessageBox.Show("✅ 已重新載入產品資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboID.SelectedIndex >= 0 && cboID.SelectedIndex < dt.Rows.Count)
            {
                rowIndex = cboID.SelectedIndex;

                // 更新顯示欄位
                UpdateTextBoxes();

                // 更新可編輯欄位
                textNName.Text = dt.Rows[rowIndex]["Product_Name"].ToString();
                textNost.Text = dt.Rows[rowIndex]["Product_Cost"].ToString();
                textNPrice.Text = dt.Rows[rowIndex]["Product_Price"].ToString();
                textNQty.Text = dt.Rows[rowIndex]["Product_Quantity"].ToString();
                cboNPCat.Text = dt.Rows[rowIndex]["Product_Category"].ToString();
                cboNPStat.Text = dt.Rows[rowIndex]["Product_Status"].ToString();
            }
        }

        private void btnAccountControl_Click(object sender, EventArgs e)
        {
            FormAccountControl accountControl = new FormAccountControl();

            accountControl.ShowDialog();
        }

        private void btnsystemMaintenance_Click(object sender, EventArgs e)
        {
            FormSystemMaintenance systemMaintenance = new FormSystemMaintenance();
            systemMaintenance.ShowDialog();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            DropFormInventoryControl inventoryControl = new DropFormInventoryControl();
            inventoryControl.Show();
            this.Hide();
        }
        private void btnsales_Click(object sender, EventArgs e)
        {

        }
        private void btnproject_Click(object sender, EventArgs e)
        {

        }
    }
}
