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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace FastFood
{
    public partial class FormProducts : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int totalAmount = 0;
        List<string> list_pname = new List<string>(); //value
        List<int> list_price = new List<int>(); //value
        List<int> list_Id = new List<int>(); //key
        bool isTakeaway = false;
        bool isBag = false;
        private List<CartItem> shoppingCart = new List<CartItem>();
        // 委派定義
        public delegate void AddToCartHandler(int productId, string productName, int price, int quantity, string drink, string cupSize);
        public event AddToCartHandler OnAddToCart;
        public FormProducts()
        {
            InitializeComponent();
            //初始化委派
            OnAddToCart += AddToCart;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"localhost";
            scsb.InitialCatalog = "topic_fastfood";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            //load_productsdb();
            // panel
            panelSide.Height = btn_home.Height;
            panelSide.Top = btn_home.Top;
            // 隱藏購物車相關的控制項
            gBox_mainmenu.Visible = true;
            listView_ProductShowcase.Visible = false;
            listView_Cart.Visible = false;
            gBox_Cart.Visible = false;
            //如果用會員登入 直接顯示手機
            txt_phone.Text = GlobalVar.userphone;
        }
        void load_productsdb(int Category)
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
                
                strSQL = $"select top 200 * from productsMenu where pCategory = {Category};";
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
            gBox_mainmenu.Visible = false;
            listView_ProductShowcase.Visible = true;
            listView_Cart.Visible = false;
            gBox_Cart.Visible = false;
            //顯示ListView圖片模式
            listView_ProductShowcase.Clear();
            listView_ProductShowcase.OwnerDraw = true;
            listView_ProductShowcase.View = View.LargeIcon; // LargeIcon, Tile, List, SmallIcon
            imageListproduct.ImageSize = new Size(140, 140);
            listView_ProductShowcase.LargeImageList = imageListproduct;

            for (int i = 0; i < list_Id.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{list_pname[i]}";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = list_Id[i];
                listView_ProductShowcase.Items.Add(item);
            }
            listView_ProductShowcase.DrawItem += new DrawListViewItemEventHandler(listView_ProductShowcase_DrawItem);

        }
        private void listView_ProductShowcase_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            
            // 繪製背景
            e.DrawBackground();

            // 計算圖片和文字的位置
            int imageSize = 120;
            int spacing = 5;
            int textHeight = 30; // 根據需要調整文字高度

            // 計算中心位置
            int contentHeight = textHeight + spacing + imageSize;
            int offsetY = (e.Bounds.Height - contentHeight) / 2;

            Rectangle textRect = new Rectangle(
                e.Bounds.Left + (e.Bounds.Width - imageSize) / 2,
                e.Bounds.Top + offsetY,
                imageSize,
                textHeight);

            Rectangle imageRect = new Rectangle(
                e.Bounds.Left + (e.Bounds.Width - imageSize) / 2,
                e.Bounds.Top + offsetY + textHeight + spacing,
                imageSize,
                imageSize);

            // 繪製文字
            string itemText = e.Item.Text;
            Font itemFont = e.Item.Font;
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoClipping;

            TextRenderer.DrawText(e.Graphics, itemText, itemFont, textRect, Color.Black, flags);

            // 繪製圖像
            if (e.Item.ImageList != null)
            {
                Image img = e.Item.ImageList.Images[e.Item.ImageIndex];
                e.Graphics.DrawImage(img, imageRect);
            }

            // 繪製分隔線
            using (Pen pen = new Pen(Color.Gray))
            {
                // 繪製水平分隔線
                e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
                // 繪製垂直分隔線
                e.Graphics.DrawLine(pen, e.Bounds.Right - 1, e.Bounds.Top, e.Bounds.Right - 1, e.Bounds.Bottom);
            }
        }


        private void btn_home_Click(object sender, EventArgs e)
        {
            panelSide.Height = btn_home.Height;
            panelSide.Top = btn_home.Top;
            gBox_mainmenu.Visible = true;
            listView_ProductShowcase.Visible = false;
            listView_Cart.Visible = false;
            gBox_Cart.Visible = false;
        }

        private void btn_Mainset_Click(object sender, EventArgs e)
        {
            panelSide.Height = btn_Mainset.Height;
            panelSide.Top = btn_Mainset.Top;
            load_productsdb(2);
            ListViewImageMod();
        }

        private void btn_noodleset_Click(object sender, EventArgs e)
        {
            panelSide.Height = btn_noodleset.Height;
            panelSide.Top = btn_noodleset.Top;
            load_productsdb(3);
            ListViewImageMod();
        }

        private void btn_breakfastset_Click(object sender, EventArgs e)
        {
            panelSide.Height = btn_breakfastset.Height;
            panelSide.Top = btn_breakfastset.Top;
            load_productsdb(4);
            ListViewImageMod();
        }

        private void btn_single_Click(object sender, EventArgs e)
        {
            panelSide.Height = btn_single.Height;
            panelSide.Top = btn_single.Top;

            load_productsdb(0);
            ListViewImageMod();
        }

        private void btn_drink_Click(object sender, EventArgs e)
        {
            panelSide.Height = btn_drink.Height;
            panelSide.Top = btn_drink.Top;
            load_productsdb(1);
            ListViewImageMod();
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            panelSide.Height = btn_cart.Height;
            panelSide.Top = btn_cart.Top;

            DisplayShoppingCart();
            // 顯示購物車相關的控制項
            gBox_mainmenu.Visible = false;
            gBox_Cart.Visible = true;
        }
        
        public void DisplayShoppingCart()
        {
            listView_ProductShowcase.Visible = false;
            listView_Cart.Visible = true;

            listView_Cart.Clear(); // 清除 ListView 的舊內容
            listView_Cart.View = View.Details;
            listView_Cart.Columns.Add("商品名稱", 200);
            listView_Cart.Columns.Add("價格", 100);
            listView_Cart.Columns.Add("數量", 100);
            listView_Cart.Columns.Add("總計", 100);
            listView_Cart.GridLines = true;
            listView_Cart.FullRowSelect = true;

            foreach (var item in shoppingCart)
            {
                ListViewItem listViewItem = new ListViewItem(item.ProductName);
                listViewItem.SubItems.Add(item.Price.ToString("C"));
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add((item.Price * item.Quantity).ToString("C"));
                listViewItem.Tag = item; // 綁定 CartItem 到 ListViewItem
                listView_Cart.Items.Add(listViewItem);
            }

            countAmount(); // 更新總金額的 Label
        }
        public void AddToCart(int productId, string productName, int price, int quantity, string drink, string cupSize)
        {

            shoppingCart.Add(new CartItem
            {
                ProductId = productId,
                ProductName = productName,
                Price = price,
                Quantity = quantity,
                Drink = drink,
                CupSize = cupSize
            });
            UpdateCartView(); // 更新購物車視圖
        }

        public void UpdateCartView()
        {
            DisplayShoppingCart();
            panelSide.Height = btn_cart.Height;
            panelSide.Top = btn_cart.Top;
            gBox_mainmenu.Visible = false;
            gBox_Cart.Visible = true;
            countAmount();

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView_ProductShowcase_ItemActivate(object sender, EventArgs e)
        {
            int selectedProductId = (int)listView_ProductShowcase.SelectedItems[0].Tag;

            // 假設是點餐模式
            FormProductsDetail myProductsDetail = new FormProductsDetail();
            myProductsDetail.LoadId = selectedProductId;  // 傳遞商品ID
            myProductsDetail.OnAddToCart += AddToCart;    // 訂閱 OnAddToCart 事件
            myProductsDetail.ShowDialog();

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listView_Cart.SelectedItems.Count > 0)
            {
                var selectedItem = listView_Cart.SelectedItems[0];
                var itemToRemove = shoppingCart.FirstOrDefault(item => item.ProductName == selectedItem.Text);
                if (itemToRemove != null)
                {
                    shoppingCart.Remove(itemToRemove);
                    UpdateCartView();
                }
                lbl_OrderTotalprice.Text = $"總金額: {totalAmount:C}元";
            }
            else
            {
                MessageBox.Show("請選擇要移除的品項！");
            }
        }
        
        private void btn_clearall_Click(object sender, EventArgs e)
        {
            shoppingCart.Clear();
            UpdateCartView();
        }
        int countAmount()
        {
            totalAmount = 0;

            foreach (var item in shoppingCart)
            {
                totalAmount += item.Price * item.Quantity;
            }

            // 加上塑膠袋的費用
            if (isBag)
            {
                totalAmount += 2; // 假設塑膠袋的費用是2元
            }
            lbl_OrderTotalprice.Text = $"總金額: {totalAmount:C}元";
            return totalAmount;
        }
        private void chk_takeaway_CheckedChanged(object sender, EventArgs e)
        {
            isTakeaway = chk_takeaway.Checked;
        }

        private void chk_bag_CheckedChanged(object sender, EventArgs e)
        {
            isBag = chk_bag.Checked;
            countAmount();
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            // 判斷是否為現場點餐
            bool isOnsiteOrder = GlobalVar.userlimit <= 30;

            // 檢查電話號碼的有效性
            bool isPhoneNumberValid = txt_phone.Text.Length == 10 && txt_phone.Text.StartsWith("09");

            if (!isOnsiteOrder && !isPhoneNumberValid)
            {
                MessageBox.Show("請輸入有效的電話號碼，電話號碼必須為10位數，並以09開頭");
                return;
            }

            if (shoppingCart.Count == 0)
            {
                MessageBox.Show("請先選購餐點");
                return;
            }

            if (isOnsiteOrder)
            {
                GlobalVar.OrderphoneInfo = string.Empty; // 現場點餐不要求輸入電話號碼
            }
            else
            {
                GlobalVar.OrderphoneInfo = txt_phone.Text;
            }

            GlobalVar.isTakeaway = isTakeaway;
            GlobalVar.isBag = isBag;
            SaveOrderToDatabase();
            Close();
        }
        private void SaveOrderToDatabase()
        {
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            // 開始交易
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                // 插入訂單
                string insertOrderSQL = @"
                INSERT INTO Orders (mid, oDate, oTotalAmount, oStatus, eid, isTakeaway, isBag, Phonenumber)
                VALUES (@mid, @oDate, @oTotalAmount, @oStatus, @eid, @isTakeaway, @isBag, @Phonenumber);
                SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(insertOrderSQL, con, transaction);
                cmd.Parameters.AddWithValue("@mid", GlobalVar.userid); // 如果是會員
                cmd.Parameters.AddWithValue("@oDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@oTotalAmount", countAmount());
                cmd.Parameters.AddWithValue("@oStatus", "Pending"); // 假設訂單狀態為待處理
                cmd.Parameters.AddWithValue("@eid", GlobalVar.ordercleck); // 假設你有記錄當前處理訂單的員工ID
                cmd.Parameters.AddWithValue("@isTakeaway", isTakeaway);
                cmd.Parameters.AddWithValue("@isBag", isBag);
                // 判斷電話號碼是否需要插入
                if (string.IsNullOrEmpty(txt_phone.Text) || GlobalVar.userlimit <= 30)
                {
                    string phone = "現場點餐";
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone); // 員工點餐時，允許電話號碼為空
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", txt_phone.Text);
                }
                Console.WriteLine($"總金額{countAmount()}元");
                int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                // 插入訂單詳細品項
                foreach (var item in shoppingCart)
                {
                    string insertOrderDetailsSQL = @"
                    INSERT INTO OrderDetail (oid, pid, Quantity, UnitPrice, Drink, CupSize)
                    VALUES (@oid, @pid, @Quantity, @UnitPrice, @Drink, @CupSize)";

                    SqlCommand detailCmd = new SqlCommand(insertOrderDetailsSQL, con, transaction);
                    detailCmd.Parameters.AddWithValue("@oid", orderId);
                    detailCmd.Parameters.AddWithValue("@pid", item.ProductId);
                    detailCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                    detailCmd.Parameters.AddWithValue("@UnitPrice", item.Price);
                    detailCmd.Parameters.AddWithValue("@Drink", string.IsNullOrEmpty(item.Drink) ? (object)DBNull.Value : item.Drink);
                    detailCmd.Parameters.AddWithValue("@CupSize", string.IsNullOrEmpty(item.CupSize) ? (object)DBNull.Value : item.CupSize);
                    detailCmd.ExecuteNonQuery();
                }

                // 提交交易
                transaction.Commit();
                MessageBox.Show("訂單已成功提交！");
            }
            catch (Exception ex)
            {
                // 回滾交易
                transaction.Rollback();
                MessageBox.Show("提交訂單時發生錯誤: " + ex.Message);
            }

            con.Close();
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
        private CartItem selectedCartItem;
        private void listView_Cart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Cart.SelectedItems.Count > 0)
            {
                selectedCartItem = listView_Cart.SelectedItems[0].Tag as CartItem;
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (selectedCartItem != null)
            {
                selectedCartItem.Quantity++;
                UpdateCartView();
            }
            else
            {
                MessageBox.Show("請先選擇一個商品！");
            }
        }

        private void btn_substration_Click(object sender, EventArgs e)
        {
            if (selectedCartItem != null)
            {
                if (selectedCartItem.Quantity > 1)
                {
                    selectedCartItem.Quantity--;
                    UpdateCartView();
                }
                else
                {
                    MessageBox.Show("數量不能少於 1！");
                }
            }
            else
            {
                MessageBox.Show("請先選擇一個商品！");
            }
        }
    }
}
