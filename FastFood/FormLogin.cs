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
    public partial class FormLogin : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"localhost";
            scsb.InitialCatalog = "topic_fastfood";
            scsb.IntegratedSecurity = true;

            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            radio_Member.Checked = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string strPassword = txt_Password.Text.Trim();
            string strUserInput = txt_User.Text.Trim();
            if (!string.IsNullOrEmpty(strUserInput) && !string.IsNullOrEmpty(strPassword))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string tablename = "";

                switch (GlobalVar.userrole)
                {
                    case 1:
                        tablename = "Employee";
                        break;
                    case 2:
                        tablename = "Members";
                        break;
                    default:
                        break;
                }
                string strSQL = "";
                if (tablename == "Employee")
                {
                    /*OR ephone = @SearchPhone)*/
                    strSQL = $"select * from {tablename} WHERE eid = @SearchUser  AND epassword = @SearchPassword";
                }
                else if(tablename == "Members")
                {
                    strSQL = $"SELECT * FROM {tablename} WHERE (mid = @SearchUser OR mphone = @SearchPhone) AND mpassword = @SearchPassword"; ;
                }

                SqlCommand cmd = new SqlCommand(strSQL, con);
                //cmd.Parameters.AddWithValue("@SearchUser", intId);
                cmd.Parameters.AddWithValue("@SearchUser", strUserInput);
                cmd.Parameters.AddWithValue("@SearchPhone", strUserInput);
                cmd.Parameters.AddWithValue("@SearchPassword", strPassword);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //登入成功
                    GlobalVar.isLogin = true;
                    if (tablename == "Employee")
                    {
                        GlobalVar.username = reader["eName"].ToString();
                        GlobalVar.userid = 0;
                        GlobalVar.empid = (int)reader["eid"];
                        GlobalVar.userlimit = (int)reader["ePermission"];
                        Console.WriteLine(GlobalVar.userlimit);
                    }
                    else if (tablename == "Members")
                    {
                        GlobalVar.username = reader["mName"].ToString();
                        GlobalVar.userid = (int)reader["mid"];
                        GlobalVar.userlimit = (int)reader["mPermission"];
                        GlobalVar.userphone = reader["mPhone"].ToString();
                        Console.WriteLine(GlobalVar.userlimit);

                    }
                    
                     // 1-10: admin, 11-20:店長, 21-30:店員 101-200:會員, 0:訪客
                                             // 資料庫設計有權限欄位的話 (int)reader["id"];
                    MessageBox.Show("登入成功");
                    reader.Close();
                    con.Close();
                    this.Close();
                }
                if (GlobalVar.isLogin == false)
                {
                    //為甚麼不直接else 因為reader會讀到資料 但不一定是正確的登入資訊 所以要用isLogin判斷
                    MessageBox.Show ("登入資料有誤, 請重新登入");
                }

                reader.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("登入欄位未填!!");
            }
        }

        private void radio_Member_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.userrole = 2;
        }

        private void radio_Staff_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.userrole = 1;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.isLogin)
            {

            }
            else
            {
                MessageBox.Show("請先登入！");
                e.Cancel = true;
            }
        }


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

        private void btn_GuestLogin_Click(object sender, EventArgs e)
        {
            // 設置訪客模式
            GlobalVar.isLogin = true;
            GlobalVar.username = "訪客";
            GlobalVar.userid = 0;  // 訪客的ID設置為0或其他值
            GlobalVar.userlimit = 0; // 訪客的權限設置為0
            MessageBox.Show("以訪客身份登入成功");
            this.Close();
        }

        private void btn_membersignin_Click(object sender, EventArgs e)
        {
            FormMemberSignin myFormMemberSignin = new FormMemberSignin();
            myFormMemberSignin.ShowDialog();
        }

        bool isShow = false;
        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            isShow = !isShow;
            showPassword();
        }
        void showPassword()
        {
            if (isShow)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }
    }
}
