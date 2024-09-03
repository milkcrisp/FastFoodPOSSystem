using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FastFood.FormProducts;

namespace FastFood
{
    public partial class FormProductsDetail : Form
    {
        public int LoadId = 0;
        string strReviseImgName = "";
        bool isReviseImg = false;
        int amount = 1;
        int price = 0;
        int price_total = 0;
        int finalprice = 0;
        private string selectedDrink = "";
        private string selectedCupSize = "";
        public event Action<int, string, int, int, string, string> OnAddToCart;
        int Category = 0;

        public FormProductsDetail()
        {
            InitializeComponent();
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            Console.WriteLine($"loadId: {LoadId}");
            Console.WriteLine($"user: {GlobalVar.userlimit}");
            if (GlobalVar.CurrentMode == "OrderMode")
            {
                SetupOrderMode();
            }
            else if (GlobalVar.CurrentMode == "ManageMode")
            {
                SetupManageMode();
            }

            void SetupOrderMode()
            {

                gBox_customer.Visible = true;
                gBox_Staff.Visible = false;
                txt_Pname.ReadOnly = true;
                txt_Desc.ReadOnly = true;
                txt_Pname.ReadOnly = true;
                txt_pCategory.Visible = false;
                // 設置其他與點餐相關的邏輯
            }

            void SetupManageMode()
            {
                gBox_customer.Visible = false;
                gBox_Staff.Visible = true;
                txt_Pname.ReadOnly = false;
                txt_Desc.ReadOnly = false;
                txt_Pname.ReadOnly = false;
                txt_pCategory.Visible = true;
                // 設置其他與管理相關的邏輯    
            }
            if (LoadId == 0)
            {
                //新增模式
                txt_Id.Visible = false;
                gBox_New.Visible = true;
                gBox_Revise.Visible = false;
                gBox_Delete.Visible = false;
            }
            else
            {
                //修改模式
                showProductDetailInfo();
                txt_Id.Visible = true;
                gBox_New.Visible = false;
                gBox_Revise.Visible = true;
                gBox_Delete.Visible = true;
            }
            radio_cola.Checked = true;
            radio_Medium.Checked = true;
        }
 

        void showProductDetailInfo()
        {
            if (LoadId > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from productsMenu where pid = @SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", LoadId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_Id.Text = reader["pid"].ToString();
                    txt_Pname.Text = reader["pname"].ToString();
                    price = (int)reader["pprice"];
                    lbl_totalmoney.Text = $"{price.ToString()}元";
                    txt_Price.Text = reader["pprice"].ToString();
                    txt_Desc.Text = reader["pdesc"].ToString();
                    strReviseImgName = reader["pimage"].ToString();
                    txt_pCategory.Text = reader["pCategory"].ToString();
                    Category = (int)reader["pCategory"];
                    string strFullImgpath = $"{GlobalVar.image_dir}\\{strReviseImgName}";
                    System.IO.FileStream fs = System.IO.File.OpenRead(strFullImgpath);
                    pictureBoxPimg.Image = Image.FromStream(fs); //fs只是單純讀檔 要在透過Image轉為圖片
                    fs.Close();
                    pictureBoxPimg.Tag = strFullImgpath;
                }

                if (Category == 1)
                {
                    gBox_combodrink.Visible = false;
                    gBox_Cupsize.Visible = true;
                }
                else if (Category >= 2) 
                {
                    gBox_combodrink.Visible = true;
                    gBox_Cupsize.Visible = true;
                }
                else
                {
                    gBox_combodrink.Visible = false;
                    gBox_Cupsize.Visible = false;
                }
                reader.Close();
                con.Close();
            }
        }
        void count_totalprice()
        {
            finalprice = price + GetCupSizePrice(selectedCupSize);
            price_total = finalprice * amount;
            lbl_totalmoney.Text = $"{price_total}元";
        }
        private void tbox_amount_TextChanged(object sender, EventArgs e)
        {
            if (tbox_amount.Text != "")
            {
                bool isCorrrect = Int32.TryParse(tbox_amount.Text, out amount);

                if ((isCorrrect) && (amount > 0) && (amount < 99))
                {
                    count_totalprice();
                }
                else
                {
                    //輸入不正確
                    MessageBox.Show("數量輸入不正確, 請重新輸入 (1 - 99) ");
                    amount = 1;
                }
            }
            //exe: 加入杯數加減鈕(+)(-)(觸控螢幕友善)
        }
        private void btn_plus_Click(object sender, EventArgs e)
        {
            if ((amount > 0) && (amount < 99))
                amount++;
            else
                amount = 99;
            tbox_amount.Text = amount.ToString();
            count_totalprice();
        }

        private void btn_substration_Click(object sender, EventArgs e)
        {
            if ((amount > 0) && (amount < 99))
                amount--;
            else
                amount = 0;
            tbox_amount.Text = amount.ToString();
            count_totalprice();
        }
        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbox_amount.Text, out int quantity) && quantity > 0)
            {

                if (Category >= 2)
                {
                    Console.WriteLine(Category);
                    count_totalprice();
                    OnAddToCart?.Invoke(LoadId, txt_Pname.Text, finalprice, quantity, selectedDrink, selectedCupSize);
                }
                else if(Category == 1)
                {
                    Console.WriteLine(Category);
                    count_totalprice();
                    OnAddToCart?.Invoke(LoadId, txt_Pname.Text, finalprice, quantity, txt_Pname.Text, selectedCupSize);
                }
                else
                {
                    Console.WriteLine(Category);
                    selectedCupSize = null;
                    selectedDrink = null;
                    OnAddToCart?.Invoke(LoadId, txt_Pname.Text, finalprice, quantity, selectedDrink, selectedCupSize);
                }

                Close(); // 關閉詳細視窗
            }
            else
            {
                MessageBox.Show("數量無效！");
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region radio_drink
        private void radio_cola_CheckedChanged(object sender, EventArgs e)
        {
            selectedDrink = "可樂";
        }

        private void radio_soda_CheckedChanged(object sender, EventArgs e)
        {
            selectedDrink = "七喜";
        }

        private void radio_applejuice_CheckedChanged(object sender, EventArgs e)
        {
            selectedDrink = "蘋果汁";
        }

        private void radio_lemonblacktea_CheckedChanged(object sender, EventArgs e)
        {
            selectedDrink = "檸檬風味紅茶";
        }

        private void radio_Large_CheckedChanged(object sender, EventArgs e)
        {
            
            selectedCupSize = "大";
            count_totalprice();
        }

        private void radio_Medium_CheckedChanged(object sender, EventArgs e)
        {
            
            selectedCupSize = "中";
            count_totalprice();
        }

        private void radio_Small_CheckedChanged(object sender, EventArgs e)
        {
            
            selectedCupSize = "小";
            count_totalprice();
        }
        private int GetCupSizePrice(string cupSize)
        {
            // 假設這裡根據選擇的杯型返回對應的價格
            // 可以從資料庫或配置中獲取
            switch (cupSize)
            {
                case "小": return -3;
                case "中": return 0;
                case "大": return 5;
                default: return 0;
            }
        }
        #endregion

        private void btn_ReviseSave_Click(object sender, EventArgs e)
        {
            if ((txt_Pname.Text != " ") && (txt_Price.Text != "") && (txt_Desc.Text != "") && pictureBoxPimg.Image != null) //沒東西 NULL
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update productsMenu set pname = @NewPname, pprice = @NewPrice, pdesc = @NewPdesc, pimage = @NewPimage , pCategory = @NewCategory where pid = @SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", LoadId);
                cmd.Parameters.AddWithValue("@NewPname", txt_Pname.Text);
                int intPrice = 0;
                Int32.TryParse(txt_Price.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPdesc", txt_Desc.Text);
                cmd.Parameters.AddWithValue("@NewPimage", strReviseImgName);
                int cg = 0;
                Int32.TryParse(txt_pCategory.Text, out cg);
                cmd.Parameters.AddWithValue("@NewCategory", cg);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (isReviseImg == true)
                {
                    string strFullFilePath = $"{GlobalVar.image_dir}\\{strReviseImgName}";
                    pictureBoxPimg.Tag = strFullFilePath;
                    pictureBoxPimg.Image.Save(strFullFilePath);
                    isReviseImg = false;
                }

                MessageBox.Show($"商品資訊修改成功");

            }
        }

        private void btn_ReviseChooseImg_Click(object sender, EventArgs e)
        {
            ChooseProductImg();
        }
        void ChooseProductImg()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(JPEG, JPG, PNG)|*.jpeg;*.jpg;*.png";
            DialogResult R = ofd.ShowDialog();

            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pictureBoxPimg.Image = Image.FromStream(fs);
                fs.Close();
                pictureBoxPimg.Tag = ofd.FileName;
                string strImgsubname = Path.GetExtension(ofd.FileName).ToLower();
                Random myRnd = new Random();
                strReviseImgName = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + strImgsubname;
                isReviseImg = true;
                Console.WriteLine(strReviseImgName);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txt_Id.Text, out intId);

            if (intId > 0)
            {
                // 彈出確認對話框
                DialogResult result = MessageBox.Show("您確定要刪除這個商品嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string strSQL = "DELETE FROM productsMenu WHERE pid = @DeleteId";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteId", intId);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    // 刪除圖片文件
                    if (pictureBoxPimg.Tag != null && System.IO.File.Exists(pictureBoxPimg.Tag.ToString()))
                    {
                        System.IO.File.Delete(pictureBoxPimg.Tag.ToString());
                    }

                    // 清空字段
                    clearfiled();

                    MessageBox.Show($"資料刪除成功, {rows}列受影響");
                }
                else
                {
                    MessageBox.Show("刪除操作已取消");
                }
            }
            else
            {
                MessageBox.Show("無效的商品ID");
            }
        }
        void clearfiled()
        {
            txt_Id.Clear();
            txt_Pname.Clear();
            txt_Desc.Clear();
            txt_Price.Clear();
            txt_pCategory.Clear();
            pictureBoxPimg.Image = null;
        }

        private void btn_NewChooseImg_Click(object sender, EventArgs e)
        {
            ChooseProductImg();
        }

        private void btn_NewSave_Click(object sender, EventArgs e)
        {
            if ((txt_Pname.Text != "") && (txt_Price.Text != "") && (txt_Desc.Text != "") && (txt_pCategory.Text !="") && pictureBoxPimg.Image != null) //沒東西 NULL
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    string strSQL = "insert into productsMenu (pname, pprice,pDesc, pimage, pCategory)values(@NewPname, @NewPrice, @NewPdesc, @NewPimage, @NewCategory);";
                    SqlCommand cmd = new SqlCommand(strSQL, con, transaction);
                    cmd.Parameters.AddWithValue("@NewPname", txt_Pname.Text);
                    int intPrice = 0;
                    Int32.TryParse(txt_Price.Text, out intPrice);
                    cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                    cmd.Parameters.AddWithValue("@NewPdesc", txt_Desc.Text);
                    cmd.Parameters.AddWithValue("@NewPimage", strReviseImgName);
                    int cg = 0;
                    Int32.TryParse(txt_pCategory.Text, out cg);
                    cmd.Parameters.AddWithValue("@NewCategory", cg);
                    cmd.ExecuteNonQuery();
 
                    if (isReviseImg == true)
                    {
                        string strFullFilePath = $"{GlobalVar.image_dir}\\{strReviseImgName}";
                        //pictureBoxPimg.Tag = strFullFilePath;
                        pictureBoxPimg.Image.Save(strFullFilePath);
                        isReviseImg = false;
                    }
                    transaction.Commit();
                    MessageBox.Show($"商品新增成功");
                }
                catch (Exception ex)
                {
                    // 回滾交易
                    transaction.Rollback();
                    MessageBox.Show("提交訂單時發生錯誤: " + ex.Message);
                }
                con.Close();

            }
            
        }

        private void btn_ClearFiled_Click(object sender, EventArgs e)
        {
            clearfiled();
        }
    }
}
