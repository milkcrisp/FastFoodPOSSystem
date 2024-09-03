namespace FastFood
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Order = new System.Windows.Forms.DataGridView();
            this.DGV_OrderDetail = new System.Windows.Forms.DataGridView();
            this.cmb_OrderStatus = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MinAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio_DineIn = new System.Windows.Forms.RadioButton();
            this.radio_Takeaway = new System.Windows.Forms.RadioButton();
            this.radio_All = new System.Windows.Forms.RadioButton();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_SearchBy = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_UpadteOrderStatus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OrderDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 78);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(752, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "訂單管理";
            // 
            // DGV_Order
            // 
            this.DGV_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Order.Location = new System.Drawing.Point(645, 98);
            this.DGV_Order.Name = "DGV_Order";
            this.DGV_Order.RowHeadersWidth = 51;
            this.DGV_Order.RowTemplate.Height = 27;
            this.DGV_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Order.Size = new System.Drawing.Size(821, 337);
            this.DGV_Order.TabIndex = 2;
            this.DGV_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Order_CellClick);
            this.DGV_Order.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Order_CellEndEdit);
            // 
            // DGV_OrderDetail
            // 
            this.DGV_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OrderDetail.Location = new System.Drawing.Point(645, 463);
            this.DGV_OrderDetail.Name = "DGV_OrderDetail";
            this.DGV_OrderDetail.RowHeadersWidth = 51;
            this.DGV_OrderDetail.RowTemplate.Height = 27;
            this.DGV_OrderDetail.Size = new System.Drawing.Size(821, 406);
            this.DGV_OrderDetail.TabIndex = 3;
            this.DGV_OrderDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_OrderDetail_CellEndEdit);
            // 
            // cmb_OrderStatus
            // 
            this.cmb_OrderStatus.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_OrderStatus.FormattingEnabled = true;
            this.cmb_OrderStatus.Location = new System.Drawing.Point(75, 114);
            this.cmb_OrderStatus.Name = "cmb_OrderStatus";
            this.cmb_OrderStatus.Size = new System.Drawing.Size(253, 42);
            this.cmb_OrderStatus.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_MaxAmount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_MinAmount);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btn_Search);
            this.groupBox3.Controls.Add(this.cmb_SearchBy);
            this.groupBox3.Controls.Add(this.txt_Search);
            this.groupBox3.Controls.Add(this.dtp_EndDate);
            this.groupBox3.Controls.Add(this.dtp_StartDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(78, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 560);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(481, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "元";
            // 
            // txt_MaxAmount
            // 
            this.txt_MaxAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_MaxAmount.Location = new System.Drawing.Point(328, 256);
            this.txt_MaxAmount.Name = "txt_MaxAmount";
            this.txt_MaxAmount.Size = new System.Drawing.Size(137, 34);
            this.txt_MaxAmount.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(250, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "元到";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "從";
            // 
            // txt_MinAmount
            // 
            this.txt_MinAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_MinAmount.Location = new System.Drawing.Point(81, 256);
            this.txt_MinAmount.Name = "txt_MinAmount";
            this.txt_MinAmount.Size = new System.Drawing.Size(137, 34);
            this.txt_MinAmount.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "金額區間";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.groupBox5.Controls.Add(this.radio_DineIn);
            this.groupBox5.Controls.Add(this.radio_Takeaway);
            this.groupBox5.Controls.Add(this.radio_All);
            this.groupBox5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(20, 315);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(473, 119);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "外帶內用選擇";
            // 
            // radio_DineIn
            // 
            this.radio_DineIn.AutoSize = true;
            this.radio_DineIn.Location = new System.Drawing.Point(353, 46);
            this.radio_DineIn.Name = "radio_DineIn";
            this.radio_DineIn.Size = new System.Drawing.Size(73, 29);
            this.radio_DineIn.TabIndex = 2;
            this.radio_DineIn.TabStop = true;
            this.radio_DineIn.Text = "內用";
            this.radio_DineIn.UseVisualStyleBackColor = true;
            // 
            // radio_Takeaway
            // 
            this.radio_Takeaway.AutoSize = true;
            this.radio_Takeaway.Location = new System.Drawing.Point(202, 46);
            this.radio_Takeaway.Name = "radio_Takeaway";
            this.radio_Takeaway.Size = new System.Drawing.Size(73, 29);
            this.radio_Takeaway.TabIndex = 1;
            this.radio_Takeaway.TabStop = true;
            this.radio_Takeaway.Text = "外帶";
            this.radio_Takeaway.UseVisualStyleBackColor = true;
            // 
            // radio_All
            // 
            this.radio_All.AutoSize = true;
            this.radio_All.Location = new System.Drawing.Point(51, 46);
            this.radio_All.Name = "radio_All";
            this.radio_All.Size = new System.Drawing.Size(73, 29);
            this.radio_All.TabIndex = 0;
            this.radio_All.TabStop = true;
            this.radio_All.Text = "全部";
            this.radio_All.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.AutoRoundedCorners = true;
            this.btn_Search.BorderRadius = 32;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(127, 466);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(270, 67);
            this.btn_Search.TabIndex = 41;
            this.btn_Search.Text = "搜尋";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_SearchBy
            // 
            this.cmb_SearchBy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_SearchBy.FormattingEnabled = true;
            this.cmb_SearchBy.Location = new System.Drawing.Point(342, 60);
            this.cmb_SearchBy.Name = "cmb_SearchBy";
            this.cmb_SearchBy.Size = new System.Drawing.Size(113, 33);
            this.cmb_SearchBy.TabIndex = 37;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Search.Location = new System.Drawing.Point(35, 60);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(229, 34);
            this.txt_Search.TabIndex = 36;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_EndDate.Location = new System.Drawing.Point(306, 158);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(211, 34);
            this.dtp_EndDate.TabIndex = 35;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_StartDate.Location = new System.Drawing.Point(39, 158);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(211, 34);
            this.dtp_StartDate.TabIndex = 34;
            this.dtp_StartDate.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(259, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 29);
            this.label14.TabIndex = 5;
            this.label14.Text = "到";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(6, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 29);
            this.label13.TabIndex = 4;
            this.label13.Text = "從";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(15, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "日期區間指定";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(15, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "訂單搜尋";
            // 
            // btn_UpadteOrderStatus
            // 
            this.btn_UpadteOrderStatus.AutoRoundedCorners = true;
            this.btn_UpadteOrderStatus.BorderRadius = 32;
            this.btn_UpadteOrderStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpadteOrderStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpadteOrderStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_UpadteOrderStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_UpadteOrderStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpadteOrderStatus.ForeColor = System.Drawing.Color.White;
            this.btn_UpadteOrderStatus.Location = new System.Drawing.Point(360, 98);
            this.btn_UpadteOrderStatus.Name = "btn_UpadteOrderStatus";
            this.btn_UpadteOrderStatus.Size = new System.Drawing.Size(235, 67);
            this.btn_UpadteOrderStatus.TabIndex = 50;
            this.btn_UpadteOrderStatus.Text = "訂單狀態修改";
            this.btn_UpadteOrderStatus.Click += new System.EventHandler(this.btn_UpdateOrderStatus_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_close.Image = global::FastFood.Properties.Resources.remove_;
            this.btn_close.Location = new System.Drawing.Point(1505, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(59, 52);
            this.btn_close.TabIndex = 10;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(24, 765);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 123);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.btn_UpadteOrderStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmb_OrderStatus);
            this.Controls.Add(this.DGV_OrderDetail);
            this.Controls.Add(this.DGV_Order);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OrderDetail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Order;
        private System.Windows.Forms.DataGridView DGV_OrderDetail;
        private System.Windows.Forms.ComboBox cmb_OrderStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_SearchBy;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio_DineIn;
        private System.Windows.Forms.RadioButton radio_Takeaway;
        private System.Windows.Forms.RadioButton radio_All;
        private System.Windows.Forms.TextBox txt_MaxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MinAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_UpadteOrderStatus;
    }
}