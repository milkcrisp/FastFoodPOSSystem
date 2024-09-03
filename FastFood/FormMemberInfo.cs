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
using System.IO;
namespace FastFood
{
    public partial class FormMemberInfo : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        bool isShow = false;
        public FormMemberInfo()
        {
            InitializeComponent();
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "topic_fastfood";
            scsb.IntegratedSecurity = true;
            Console.WriteLine(GlobalVar.userid);
            loadMemberInfo();
            showPassword();
        }
        void loadMemberInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "";

                strSQL = $"select * from Members where mid = {GlobalVar.userid};";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // 確保有讀取到資料
                {
                    txt_ID.Text = reader["mid"].ToString();
                    txtName.Text = reader["mName"].ToString();
                    txtPassword.Text = reader["mPassword"].ToString();
                    txtPhone.Text = reader["mPhone"].ToString();
                    txtEmail.Text = reader["mEmail"].ToString();
                    txtAddress.Text = reader["mAddress"].ToString();
                    dtp.Value = (DateTime)reader["mBirthDay"];
                }
                else
                {
                    MessageBox.Show("目前沒有資料");
                }
                reader.Close();
                con.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_usersignin_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txt_ID.Text, out intId);//合理性檢查

            if ((intId > 0) && (txtName.Text != "") && (txtPassword.Text != "") && (txtPhone.Text != "") && (txtPhone.Text.StartsWith("09")) && (txtPhone.Text.Length == 10) && (txtEmail.Text != "") && (txtAddress.Text != ""))
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            isShow = !isShow;
            showPassword();
        }
        void showPassword()
        {
            if (isShow)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        #region 視窗
        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    lastForm.X + (Cursor.Position.X - lastCursor.X),
                    lastForm.Y + (Cursor.Position.Y - lastCursor.Y));
            }
        }

        private void guna2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        #endregion
    }
}
