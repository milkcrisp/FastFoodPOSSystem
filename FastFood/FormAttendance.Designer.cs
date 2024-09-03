namespace FastFood
{
    partial class FormAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttendance));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_attendtime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_attendtype = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.btn_getoffwork = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_atwork = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_now = new System.Windows.Forms.Label();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            this.guna2Panel2.Size = new System.Drawing.Size(1056, 147);
            this.guna2Panel2.TabIndex = 53;
            this.guna2Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.guna2Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.guna2Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(465, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "打卡系統";
            // 
            // dtp_attendtime
            // 
            this.dtp_attendtime.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_attendtime.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_attendtime.Location = new System.Drawing.Point(375, 228);
            this.dtp_attendtime.Name = "dtp_attendtime";
            this.dtp_attendtime.Size = new System.Drawing.Size(261, 43);
            this.dtp_attendtime.TabIndex = 54;
            this.dtp_attendtime.Value = new System.DateTime(2024, 8, 19, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(369, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 55;
            this.label1.Text = "打卡日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(699, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 56;
            this.label2.Text = "打卡類型";
            // 
            // cBox_attendtype
            // 
            this.cBox_attendtype.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_attendtype.FormattingEnabled = true;
            this.cBox_attendtype.Location = new System.Drawing.Point(705, 228);
            this.cBox_attendtype.Name = "cBox_attendtype";
            this.cBox_attendtype.Size = new System.Drawing.Size(253, 43);
            this.cBox_attendtype.TabIndex = 57;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.Location = new System.Drawing.Point(52, 178);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(211, 35);
            this.label.TabIndex = 58;
            this.label.Text = "員工姓名和編號";
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_employee.Location = new System.Drawing.Point(52, 239);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(99, 35);
            this.lbl_employee.TabIndex = 60;
            this.lbl_employee.Text = "XXX O";
            // 
            // btn_getoffwork
            // 
            this.btn_getoffwork.AutoRoundedCorners = true;
            this.btn_getoffwork.BorderRadius = 39;
            this.btn_getoffwork.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_getoffwork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_getoffwork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_getoffwork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_getoffwork.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getoffwork.ForeColor = System.Drawing.Color.White;
            this.btn_getoffwork.Location = new System.Drawing.Point(720, 629);
            this.btn_getoffwork.Name = "btn_getoffwork";
            this.btn_getoffwork.Size = new System.Drawing.Size(238, 80);
            this.btn_getoffwork.TabIndex = 62;
            this.btn_getoffwork.Text = "下班打卡";
            this.btn_getoffwork.Click += new System.EventHandler(this.btn_getoffwork_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(52, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 35);
            this.label3.TabIndex = 63;
            this.label3.Text = "現在時間";
            // 
            // txt_Note
            // 
            this.txt_Note.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Note.Location = new System.Drawing.Point(47, 617);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Note.Size = new System.Drawing.Size(266, 105);
            this.txt_Note.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(41, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 35);
            this.label5.TabIndex = 65;
            this.label5.Text = "備註";
            // 
            // btn_atwork
            // 
            this.btn_atwork.AutoRoundedCorners = true;
            this.btn_atwork.BorderRadius = 39;
            this.btn_atwork.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_atwork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_atwork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_atwork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_atwork.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atwork.ForeColor = System.Drawing.Color.White;
            this.btn_atwork.Location = new System.Drawing.Point(398, 629);
            this.btn_atwork.Name = "btn_atwork";
            this.btn_atwork.Size = new System.Drawing.Size(238, 80);
            this.btn_atwork.TabIndex = 66;
            this.btn_atwork.Text = "上班打卡";
            this.btn_atwork.Click += new System.EventHandler(this.btn_atwork_Click);
            // 
            // lbl_now
            // 
            this.lbl_now.AutoSize = true;
            this.lbl_now.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_now.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_now.Location = new System.Drawing.Point(52, 421);
            this.lbl_now.Name = "lbl_now";
            this.lbl_now.Size = new System.Drawing.Size(155, 43);
            this.lbl_now.TabIndex = 67;
            this.lbl_now.Text = "現在時間";
            // 
            // timerNow
            // 
            this.timerNow.Interval = 1000;
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(369, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 35);
            this.label4.TabIndex = 68;
            this.label4.Text = "開始上班時間";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(699, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 35);
            this.label6.TabIndex = 69;
            this.label6.Text = "結束上班時間";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelStartTime.Location = new System.Drawing.Point(369, 434);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(99, 35);
            this.labelStartTime.TabIndex = 70;
            this.labelStartTime.Text = "未打卡";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEndTime.Location = new System.Drawing.Point(699, 434);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(99, 35);
            this.labelEndTime.TabIndex = 71;
            this.labelEndTime.Text = "未打卡";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btn_close.Image = global::FastFood.Properties.Resources.remove_;
            this.btn_close.Location = new System.Drawing.Point(968, 24);
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
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1056, 822);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_now);
            this.Controls.Add(this.btn_atwork);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_getoffwork);
            this.Controls.Add(this.lbl_employee);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cBox_attendtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_attendtime);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttendance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAttendance_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button btn_close;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_attendtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBox_attendtype;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_employee;
        private Guna.UI2.WinForms.Guna2Button btn_getoffwork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_atwork;
        private System.Windows.Forms.Label lbl_now;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
    }
}