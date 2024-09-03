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

namespace FastFood
{
    public partial class FormManageMemberInfo : Form
    {
        int DGVNum = 0;
        public FormManageMemberInfo()
        {
            InitializeComponent();
        }

        private void FormManageMemberInfo_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "topic_fastfood";
            scsb.IntegratedSecurity = true;
            Console.WriteLine(GlobalVar.userid);
            loadMemberInfo();
            cmb_MemberStatus.Items.Add("Active");
            cmb_MemberStatus.Items.Add("Inactive");
            cmb_MemberStatus.Items.Add("Banned");
            cmb_MemberStatus.Items.Add("VIP");
            cmb_MemberStatus.SelectedIndex = 0;
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
        void loadMemberInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "";

                strSQL = $"select top 200 * from Members;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();//中介物件
                    dt.Load(reader); //載入reader資料
                    DGVNum = dt.Rows.Count;
                    DGV_Member.DataSource = dt;
                }
                reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_Member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGVNum))
            {
                string strID = DGV_Member.Rows[e.RowIndex].Cells[0].Value.ToString(); //Cells[0]-欄位index 0的位置即為ID .Value 代表該欄位的值 
                int selectId = 0;
                Int32.TryParse(strID, out selectId);
                showMemberInfo(selectId);
            }
        }
        void showMemberInfo(int myId)
        {
            if (myId > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "SELECT * from Members where mid = @SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", myId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txt_ID.Text = reader["mid"].ToString(); // id原本為int
                    txtName.Text = (string)reader["mName"];
                    txtPassword.Text = (string)reader["mPassword"];
                    txtPhone.Text = (string)reader["mPhone"];
                    txtEmail.Text = (string)reader["mEmail"];
                    txtAddress.Text = (string)reader["mAddress"];
                    dtp.Value = (DateTime)reader["mBirthDay"];
                    Console.WriteLine("資料搜尋成功");
                }
                else
                {
                    Console.WriteLine("查無此人");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("ID錯誤");
            }

        }
        private void btn_Revise_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txt_ID.Text, out intId);//合理性檢查

            if ((txtName.Text != "") && (txtPassword.Text != "") && (txtPhone.Text != "") && (txtPhone.Text.StartsWith("09")) && (txtPhone.Text.Length == 10) && (txtEmail.Text != "") && (txtAddress.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string strSQL = "update members set mName = @NewName , mPassword = @NewPassword, mEmail = @NewEmail, mPhone = @NewPhone, mAddress = @NewAddress, mBirthDay = @NewBirthday where mid = @SearchId";
                    SqlCommand cmd = new SqlCommand(strSQL, con, transaction);
                    cmd.Parameters.AddWithValue("@SearchId", intId);
                    cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewBirthday", dtp.Value);

                    cmd.ExecuteNonQuery(); //只執行 不查詢
                    MessageBox.Show($"會員資料修改成功");
                    transaction.Commit();
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }


        private void btn_showAllInfo_Click(object sender, EventArgs e)
        {
            loadMemberInfo();
        }

        private void btn_SearchBy_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            // 動態構建查詢語句
            string strSQL = "SELECT * FROM Members WHERE 1=1"; // 使用 1=1 簡化動態條件拼接
            SqlCommand cmd = new SqlCommand();

            // 檢查各個 TextBox 並添加對應的條件
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                strSQL += " AND mName LIKE @SearchName";
                cmd.Parameters.AddWithValue("@SearchName", $"%{txtName.Text}%");
            }
            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                strSQL += " AND mPhone LIKE @SearchPhone";
                cmd.Parameters.AddWithValue("@SearchPhone", $"%{txtPhone.Text}%");
            }
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                strSQL += " AND mEmail LIKE @SearchEmail";
                cmd.Parameters.AddWithValue("@SearchEmail", $"%{txtEmail.Text}%");
            }
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                strSQL += " AND mAddress LIKE @SearchAddress";
                cmd.Parameters.AddWithValue("@SearchAddress", $"%{txtAddress.Text}%");
            }

            cmd.CommandText = strSQL;
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txt_ID.Text = reader["mid"].ToString(); // id原本為int
                txtName.Text = (string)reader["mName"];
                txtPassword.Text = (string)reader["mPassword"];
                txtPhone.Text = (string)reader["mPhone"];
                txtEmail.Text = (string)reader["mEmail"];
                txtAddress.Text = (string)reader["mAddress"];
                dtp.Value = (DateTime)reader["mBirthDay"];

                Console.WriteLine("資料搜尋成功");
            }
            else
            {
                MessageBox.Show("查無此人");
                Console.WriteLine("查無此人");
            }

            reader.Close();
            con.Close();
        }

        void Clearfield()
        {
            txt_ID.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            dtp.Value = new DateTime(1980, 1, 1);
        }

        private void btn_usersignin_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPassword.Text != "") && (txtPhone.Text != "") && (txtPhone.Text.StartsWith("09")) && (txtPhone.Text.Length == 10) && (txtEmail.Text != "") && (txtAddress.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string strSQL = "insert into members (mName, mPassword, mEmail, mPhone, mAddress, mBirthDay) values(@NewName, @NewPassword, @NewEmail, @NewPhone, @NewAddress, @NewBirthday)";
                    SqlCommand cmd = new SqlCommand(strSQL, con, transaction);
                    cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewBirthday", dtp.Value);

                    cmd.ExecuteNonQuery(); //只執行 不查詢
                    MessageBox.Show($"會員註冊成功");
                    transaction.Commit();
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void btn_Cleartxt_Click(object sender, EventArgs e)
        {
            Clearfield();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_mStatus_Click(object sender, EventArgs e)
        {
            if (DGV_Member.SelectedRows.Count > 0)
            {
                // 獲取選中的訂單ID
                int selectedMemberId = Convert.ToInt32(DGV_Member.SelectedRows[0].Cells["mid"].Value);

                // 獲取選中的訂單狀態
                string selectedStatus = cmb_MemberStatus.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedStatus))
                {
                    // 更新訂單的狀態
                    using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                    {
                        con.Open();
                        string query = "UPDATE Members SET mMembershipStatus = @status WHERE mid = @mid";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@status", selectedStatus);
                            cmd.Parameters.AddWithValue("@mid", selectedMemberId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 更新顯示的訂單列表
                    loadMemberInfo();
                    MessageBox.Show("會員狀態已更新");
                }
                else
                {
                    MessageBox.Show("請先選擇會員狀態");
                }
            }
            else
            {
                MessageBox.Show("請先選擇一位會員");
            }
        }
    }
}
