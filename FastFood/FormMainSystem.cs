using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class FormMainSystem : Form
    {
        public FormMainSystem()
        {
            InitializeComponent();
        }

        private void FormMainSystem_Load(object sender, EventArgs e)
        {
            FormLogin myformLogin = new FormLogin();
            myformLogin.ShowDialog();
            rolevisablefuntion();
        }
        void rolevisablefuntion()
        {
            //lbl_User.Text = $"{GlobalVar.username} {GlobalVar.userlimit} {GlobalVar.userid}";
            lbl_User.Text = $"{GlobalVar.username}";
            //產品上線記得把權限拿掉
            if ((GlobalVar.userlimit > 0) && (GlobalVar.userlimit <= 10))
            { //admin
                GlobalVar.ordercleck = GlobalVar.userlimit;
                btn_Order.Visible = true;

                btn_OrderManage.Visible = true;
                btn_Products.Visible = true;
                btn_Attedence.Visible = true;
                btn_Revenue.Visible = true;
                btn_signin.Visible = false;
                btn_MemberInfo.Visible = false;
                btn_ManageMemberInfo.Visible = true;
            }
            else if ((GlobalVar.userlimit > 10) && (GlobalVar.userlimit <= 20))
            { //店長
                GlobalVar.ordercleck = GlobalVar.userlimit;
                btn_Order.Visible = true;
                btn_OrderManage.Visible = true;
                btn_Products.Visible = true;
                btn_Attedence.Visible = true;
                btn_Revenue.Visible = true;
                btn_signin.Visible = false;
                btn_MemberInfo.Visible = false;
                btn_ManageMemberInfo.Visible = true;
            }
            else if ((GlobalVar.userlimit > 20) && (GlobalVar.userlimit <= 30))
            { //店員
                GlobalVar.ordercleck = GlobalVar.userlimit;
                btn_Order.Visible = true;
                btn_OrderManage.Visible = true;
                btn_Products.Visible = false;
                btn_Attedence.Visible = true;
                btn_Revenue.Visible = false;
                btn_signin.Visible = false;
                btn_MemberInfo.Visible = false;
                btn_ManageMemberInfo.Visible = true;
            }
            else if ((GlobalVar.userlimit >= 101) && (GlobalVar.userlimit <= 200))
            { //會員
                GlobalVar.ordercleck = 0;
                btn_Order.Visible = true;
                btn_MemberInfo.Visible = true;
                btn_OrderManage.Visible = false;
                btn_Products.Visible = false;
                btn_Attedence.Visible = false;
                btn_Revenue.Visible = false;
                btn_signin.Visible = false;
                btn_ManageMemberInfo.Visible = false;
            }
            else
            {
                if (GlobalVar.userlimit == 0)
                { //訪客
                    GlobalVar.ordercleck = 0;
                    btn_Order.Visible = true;
                    btn_MemberInfo.Visible = false;
                    btn_OrderManage.Visible = false;
                    btn_Products.Visible = false;
                    btn_Attedence.Visible = false;
                    btn_Revenue.Visible = false;
                    btn_signin.Visible = true;
                    btn_ManageMemberInfo.Visible = false;
                }
                else
                {
                    //其他
                    GlobalVar.ordercleck = 0;
                    btn_Order.Visible = false;
                    btn_MemberInfo.Visible = false;
                    btn_OrderManage.Visible = false;
                    btn_Products.Visible = false;
                    btn_Attedence.Visible = false;
                    btn_Revenue.Visible = false;
                    btn_signin.Visible = false;
                    btn_ManageMemberInfo.Visible = false;
                }
            }
        }
        private void btn_Order_Click(object sender, EventArgs e)
        {
            GlobalVar.CurrentMode = "OrderMode";
            FormProducts myformOrder = new FormProducts();
            myformOrder.ShowDialog();
        }

        private void btn_OrderManage_Click(object sender, EventArgs e)
        {
            FormOrder myformOrder = new FormOrder();
            myformOrder.ShowDialog();
        }

        private void btn_MemberInfo_Click(object sender, EventArgs e)
        {
            FormMemberInfo myformMemberInfo = new FormMemberInfo();
            myformMemberInfo.ShowDialog();
        }

        private void btn_Attedence_Click(object sender, EventArgs e)
        {
            FormAttendance myformAttendance = new FormAttendance();
            myformAttendance.ShowDialog();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            GlobalVar.CurrentMode = "ManageMode";
            FormProductManagement myFormProductManagement = new FormProductManagement();
            myFormProductManagement.ShowDialog();
        }



        private void btn_signin_Click(object sender, EventArgs e)
        {
            FormMemberSignin myFormMemberSignin = new FormMemberSignin();
            myFormMemberSignin.ShowDialog();
        }

        private void btn_ManageMemberInfo_Click(object sender, EventArgs e)
        {
            FormManageMemberInfo myformManageMemberInfo = new FormManageMemberInfo();
            myformManageMemberInfo.ShowDialog();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            GlobalVar.isLogin = false;
            GlobalVar.userrole = 0;
            GlobalVar.userlimit = 0;
            GlobalVar.username = "";
            GlobalVar.userid = 0;
            GlobalVar.empid = 0;
            GlobalVar.userphone = "";
            GlobalVar.ordercleck = 0;
            btn_Order.Visible = false;
            btn_MemberInfo.Visible = false;
            btn_OrderManage.Visible = false;
            btn_Products.Visible = false;
            btn_Attedence.Visible = false;
            btn_Revenue.Visible = false;
            btn_signin.Visible = false;
            btn_ManageMemberInfo.Visible = false;
            lbl_User.Text = "使用者已登出";
            FormLogin myFormLogin = new FormLogin();
            myFormLogin.ShowDialog();
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            FormRevenue myFormRevenue = new FormRevenue();
            myFormRevenue.ShowDialog();
        }

        private void FormMainSystem_Activated(object sender, EventArgs e)
        {
            rolevisablefuntion();
        }
    }
}
