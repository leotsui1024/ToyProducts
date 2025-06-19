using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ToyProducts
{
    public partial class ToyProducts : Form
    {
        private string dbPath;
        private OleDbConnection con;

        public ToyProducts()
        {
            InitializeComponent();
            dbPath = Path.Combine(Application.StartupPath, "ITP4915M.accdb");
            con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};");
        }

        private void FillDGV()
        {
            try
            {
                if (!File.Exists(dbPath))
                {
                    MessageBox.Show("找不到資料庫檔案：" + dbPath, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "SELECT * FROM [ToyProducts]";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataproject.DataSource = dt;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("資料庫錯誤: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ToyProducts_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void butproduct_Click(object sender, EventArgs e) { }

        private void dataproject_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
