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
    public partial class FormMemberSignin : Form
    {
 
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        bool isShow = false;
        public FormMemberSignin()
        {
            InitializeComponent();
        }

        private void FormMemberSignin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"localhost"; //伺服器名稱 很多種 ex. db.test.com.tw or @"db3.azure.com/note33" 用連線伺服器 看伺服器名稱
            scsb.InitialCatalog = "topic_fastfood"; //資料庫名稱
            scsb.IntegratedSecurity = true; // Windows驗證
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
        void Clearfield()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            dtp.Value = DateTime.Now;
        }

        private void btn_usersignin_Click(object sender, EventArgs e)
        {   

            if ((txtName.Text != "") && (txtPassword.Text != "") && (txtPhone.Text != "") && (txtPhone.Text.StartsWith("09")) && (txtPhone.Text.Length == 10) &&  (txtEmail.Text != "") && (txtAddress.Text != ""))
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
    }
}
