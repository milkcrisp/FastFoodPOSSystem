using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class FormRevenue : Form
    {
        private int totalRevenue = 0;
        public FormRevenue()
        {
            InitializeComponent();
        }


        private void FormRevenue_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            cmbReportType.Items.Add("Custom");
            cmbReportType.Items.Add("Yearly");
            cmbReportType.Items.Add("Monthly");
            cmbReportType.Items.Add("Daily");
            cmbReportType.SelectedIndex = 0;

            radio_All.Checked = true;
            txtMaxAmount.Text = 9999.ToString();
            txtMinAmount.Text = 0.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region 視窗

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    lastForm.X + (Cursor.Position.X - lastCursor.X),
                    lastForm.Y + (Cursor.Position.Y - lastCursor.Y));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }
        #endregion

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // 取得用戶選擇的日期範圍
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            string reportType = cmbReportType.SelectedItem.ToString();

            // 取得金額區間
            int minAmount = string.IsNullOrEmpty(txtMinAmount.Text) ? 0 : Convert.ToInt32(txtMinAmount.Text);
            int maxAmount = string.IsNullOrEmpty(txtMaxAmount.Text) ? int.MaxValue : Convert.ToInt32(txtMaxAmount.Text);

            // 判斷外帶或內用
            bool isTakeaway = radio_Takeaway.Checked;
            bool isDineIn = radio_DineIn.Checked;

            // 構建SQL查詢語句
            string query = BuildRevenueQuery(startDate, endDate, reportType, minAmount, maxAmount, isTakeaway, isDineIn);

            // 執行查詢並取得結果
            DataTable dt = ExecuteRevenueQuery(query);

            // 將結果顯示在DataGridView中
            DGV_Revenue.DataSource = dt;

            // 計算總營業額

            if (cmbReportType.SelectedIndex == 0)
            {
                totalRevenue = dt.AsEnumerable().Sum(row => row.Field<int?>("oTotalAmount") ?? 0);

            }
            else if (dt.Rows.Count > 0 && dt.Columns.Contains("TotalRevenue")) // 檢查是否存在彙總結果
            {
                totalRevenue = dt.AsEnumerable()
                                 .Sum(row => row.Field<int?>("TotalRevenue") ?? 0);
            }
            labelTotalRevenue.Text = $"總營業額: {totalRevenue:C}";
        }
        private string BuildRevenueQuery(DateTime startDate, DateTime endDate, string reportType, decimal minAmount, decimal maxAmount, bool isTakeaway, bool isDineIn)
        {
            string query = "SELECT ";

            switch (reportType)
            {
                case "Daily":
                    query += "CONVERT(VARCHAR(10), oDate, 120) AS ReportDate, SUM(oTotalAmount) AS TotalRevenue, COUNT(oid) AS OrderCount ";
                    break;
                case "Monthly":
                    query += "YEAR(oDate) AS ReportYear, MONTH(oDate) AS ReportMonth, SUM(oTotalAmount) AS TotalRevenue, COUNT(oid) AS OrderCount ";
                    break;
                case "Yearly":
                    query += "YEAR(oDate) AS ReportYear, SUM(oTotalAmount) AS TotalRevenue, COUNT(oid) AS OrderCount ";
                    break;
                case "Custom":
                    query += "oid, oDate, oTotalAmount, isTakeaway, isBag "; // 如果是自定義報告，不需要分組
                    break;
            }

            query += "FROM Orders WHERE oDate BETWEEN @startDate AND @endDate";
            query += " AND oTotalAmount BETWEEN @minAmount AND @maxAmount";

            if (isTakeaway)
            {
                query += " AND isTakeaway = 1";
            }
            else if (isDineIn)
            {
                query += " AND isTakeaway = 0";
            }

            switch (reportType)
            {
                case "Daily":
                    query += " GROUP BY CONVERT(VARCHAR(10), oDate, 120)";
                    break;
                case "Monthly":
                    query += " GROUP BY YEAR(oDate), MONTH(oDate)";
                    break;
                case "Yearly":
                    query += " GROUP BY YEAR(oDate)";
                    break;
            }

            query += " ORDER BY ";

            switch (reportType)
            {
                case "Daily":
                    query += "ReportDate";
                    break;
                case "Monthly":
                    query += "ReportYear, ReportMonth";
                    break;
                case "Yearly":
                    query += "ReportYear";
                    break;
                default:
                    query += "oDate";
                    break;
            }

            return query;
        }

        private DataTable ExecuteRevenueQuery(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value.Date);
                    cmd.Parameters.AddWithValue("@minAmount", string.IsNullOrEmpty(txtMinAmount.Text) ? 0 : Convert.ToInt32(txtMinAmount.Text));
                    cmd.Parameters.AddWithValue("@maxAmount", string.IsNullOrEmpty(txtMaxAmount.Text) ? int.MaxValue : Convert.ToInt32(txtMaxAmount.Text));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }
        private void btnExportReport_Click(object sender, EventArgs e)
        {
            if (DGV_Revenue.Rows.Count > 0)
            {
                // 生成文件名稱
                string fileName = GenerateFileName();

                // 指定保存路徑
                string directory = @"C:\Users\a1382\Documents\Training\Code\Topic\FastFood\report";
                string fullPath = Path.Combine(directory, fileName);

                SaveReportToFile((DataTable)DGV_Revenue.DataSource, totalRevenue, fullPath);
                MessageBox.Show($"報告已成功保存為: {fullPath}");
            }
            else
            {
                MessageBox.Show("沒有資料可供導出！");
            }
        }
        private string GenerateFileName()
        {
            // 生成當日日期 + 亂碼的流水號
            string datePart = DateTime.Now.ToString("yyyyMMddHHmmss");
            string randomPart = new Random().Next(100000, 999999).ToString();
            return $"{datePart}{randomPart}.txt";
        }

        private void SaveReportToFile(DataTable dt, decimal totalRevenue, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("訂單ID, 訂單日期, 總金額, 外帶, 使用購物袋");
                sw.WriteLine("==========================================");

                foreach (DataRow row in dt.Rows)
                {
                    string line = $"{row["oid"]}, {row["oDate"]}, {row["oTotalAmount"]}, {row["isTakeaway"]}, {row["isBag"]}";
                    sw.WriteLine(line);
                }

                sw.WriteLine("==========================================");
                sw.WriteLine($"總營業額: {totalRevenue:C}");
            }
        }
    }
}
