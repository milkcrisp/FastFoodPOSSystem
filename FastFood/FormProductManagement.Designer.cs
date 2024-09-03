namespace FastFood
{
    partial class FormProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btn_newproduct = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_img = new System.Windows.Forms.Button();
            this.listView_ProductShowcase = new System.Windows.Forms.ListView();
            this.imageListproduct = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.lbl_User);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 142);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(30, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 123);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_close.Image = global::FastFood.Properties.Resources.remove_;
            this.btn_close.Location = new System.Drawing.Point(1295, 30);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(59, 52);
            this.btn_close.TabIndex = 10;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_User.Location = new System.Drawing.Point(1071, 47);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(91, 41);
            this.lbl_User.TabIndex = 3;
            this.lbl_User.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(553, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品管理";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.panelSide);
            this.panel2.Controls.Add(this.btn_newproduct);
            this.panel2.Controls.Add(this.btn_list);
            this.panel2.Controls.Add(this.btn_img);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 626);
            this.panel2.TabIndex = 2;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panelSide.Location = new System.Drawing.Point(-2, 83);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(24, 77);
            this.panelSide.TabIndex = 2;
            // 
            // btn_newproduct
            // 
            this.btn_newproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btn_newproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_newproduct.FlatAppearance.BorderSize = 0;
            this.btn_newproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newproduct.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_newproduct.Image = global::FastFood.Properties.Resources.noodles;
            this.btn_newproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newproduct.Location = new System.Drawing.Point(24, 243);
            this.btn_newproduct.Name = "btn_newproduct";
            this.btn_newproduct.Size = new System.Drawing.Size(214, 77);
            this.btn_newproduct.TabIndex = 4;
            this.btn_newproduct.Text = "  新增商品";
            this.btn_newproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_newproduct.UseVisualStyleBackColor = false;
            this.btn_newproduct.Click += new System.EventHandler(this.btn_newproduct_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btn_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_list.FlatAppearance.BorderSize = 0;
            this.btn_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_list.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_list.Image = global::FastFood.Properties.Resources.hamburger;
            this.btn_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_list.Location = new System.Drawing.Point(24, 163);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(214, 77);
            this.btn_list.TabIndex = 3;
            this.btn_list.Text = "  列表模式";
            this.btn_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_img
            // 
            this.btn_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btn_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_img.FlatAppearance.BorderSize = 0;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_img.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_img.Image = global::FastFood.Properties.Resources.menu;
            this.btn_img.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_img.Location = new System.Drawing.Point(24, 83);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(214, 77);
            this.btn_img.TabIndex = 2;
            this.btn_img.Text = "  圖片模式";
            this.btn_img.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_img.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_img.UseVisualStyleBackColor = false;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // listView_ProductShowcase
            // 
            this.listView_ProductShowcase.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_ProductShowcase.HideSelection = false;
            this.listView_ProductShowcase.Location = new System.Drawing.Point(283, 175);
            this.listView_ProductShowcase.Name = "listView_ProductShowcase";
            this.listView_ProductShowcase.Size = new System.Drawing.Size(1005, 593);
            this.listView_ProductShowcase.TabIndex = 11;
            this.listView_ProductShowcase.UseCompatibleStateImageBehavior = false;
            this.listView_ProductShowcase.ItemActivate += new System.EventHandler(this.listView_ProductShowcase_ItemActivate);
            // 
            // imageListproduct
            // 
            this.imageListproduct.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListproduct.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListproduct.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.listView_ProductShowcase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductManagement";
            this.Text = "FormProductManagement";
            this.Activated += new System.EventHandler(this.FormProductManagement_Activated);
            this.Load += new System.EventHandler(this.FormProductManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btn_newproduct;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.ListView listView_ProductShowcase;
        private System.Windows.Forms.ImageList imageListproduct;
    }
}