using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace FastFood
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = "localhost";
            scsb.InitialCatalog = "topic_fastfodd";
            scsb.IntegratedSecurity = true;
            LoadOrders();
            cmb_OrderStatus.Items.Add("Pending");
            cmb_OrderStatus.Items.Add("Shipped");
            cmb_OrderStatus.Items.Add("Cancelled");
            cmb_OrderStatus.Items.Add("Delayed");
            // 填充 ComboBox 用於選擇搜尋欄位
            cmb_SearchBy.Items.Add("訂單ID");
            cmb_SearchBy.Items.Add("會員ID");
            cmb_SearchBy.Items.Add("員工ID");
            cmb_SearchBy.Items.Add("狀態");
            cmb_SearchBy.SelectedIndex = 0;

            // 設置 DateTimePicker 的初始值
            dtp_StartDate.Value = DateTime.Today.AddMonths(-1); // 預設為一個月前
            dtp_EndDate.Value = DateTime.Today;
            txt_MinAmount.Text = "0";
            txt_MaxAmount.Text = "9999";
            radio_All.Checked = true;
            DGV_Order.ReadOnly = false;
            DGV_OrderDetail.ReadOnly = false;

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
        private void LoadOrders()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            /*oid, mid, oDate, oTotalAmount, oStatus, eid, Phonenumber, isTakeaway, isBag*/
            string strSQL = "SELECT top 200 * FROM Orders Order by oid DESC ";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV_Order.DataSource = dt;
            // 設置不可編輯的列
            DGV_Order.Columns["oid"].ReadOnly = true;
            DGV_Order.Columns["mid"].ReadOnly = true;
            DGV_Order.Columns["eid"].ReadOnly = true;
            DGV_Order.Columns["oStatus"].ReadOnly = true;
            DGV_Order.Columns["oTotalAmount"].ReadOnly = true;
            con.Close();

        }

        private void LoadOrderDetails(int orderId)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT oDetailId, oid, pid, Quantity, UnitPrice, Drink, CupSize FROM OrderDetail WHERE oid = @oid";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@oid", orderId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV_OrderDetail.DataSource = dt;
            // 設置不可編輯的列
            DGV_OrderDetail.Columns["oDetailId"].ReadOnly = true;
            DGV_OrderDetail.Columns["oid"].ReadOnly = true;
            DGV_OrderDetail.Columns["pid"].ReadOnly = true;
            con.Close();
        }

        private void DGV_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 確保點擊的行是有效的
            if (e.RowIndex >= 0)
            {
                // 從點擊的行中獲取訂單ID
                int selectedOrderId = Convert.ToInt32(DGV_Order.Rows[e.RowIndex].Cells["oid"].Value);
                LoadOrderDetails(selectedOrderId);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_UpdateOrderStatus_Click(object sender, EventArgs e)
        {
            if (DGV_Order.SelectedRows.Count > 0)
            {
                // 獲取選中的訂單ID
                int selectedOrderId = Convert.ToInt32(DGV_Order.SelectedRows[0].Cells["oid"].Value);

                // 獲取選中的訂單狀態
                string selectedStatus = cmb_OrderStatus.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedStatus))
                {
                    // 更新訂單的狀態
                    using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                    {
                        con.Open();
                        string query = "UPDATE Orders SET oStatus = @status WHERE oid = @oid";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@status", selectedStatus);
                            cmd.Parameters.AddWithValue("@oid", selectedOrderId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 更新顯示的訂單列表
                    LoadOrders();
                    MessageBox.Show("訂單狀態已更新");
                }
                else
                {
                    MessageBox.Show("請先選擇訂單狀態");
                }
            }
            else
            {
                MessageBox.Show("請先選擇一個訂單");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_Search.Text;
            string searchField = cmb_SearchBy.SelectedItem.ToString();
            DateTime startDate = dtp_StartDate.Value;
            DateTime endDate = dtp_EndDate.Value;
            decimal minAmount = string.IsNullOrEmpty(txt_MinAmount.Text) ? 0 : Convert.ToDecimal(txt_MinAmount.Text);
            decimal maxAmount = string.IsNullOrEmpty(txt_MaxAmount.Text) ? decimal.MaxValue : Convert.ToDecimal(txt_MaxAmount.Text);

            string query = "SELECT oid, mid, oDate, oTotalAmount, oStatus, eid, Phonenumber, isTakeaway, isBag  FROM Orders WHERE oDate BETWEEN @startDate AND @endDate";

            if (!string.IsNullOrEmpty(searchValue))
            {
                switch (searchField)
                {
                    case "訂單ID":
                        query += " AND oid = @searchValue";
                        break;
                    case "會員ID":
                        query += " AND mid = @searchValue";
                        break;
                    case "狀態":
                        query += " AND oStatus LIKE @searchValue";
                        break;
                }
            }

            // 加入外帶/內用/全部檢視的篩選條件
            if (radio_Takeaway.Checked)
            {
                query += " AND isTakeaway = 1";
            }
            else if (radio_DineIn.Checked)
            {
                query += " AND isTakeaway = 0";
            }
            // 如果 "全部" 被選中，則不加任何額外的條件

            // 加入金額區間篩選條件
            query += " AND oTotalAmount BETWEEN @minAmount AND @maxAmount";

            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@minAmount", minAmount);
                    cmd.Parameters.AddWithValue("@maxAmount", maxAmount);

                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        if (searchField == "訂單ID" || searchField == "會員ID")
                        {
                            cmd.Parameters.AddWithValue("@searchValue", int.Parse(searchValue));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DGV_Order.DataSource = dt;
                }
            }
        }

        private void DGV_Order_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 獲取編輯後的值
                int orderId = Convert.ToInt32(DGV_Order.Rows[e.RowIndex].Cells["oid"].Value);
                string columnName = DGV_Order.Columns[e.ColumnIndex].Name;
                object newValue = DGV_Order.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // 更新數據庫
                using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                {
                    con.Open();
                    string query = $"UPDATE Orders SET {columnName} = @newValue WHERE oid = @orderId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@newValue", newValue);
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("訂單已更新");
            }
        }

        private void DGV_OrderDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // 獲取編輯後的值
                int orderDetailId = Convert.ToInt32(DGV_OrderDetail.Rows[e.RowIndex].Cells["oDetailId"].Value);
                string columnName = DGV_OrderDetail.Columns[e.ColumnIndex].Name;
                object newValue = DGV_OrderDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // 更新 OrderDetail 表中的數據
                using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                {
                    con.Open();
                    string query = $"UPDATE OrderDetail SET {columnName} = @newValue WHERE oDetailId = @orderDetailId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@newValue", newValue);
                        cmd.Parameters.AddWithValue("@orderDetailId", orderDetailId);
                        cmd.ExecuteNonQuery();
                    }

                    // 重新計算並更新訂單的總金額
                    int orderId = Convert.ToInt32(DGV_OrderDetail.Rows[e.RowIndex].Cells["oid"].Value);
                    UpdateOrderTotalAmount(con, orderId);
                }

                MessageBox.Show("訂單詳情已更新");
            }

        }
        private void UpdateOrderTotalAmount(SqlConnection con, int orderId)
        {
            // 查詢該訂單的所有訂單詳情，計算總金額
            string query = "SELECT SUM(Quantity * UnitPrice) AS TotalAmount FROM OrderDetail WHERE oid = @oid";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@oid", orderId);
                object result = cmd.ExecuteScalar();
                decimal newTotalAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                // 更新 Orders 表中的總金額
                string updateOrderQuery = "UPDATE Orders SET oTotalAmount = @newTotalAmount WHERE oid = @oid";
                using (SqlCommand updateCmd = new SqlCommand(updateOrderQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@newTotalAmount", newTotalAmount);
                    updateCmd.Parameters.AddWithValue("@oid", orderId);
                    updateCmd.ExecuteNonQuery();
                }
            }

            // 重新加載訂單數據以顯示更新後的總金額
            LoadOrders();
        }
    }
}
