using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class FormAttendance : Form
    {
        public FormAttendance()
        {
            InitializeComponent();
        }



        private void FormAttendance_Load(object sender, EventArgs e)
        {
            // 設定當前日期
            dtp_attendtime.Value = DateTime.Now;
            dtp_attendtime.Enabled = false; // 不允許編輯
            lbl_employee.Text = $"{GlobalVar.username} {GlobalVar.userlimit}";
            // 設置 Timer
            timerNow.Interval = 1000; // 1秒更新一次
            timerNow.Tick += timerNow_Tick;
            timerNow.Start();
            // 填充出缺勤類型選項
            cBox_attendtype.Items.Add("Present");
            cBox_attendtype.Items.Add("Leave");
            cBox_attendtype.Items.Add("Absent");
            cBox_attendtype.SelectedIndex = 0; // 默認選擇第一個
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_atwork_Click(object sender, EventArgs e)
        {
            // 記錄開始時間
            labelStartTime.Text = DateTime.Now.ToString("HH:mm:ss");

            // 插入打卡信息到資料庫
            InsertAttendance();
        }

        private void btn_getoffwork_Click(object sender, EventArgs e)
        {
            // 記錄結束時間
            labelEndTime.Text = DateTime.Now.ToString("HH:mm:ss");
            // 更新打卡信息到資料庫
            UpdateAttendance();
        }
        private void InsertAttendance()
        {
            string attendanceType = cBox_attendtype.SelectedItem.ToString();
            DateTime attendanceDate = dtp_attendtime.Value.Date;
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            string note = txt_Note.Text;

            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string insertSQL = @"
                    INSERT INTO Attendance (eid, AttendDate, AttendType, StartTime, Note)
                    VALUES (@eid, @AttendDate, @AttendType, @StartTime, @Note);";

                    SqlCommand cmd = new SqlCommand(insertSQL, con, transaction);
                    cmd.Parameters.AddWithValue("@eid", GlobalVar.empid); // 假設從全域變數中取得員工ID
                    cmd.Parameters.AddWithValue("@AttendDate", attendanceDate);
                    cmd.Parameters.AddWithValue("@AttendType", attendanceType);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@Note", string.IsNullOrEmpty(note) ? DBNull.Value : (object)note);

                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                    MessageBox.Show("上班打卡信息已成功提交！");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("提交上班打卡信息時發生錯誤: " + ex.Message);
                }
            }
        }

        private void UpdateAttendance()
        {
            DateTime attendanceDate = dtp_attendtime.Value.Date;
            TimeSpan endTime = DateTime.Now.TimeOfDay;

            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string updateSQL = @"
                    UPDATE Attendance
                    SET EndTime = @EndTime
                    WHERE eid = @eid AND AttendDate = @AttendDate;";

                    SqlCommand cmd = new SqlCommand(updateSQL, con, transaction);
                    cmd.Parameters.AddWithValue("@eid", GlobalVar.empid); // 假設從全域變數中取得員工ID
                    cmd.Parameters.AddWithValue("@AttendDate", attendanceDate);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);

                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                    MessageBox.Show("下班打卡信息已成功提交！");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("提交下班打卡信息時發生錯誤: " + ex.Message);
                }
            }
        }
        private void timerNow_Tick(object sender, EventArgs e)
        {
            // 更新 Label 的文本為當前時間
            lbl_now.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
