namespace FastFood
{
    partial class FormProducts
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cart = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btn_drink = new System.Windows.Forms.Button();
            this.btn_single = new System.Windows.Forms.Button();
            this.btn_breakfastset = new System.Windows.Forms.Button();
            this.btn_noodleset = new System.Windows.Forms.Button();
            this.btn_Mainset = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.listView_ProductShowcase = new System.Windows.Forms.ListView();
            this.imageListproduct = new System.Windows.Forms.ImageList(this.components);
            this.listView_Cart = new System.Windows.Forms.ListView();
            this.gBox_Cart = new System.Windows.Forms.GroupBox();
            this.btn_output = new System.Windows.Forms.Button();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_OrderTotalprice = new System.Windows.Forms.Label();
            this.chk_bag = new System.Windows.Forms.CheckBox();
            this.chk_takeaway = new System.Windows.Forms.CheckBox();
            this.gBox_mainmenu = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_substration = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gBox_Cart.SuspendLayout();
            this.gBox_mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btn_cart);
            this.panel1.Controls.Add(this.panelSide);
            this.panel1.Controls.Add(this.btn_drink);
            this.panel1.Controls.Add(this.btn_single);
            this.panel1.Controls.Add(this.btn_breakfastset);
            this.panel1.Controls.Add(this.btn_noodleset);
            this.panel1.Controls.Add(this.btn_Mainset);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 724);
            this.panel1.TabIndex = 0;
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cart.FlatAppearance.BorderSize = 0;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_cart.Image = global::FastFood.Properties.Resources.cart;
            this.btn_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cart.Location = new System.Drawing.Point(24, 566);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(214, 77);
            this.btn_cart.TabIndex = 8;
            this.btn_cart.Text = "  購物車";
            this.btn_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panelSide.Location = new System.Drawing.Point(-2, 83);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(24, 77);
            this.panelSide.TabIndex = 2;
            // 
            // btn_drink
            // 
            this.btn_drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_drink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_drink.FlatAppearance.BorderSize = 0;
            this.btn_drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_drink.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_drink.Image = global::FastFood.Properties.Resources.soda;
            this.btn_drink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_drink.Location = new System.Drawing.Point(24, 483);
            this.btn_drink.Name = "btn_drink";
            this.btn_drink.Size = new System.Drawing.Size(214, 77);
            this.btn_drink.TabIndex = 7;
            this.btn_drink.Text = "  飲品";
            this.btn_drink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_drink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_drink.UseVisualStyleBackColor = false;
            this.btn_drink.Click += new System.EventHandler(this.btn_drink_Click);
            // 
            // btn_single
            // 
            this.btn_single.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_single.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_single.FlatAppearance.BorderSize = 0;
            this.btn_single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_single.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_single.Image = global::FastFood.Properties.Resources.logo11;
            this.btn_single.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_single.Location = new System.Drawing.Point(24, 403);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(211, 77);
            this.btn_single.TabIndex = 6;
            this.btn_single.Text = "  美味丹點";
            this.btn_single.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_single.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_single.UseVisualStyleBackColor = false;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            // 
            // btn_breakfastset
            // 
            this.btn_breakfastset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_breakfastset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_breakfastset.FlatAppearance.BorderSize = 0;
            this.btn_breakfastset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_breakfastset.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_breakfastset.Image = global::FastFood.Properties.Resources.toast;
            this.btn_breakfastset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_breakfastset.Location = new System.Drawing.Point(24, 323);
            this.btn_breakfastset.Name = "btn_breakfastset";
            this.btn_breakfastset.Size = new System.Drawing.Size(211, 77);
            this.btn_breakfastset.TabIndex = 6;
            this.btn_breakfastset.Text = "  早安特惠餐";
            this.btn_breakfastset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_breakfastset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_breakfastset.UseVisualStyleBackColor = false;
            this.btn_breakfastset.Click += new System.EventHandler(this.btn_breakfastset_Click);
            // 
            // btn_noodleset
            // 
            this.btn_noodleset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_noodleset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_noodleset.FlatAppearance.BorderSize = 0;
            this.btn_noodleset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noodleset.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_noodleset.Image = global::FastFood.Properties.Resources.noodles;
            this.btn_noodleset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noodleset.Location = new System.Drawing.Point(24, 243);
            this.btn_noodleset.Name = "btn_noodleset";
            this.btn_noodleset.Size = new System.Drawing.Size(214, 77);
            this.btn_noodleset.TabIndex = 4;
            this.btn_noodleset.Text = "  大碗豪爽餐";
            this.btn_noodleset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noodleset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_noodleset.UseVisualStyleBackColor = false;
            this.btn_noodleset.Click += new System.EventHandler(this.btn_noodleset_Click);
            // 
            // btn_Mainset
            // 
            this.btn_Mainset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_Mainset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Mainset.FlatAppearance.BorderSize = 0;
            this.btn_Mainset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mainset.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Mainset.Image = global::FastFood.Properties.Resources.hamburger;
            this.btn_Mainset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mainset.Location = new System.Drawing.Point(24, 163);
            this.btn_Mainset.Name = "btn_Mainset";
            this.btn_Mainset.Size = new System.Drawing.Size(214, 77);
            this.btn_Mainset.TabIndex = 3;
            this.btn_Mainset.Text = "  精選定食餐";
            this.btn_Mainset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mainset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Mainset.UseVisualStyleBackColor = false;
            this.btn_Mainset.Click += new System.EventHandler(this.btn_Mainset_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_home.Image = global::FastFood.Properties.Resources.menu;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(24, 83);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(214, 77);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "  主選單";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(238, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 77);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_close.Image = global::FastFood.Properties.Resources.remove_;
            this.btn_close.Location = new System.Drawing.Point(1058, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(59, 52);
            this.btn_close.TabIndex = 9;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // listView_ProductShowcase
            // 
            this.listView_ProductShowcase.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_ProductShowcase.HideSelection = false;
            this.listView_ProductShowcase.Location = new System.Drawing.Point(285, 83);
            this.listView_ProductShowcase.Name = "listView_ProductShowcase";
            this.listView_ProductShowcase.Size = new System.Drawing.Size(1005, 593);
            this.listView_ProductShowcase.TabIndex = 10;
            this.listView_ProductShowcase.UseCompatibleStateImageBehavior = false;
            this.listView_ProductShowcase.ItemActivate += new System.EventHandler(this.listView_ProductShowcase_ItemActivate);
            // 
            // imageListproduct
            // 
            this.imageListproduct.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListproduct.ImageSize = new System.Drawing.Size(256, 256);
            this.imageListproduct.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView_Cart
            // 
            this.listView_Cart.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_Cart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView_Cart.HideSelection = false;
            this.listView_Cart.Location = new System.Drawing.Point(285, 83);
            this.listView_Cart.Name = "listView_Cart";
            this.listView_Cart.Size = new System.Drawing.Size(1005, 295);
            this.listView_Cart.TabIndex = 11;
            this.listView_Cart.UseCompatibleStateImageBehavior = false;
            this.listView_Cart.SelectedIndexChanged += new System.EventHandler(this.listView_Cart_SelectedIndexChanged);
            // 
            // gBox_Cart
            // 
            this.gBox_Cart.Controls.Add(this.btn_plus);
            this.gBox_Cart.Controls.Add(this.btn_substration);
            this.gBox_Cart.Controls.Add(this.btn_output);
            this.gBox_Cart.Controls.Add(this.btn_clearall);
            this.gBox_Cart.Controls.Add(this.btn_remove);
            this.gBox_Cart.Controls.Add(this.lbl_OrderTotalprice);
            this.gBox_Cart.Controls.Add(this.chk_bag);
            this.gBox_Cart.Controls.Add(this.chk_takeaway);
            this.gBox_Cart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gBox_Cart.Location = new System.Drawing.Point(274, 469);
            this.gBox_Cart.Name = "gBox_Cart";
            this.gBox_Cart.Size = new System.Drawing.Size(1016, 243);
            this.gBox_Cart.TabIndex = 25;
            this.gBox_Cart.TabStop = false;
            // 
            // btn_output
            // 
            this.btn_output.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_output.Location = new System.Drawing.Point(613, 134);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(235, 53);
            this.btn_output.TabIndex = 27;
            this.btn_output.Text = "送出訂購單";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // btn_clearall
            // 
            this.btn_clearall.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clearall.ForeColor = System.Drawing.Color.Red;
            this.btn_clearall.Location = new System.Drawing.Point(342, 134);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(235, 53);
            this.btn_clearall.TabIndex = 26;
            this.btn_clearall.Text = "清除所有品項";
            this.btn_clearall.UseVisualStyleBackColor = true;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_remove.Location = new System.Drawing.Point(43, 134);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(235, 53);
            this.btn_remove.TabIndex = 25;
            this.btn_remove.Text = "移除所選品項";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_OrderTotalprice
            // 
            this.lbl_OrderTotalprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_OrderTotalprice.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_OrderTotalprice.Location = new System.Drawing.Point(583, 43);
            this.lbl_OrderTotalprice.Name = "lbl_OrderTotalprice";
            this.lbl_OrderTotalprice.Size = new System.Drawing.Size(293, 69);
            this.lbl_OrderTotalprice.TabIndex = 24;
            this.lbl_OrderTotalprice.Text = "訂單總價 00000 元";
            this.lbl_OrderTotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_bag
            // 
            this.chk_bag.AutoSize = true;
            this.chk_bag.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_bag.Location = new System.Drawing.Point(174, 63);
            this.chk_bag.Name = "chk_bag";
            this.chk_bag.Size = new System.Drawing.Size(104, 33);
            this.chk_bag.TabIndex = 23;
            this.chk_bag.Text = "購物袋";
            this.chk_bag.UseVisualStyleBackColor = true;
            this.chk_bag.CheckedChanged += new System.EventHandler(this.chk_bag_CheckedChanged);
            // 
            // chk_takeaway
            // 
            this.chk_takeaway.AutoSize = true;
            this.chk_takeaway.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_takeaway.Location = new System.Drawing.Point(43, 63);
            this.chk_takeaway.Name = "chk_takeaway";
            this.chk_takeaway.Size = new System.Drawing.Size(81, 33);
            this.chk_takeaway.TabIndex = 22;
            this.chk_takeaway.Text = "外帶";
            this.chk_takeaway.UseVisualStyleBackColor = true;
            this.chk_takeaway.CheckedChanged += new System.EventHandler(this.chk_takeaway_CheckedChanged);
            // 
            // gBox_mainmenu
            // 
            this.gBox_mainmenu.Controls.Add(this.pictureBox1);
            this.gBox_mainmenu.Controls.Add(this.txt_phone);
            this.gBox_mainmenu.Controls.Add(this.label2);
            this.gBox_mainmenu.Controls.Add(this.label1);
            this.gBox_mainmenu.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gBox_mainmenu.Location = new System.Drawing.Point(285, 83);
            this.gBox_mainmenu.Name = "gBox_mainmenu";
            this.gBox_mainmenu.Size = new System.Drawing.Size(1005, 593);
            this.gBox_mainmenu.TabIndex = 26;
            this.gBox_mainmenu.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 238);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(332, 152);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(409, 43);
            this.txt_phone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入電話";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "歡迎使用丹丹漢堡點餐系統";
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_plus.Location = new System.Drawing.Point(342, 53);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(65, 43);
            this.btn_plus.TabIndex = 35;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_substration
            // 
            this.btn_substration.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_substration.Location = new System.Drawing.Point(460, 53);
            this.btn_substration.Name = "btn_substration";
            this.btn_substration.Size = new System.Drawing.Size(65, 43);
            this.btn_substration.TabIndex = 36;
            this.btn_substration.Text = "-";
            this.btn_substration.UseVisualStyleBackColor = true;
            this.btn_substration.Click += new System.EventHandler(this.btn_substration_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1367, 724);
            this.Controls.Add(this.gBox_Cart);
            this.Controls.Add(this.gBox_mainmenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView_ProductShowcase);
            this.Controls.Add(this.listView_Cart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gBox_Cart.ResumeLayout(false);
            this.gBox_Cart.PerformLayout();
            this.gBox_mainmenu.ResumeLayout(false);
            this.gBox_mainmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btn_drink;
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_breakfastset;
        private System.Windows.Forms.Button btn_noodleset;
        private System.Windows.Forms.Button btn_Mainset;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ListView listView_ProductShowcase;
        private System.Windows.Forms.ImageList imageListproduct;
        private System.Windows.Forms.ListView listView_Cart;
        private System.Windows.Forms.GroupBox gBox_Cart;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_OrderTotalprice;
        private System.Windows.Forms.CheckBox chk_bag;
        private System.Windows.Forms.CheckBox chk_takeaway;
        private System.Windows.Forms.GroupBox gBox_mainmenu;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_substration;
    }
}

