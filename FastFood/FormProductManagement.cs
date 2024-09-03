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
using System.Data.SqlClient;
namespace FastFood
{
    public partial class FormProductManagement : Form
    {
        List<string> list_pname = new List<string>(); //value
        List<int> list_price = new List<int>(); //value
        List<int> list_Id = new List<int>(); //key
        public FormProductManagement()
        {
            InitializeComponent();
        }

        private void FormProductManagement_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"localhost";
            scsb.InitialCatalog = "topic_fastfood";
            scsb.IntegratedSecurity = true;
            load_productsdb();
        }
        void load_productsdb()
        {
            try
            {
                list_Id.Clear();
                list_pname.Clear();
                list_price.Clear();
                imageListproduct.Images.Clear();
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "";

                strSQL = $"select top 200 * from productsMenu;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    list_Id.Add((int)reader["pId"]);
                    list_pname.Add((string)reader["pname"]);
                    list_price.Add((int)reader["pprice"]);
                    string image_name = (string)reader["pimage"];
                    string Fullimagepath = $"{GlobalVar.image_dir}\\{image_name}";
                    Console.WriteLine(Fullimagepath);
                    FileStream fs = File.OpenRead(Fullimagepath);
                    Image img_product = Image.FromStream(fs);

                    imageListproduct.Images.Add(img_product);
                    fs.Close();


                    count++;
                }

                reader.Close();
                con.Close();
                Console.WriteLine($"讀取{count}筆資料");
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
        void ListViewImageMod()
        {
            //顯示ListView圖片模式
            listView_ProductShowcase.Clear();
            listView_ProductShowcase.View = View.LargeIcon; // LargeIcon, Tile, List, SmallIcon
            imageListproduct.ImageSize = new Size(120, 120);
            listView_ProductShowcase.LargeImageList = imageListproduct;

            for (int i = 0; i < list_Id.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{list_pname[i]} {list_price[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = list_Id[i];
                listView_ProductShowcase.Items.Add(item);
            }

        }
        private void btn_img_Click(object sender, EventArgs e)
        {
            // panel
            panelSide.Height = btn_img.Height;
            panelSide.Top = btn_img.Top;
            ListViewImageMod();
        }
        void ListViewListMod()
        {
            listView_ProductShowcase.Clear();
            listView_ProductShowcase.LargeImageList = null;
            listView_ProductShowcase.SmallImageList = null;//快取有可能沒清空 會顯示圖片 所以要預設為null
            listView_ProductShowcase.View = View.Details;
            listView_ProductShowcase.Columns.Add("id", 100);
            listView_ProductShowcase.Columns.Add("商品名稱", 200);
            listView_ProductShowcase.Columns.Add("商品價格", 100);
            listView_ProductShowcase.GridLines = true;
            listView_ProductShowcase.FullRowSelect = true; //選取整列

            for (int i = 0; i < list_Id.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = list_Id[i];
                item.Text = list_Id[i].ToString();
                item.SubItems.Add(list_pname[i]);
                item.SubItems.Add(list_price[i].ToString());
                item.ForeColor = Color.DarkBlue;

                listView_ProductShowcase.Items.Add(item);

            }
        }
        private void btn_list_Click(object sender, EventArgs e)
        {

            panelSide.Height = btn_list.Height;
            panelSide.Top = btn_list.Top;
            ListViewListMod();
        }

        private void btn_newproduct_Click(object sender, EventArgs e)
        {
            panelSide.Height = btn_newproduct.Height;
            panelSide.Top = btn_newproduct.Top;
            FormProductsDetail myformProductsDetail = new FormProductsDetail();
            myformProductsDetail.ShowDialog();
        }
        #region 視窗
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;

            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    lastForm.X + (Cursor.Position.X - lastCursor.X),
                    lastForm.Y + (Cursor.Position.Y - lastCursor.Y));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        #endregion

        private void listView_ProductShowcase_ItemActivate(object sender, EventArgs e)
        {
            
            FormProductsDetail myOrderFromDetail = new FormProductsDetail();
            myOrderFromDetail.LoadId = (int)listView_ProductShowcase.SelectedItems[0].Tag;// selectedItems是集合 [0]為第一個item Tag在上面的程式碼有加入ID Tag為物件 須轉型int用小括號即可
            myOrderFromDetail.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        void DataReload()
        {
            list_Id.Clear();
            list_pname.Clear();
            list_price.Clear();
            imageListproduct.Images.Clear();
            load_productsdb();

            if (listView_ProductShowcase.View == View.Details)
            {
                ListViewListMod();
            }
            else
            {
                ListViewImageMod();
            }
        }
        private void FormProductManagement_Activated(object sender, EventArgs e)
        {
            DataReload();
        }
    }
}
