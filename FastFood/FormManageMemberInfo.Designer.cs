namespace FastFood
{
    partial class FormManageMemberInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageMemberInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Revise = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DGV_Member = new System.Windows.Forms.DataGridView();
            this.btn_showAllInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SearchBy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Cleartxt = new Guna.UI2.WinForms.Guna2Button();
            this.btn_usersignin = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_MemberStatus = new System.Windows.Forms.ComboBox();
            this.btn_mStatus = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.guna2Panel2.Controls.Add(this.btn_close);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1366, 149);
            this.guna2Panel2.TabIndex = 53;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_close.Image = global::FastFood.Properties.Resources.remove_;
            this.btn_close.Location = new System.Drawing.Point(1295, 14);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(59, 52);
            this.btn_close.TabIndex = 11;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 123);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(766, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "會員資料修改";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ID.Location = new System.Drawing.Point(446, 276);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(301, 38);
            this.txt_ID.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(324, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "ID";
            // 
            // btn_Revise
            // 
            this.btn_Revise.AutoRoundedCorners = true;
            this.btn_Revise.BorderRadius = 36;
            this.btn_Revise.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Revise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Revise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Revise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Revise.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Revise.ForeColor = System.Drawing.Color.White;
            this.btn_Revise.Location = new System.Drawing.Point(49, 228);
            this.btn_Revise.Name = "btn_Revise";
            this.btn_Revise.Size = new System.Drawing.Size(202, 74);
            this.btn_Revise.TabIndex = 89;
            this.btn_Revise.Text = "修改";
            this.btn_Revise.Click += new System.EventHandler(this.btn_Revise_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(446, 371);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(301, 38);
            this.txtPassword.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(324, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 87;
            this.label8.Text = "密碼";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(446, 512);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 38);
            this.txtEmail.TabIndex = 85;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(446, 465);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 38);
            this.txtAddress.TabIndex = 84;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(446, 418);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(301, 38);
            this.txtPhone.TabIndex = 83;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(446, 324);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 38);
            this.txtName.TabIndex = 82;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp.Location = new System.Drawing.Point(446, 559);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(301, 38);
            this.dtp.TabIndex = 81;
            this.dtp.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(324, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 29);
            this.label6.TabIndex = 80;
            this.label6.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(324, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 79;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(324, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 78;
            this.label4.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(324, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(324, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 76;
            this.label2.Text = "姓名";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Location = new System.Drawing.Point(1274, 133);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(24, 814);
            this.guna2Panel1.TabIndex = 86;
            // 
            // DGV_Member
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Member.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Member.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Member.Location = new System.Drawing.Point(789, 200);
            this.DGV_Member.Name = "DGV_Member";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Member.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Member.RowHeadersWidth = 51;
            this.DGV_Member.RowTemplate.Height = 27;
            this.DGV_Member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Member.Size = new System.Drawing.Size(548, 510);
            this.DGV_Member.TabIndex = 92;
            this.DGV_Member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Member_CellClick);
            // 
            // btn_showAllInfo
            // 
            this.btn_showAllInfo.AutoRoundedCorners = true;
            this.btn_showAllInfo.BorderRadius = 36;
            this.btn_showAllInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_showAllInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_showAllInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_showAllInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_showAllInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAllInfo.ForeColor = System.Drawing.Color.White;
            this.btn_showAllInfo.Location = new System.Drawing.Point(49, 446);
            this.btn_showAllInfo.Name = "btn_showAllInfo";
            this.btn_showAllInfo.Size = new System.Drawing.Size(202, 74);
            this.btn_showAllInfo.TabIndex = 93;
            this.btn_showAllInfo.Text = "顯示全部資料";
            this.btn_showAllInfo.Click += new System.EventHandler(this.btn_showAllInfo_Click);
            // 
            // btn_SearchBy
            // 
            this.btn_SearchBy.AutoRoundedCorners = true;
            this.btn_SearchBy.BorderRadius = 36;
            this.btn_SearchBy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchBy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SearchBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SearchBy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchBy.ForeColor = System.Drawing.Color.White;
            this.btn_SearchBy.Location = new System.Drawing.Point(49, 337);
            this.btn_SearchBy.Name = "btn_SearchBy";
            this.btn_SearchBy.Size = new System.Drawing.Size(202, 74);
            this.btn_SearchBy.TabIndex = 94;
            this.btn_SearchBy.Text = "查詢";
            this.btn_SearchBy.Click += new System.EventHandler(this.btn_SearchBy_Click);
            // 
            // btn_Cleartxt
            // 
            this.btn_Cleartxt.AutoRoundedCorners = true;
            this.btn_Cleartxt.BorderRadius = 33;
            this.btn_Cleartxt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cleartxt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cleartxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cleartxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cleartxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cleartxt.ForeColor = System.Drawing.Color.White;
            this.btn_Cleartxt.Location = new System.Drawing.Point(48, 658);
            this.btn_Cleartxt.Name = "btn_Cleartxt";
            this.btn_Cleartxt.Size = new System.Drawing.Size(203, 68);
            this.btn_Cleartxt.TabIndex = 96;
            this.btn_Cleartxt.Text = "清空欄位";
            this.btn_Cleartxt.Click += new System.EventHandler(this.btn_Cleartxt_Click);
            // 
            // btn_usersignin
            // 
            this.btn_usersignin.AutoRoundedCorners = true;
            this.btn_usersignin.BorderRadius = 33;
            this.btn_usersignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_usersignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_usersignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_usersignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_usersignin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usersignin.ForeColor = System.Drawing.Color.White;
            this.btn_usersignin.Location = new System.Drawing.Point(49, 559);
            this.btn_usersignin.Name = "btn_usersignin";
            this.btn_usersignin.Size = new System.Drawing.Size(202, 68);
            this.btn_usersignin.TabIndex = 95;
            this.btn_usersignin.Text = "新增會員";
            this.btn_usersignin.Click += new System.EventHandler(this.btn_usersignin_Click);
            // 
            // cmb_MemberStatus
            // 
            this.cmb_MemberStatus.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_MemberStatus.FormattingEnabled = true;
            this.cmb_MemberStatus.Location = new System.Drawing.Point(339, 688);
            this.cmb_MemberStatus.Name = "cmb_MemberStatus";
            this.cmb_MemberStatus.Size = new System.Drawing.Size(185, 42);
            this.cmb_MemberStatus.TabIndex = 14;
            // 
            // btn_mStatus
            // 
            this.btn_mStatus.AutoRoundedCorners = true;
            this.btn_mStatus.BorderRadius = 36;
            this.btn_mStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_mStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_mStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_mStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_mStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mStatus.ForeColor = System.Drawing.Color.White;
            this.btn_mStatus.Location = new System.Drawing.Point(565, 668);
            this.btn_mStatus.Name = "btn_mStatus";
            this.btn_mStatus.Size = new System.Drawing.Size(197, 74);
            this.btn_mStatus.TabIndex = 97;
            this.btn_mStatus.Text = "修改會員狀態";
            this.btn_mStatus.Click += new System.EventHandler(this.btn_mStatus_Click);
            // 
            // FormManageMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btn_mStatus);
            this.Controls.Add(this.btn_Cleartxt);
            this.Controls.Add(this.cmb_MemberStatus);
            this.Controls.Add(this.btn_usersignin);
            this.Controls.Add(this.btn_SearchBy);
            this.Controls.Add(this.btn_showAllInfo);
            this.Controls.Add(this.DGV_Member);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Revise);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageMemberInfo";
            this.Text = "FormManageMemberInfo";
            this.Load += new System.EventHandler(this.FormManageMemberInfo_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button btn_close;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Revise;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView DGV_Member;
        private Guna.UI2.WinForms.Guna2Button btn_showAllInfo;
        private Guna.UI2.WinForms.Guna2Button btn_SearchBy;
        private Guna.UI2.WinForms.Guna2Button btn_Cleartxt;
        private Guna.UI2.WinForms.Guna2Button btn_usersignin;
        private System.Windows.Forms.ComboBox cmb_MemberStatus;
        private Guna.UI2.WinForms.Guna2Button btn_mStatus;
    }
}