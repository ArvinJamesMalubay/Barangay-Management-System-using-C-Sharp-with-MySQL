
namespace Barangay_Management_System
{
    partial class Barangay_Attendance_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_attendance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_timeOut = new System.Windows.Forms.Button();
            this.btn_timeIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 687);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.lbl_time);
            this.panel4.Location = new System.Drawing.Point(885, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 82);
            this.panel4.TabIndex = 4;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_time.Location = new System.Drawing.Point(14, 5);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(340, 66);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "00:00:00";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_attendance);
            this.panel3.Location = new System.Drawing.Point(61, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 433);
            this.panel3.TabIndex = 2;
            // 
            // dgv_attendance
            // 
            this.dgv_attendance.AllowUserToAddRows = false;
            this.dgv_attendance.AllowUserToDeleteRows = false;
            this.dgv_attendance.AllowUserToResizeColumns = false;
            this.dgv_attendance.AllowUserToResizeRows = false;
            this.dgv_attendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_attendance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_attendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_attendance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_attendance.Location = new System.Drawing.Point(3, 3);
            this.dgv_attendance.Name = "dgv_attendance";
            this.dgv_attendance.Size = new System.Drawing.Size(815, 427);
            this.dgv_attendance.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fullName";
            this.Column1.HeaderText = "Full Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "morning_TimeIn";
            this.Column2.HeaderText = "A.M Time In";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "morning_TimeOut";
            this.Column3.HeaderText = "A.M Time Out";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "afternoon_TimeIn";
            this.Column4.HeaderText = "P.M Time In";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "afternoon_TimeOut";
            this.Column5.HeaderText = "P.M Time Out";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "date";
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_timeOut);
            this.panel2.Controls.Add(this.btn_timeIn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbx_password);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbx_userName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(885, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 427);
            this.panel2.TabIndex = 1;
            // 
            // btn_timeOut
            // 
            this.btn_timeOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_timeOut.FlatAppearance.BorderSize = 3;
            this.btn_timeOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.SpringGreen;
            this.btn_timeOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_timeOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_timeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timeOut.Location = new System.Drawing.Point(186, 291);
            this.btn_timeOut.Margin = new System.Windows.Forms.Padding(0);
            this.btn_timeOut.Name = "btn_timeOut";
            this.btn_timeOut.Size = new System.Drawing.Size(127, 71);
            this.btn_timeOut.TabIndex = 6;
            this.btn_timeOut.Text = "OUT";
            this.btn_timeOut.UseVisualStyleBackColor = true;
            this.btn_timeOut.Click += new System.EventHandler(this.btn_timeOut_Click);
            // 
            // btn_timeIn
            // 
            this.btn_timeIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_timeIn.FlatAppearance.BorderSize = 3;
            this.btn_timeIn.FlatAppearance.CheckedBackColor = System.Drawing.Color.SpringGreen;
            this.btn_timeIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_timeIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_timeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timeIn.Location = new System.Drawing.Point(60, 291);
            this.btn_timeIn.Margin = new System.Windows.Forms.Padding(0);
            this.btn_timeIn.Name = "btn_timeIn";
            this.btn_timeIn.Size = new System.Drawing.Size(132, 71);
            this.btn_timeIn.TabIndex = 5;
            this.btn_timeIn.Text = "IN";
            this.btn_timeIn.UseVisualStyleBackColor = true;
            this.btn_timeIn.Click += new System.EventHandler(this.btn_timeIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(122, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Login";
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(60, 228);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(253, 35);
            this.tbx_password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(113, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // tbx_userName
            // 
            this.tbx_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_userName.Location = new System.Drawing.Point(60, 135);
            this.tbx_userName.Name = "tbx_userName";
            this.tbx_userName.Size = new System.Drawing.Size(253, 35);
            this.tbx_userName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(92, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barangay Attendance";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Barangay_Attendance_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Barangay_Attendance_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangay_Attendance_form";
            this.Load += new System.EventHandler(this.Barangay_Attendance_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_timeOut;
        private System.Windows.Forms.Button btn_timeIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_attendance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}