
namespace Barangay_Management_System
{
    partial class Edit_Residence_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_religion = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dtp_birthDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_maritalStatus = new System.Windows.Forms.ComboBox();
            this.rbt_Female = new System.Windows.Forms.RadioButton();
            this.rbt_Male = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_job = new System.Windows.Forms.TextBox();
            this.tbx_Age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_alias = new System.Windows.Forms.TextBox();
            this.tbx_middleName = new System.Windows.Forms.TextBox();
            this.tbx_firstName = new System.Windows.Forms.TextBox();
            this.tbx_lastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picturebox_image = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.cmb_religion);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.dtp_birthDate);
            this.groupBox1.Controls.Add(this.cmb_maritalStatus);
            this.groupBox1.Controls.Add(this.rbt_Female);
            this.groupBox1.Controls.Add(this.rbt_Male);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.picturebox_image);
            this.groupBox1.Controls.Add(this.tbx_job);
            this.groupBox1.Controls.Add(this.tbx_Age);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbx_alias);
            this.groupBox1.Controls.Add(this.tbx_middleName);
            this.groupBox1.Controls.Add(this.tbx_firstName);
            this.groupBox1.Controls.Add(this.tbx_lastName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 471);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Personal Information";
            // 
            // cmb_religion
            // 
            this.cmb_religion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_religion.FormattingEnabled = true;
            this.cmb_religion.Items.AddRange(new object[] {
            "Christianity",
            "Islam",
            "Hinduism",
            "Catholicism",
            "Jehova\'s Witnesses"});
            this.cmb_religion.Location = new System.Drawing.Point(741, 185);
            this.cmb_religion.Name = "cmb_religion";
            this.cmb_religion.Size = new System.Drawing.Size(198, 32);
            this.cmb_religion.TabIndex = 27;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(741, 320);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(197, 43);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dtp_birthDate
            // 
            this.dtp_birthDate.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_birthDate.Location = new System.Drawing.Point(741, 82);
            this.dtp_birthDate.Name = "dtp_birthDate";
            this.dtp_birthDate.Size = new System.Drawing.Size(197, 34);
            this.dtp_birthDate.TabIndex = 25;
            this.dtp_birthDate.Value = new System.DateTime(2023, 12, 8, 1, 18, 20, 0);
            // 
            // cmb_maritalStatus
            // 
            this.cmb_maritalStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_maritalStatus.FormattingEnabled = true;
            this.cmb_maritalStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widow",
            "Divorced"});
            this.cmb_maritalStatus.Location = new System.Drawing.Point(370, 329);
            this.cmb_maritalStatus.Name = "cmb_maritalStatus";
            this.cmb_maritalStatus.Size = new System.Drawing.Size(198, 34);
            this.cmb_maritalStatus.TabIndex = 24;
            // 
            // rbt_Female
            // 
            this.rbt_Female.AutoSize = true;
            this.rbt_Female.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Female.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbt_Female.Location = new System.Drawing.Point(460, 276);
            this.rbt_Female.Name = "rbt_Female";
            this.rbt_Female.Size = new System.Drawing.Size(108, 34);
            this.rbt_Female.TabIndex = 23;
            this.rbt_Female.TabStop = true;
            this.rbt_Female.Text = "Female";
            this.rbt_Female.UseVisualStyleBackColor = true;
            // 
            // rbt_Male
            // 
            this.rbt_Male.AutoSize = true;
            this.rbt_Male.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Male.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbt_Male.Location = new System.Drawing.Point(370, 276);
            this.rbt_Male.Name = "rbt_Male";
            this.rbt_Male.Size = new System.Drawing.Size(84, 34);
            this.rbt_Male.TabIndex = 22;
            this.rbt_Male.TabStop = true;
            this.rbt_Male.Text = "Male";
            this.rbt_Male.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(18, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Click Image to Attach";
            // 
            // tbx_job
            // 
            this.tbx_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_job.Location = new System.Drawing.Point(741, 242);
            this.tbx_job.Multiline = true;
            this.tbx_job.Name = "tbx_job";
            this.tbx_job.Size = new System.Drawing.Size(197, 31);
            this.tbx_job.TabIndex = 19;
            this.tbx_job.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_lastName_KeyPress);
            // 
            // tbx_Age
            // 
            this.tbx_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Age.Location = new System.Drawing.Point(741, 136);
            this.tbx_Age.Multiline = true;
            this.tbx_Age.Name = "tbx_Age";
            this.tbx_Age.Size = new System.Drawing.Size(197, 31);
            this.tbx_Age.TabIndex = 17;
            this.tbx_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_Age_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(595, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 30);
            this.label10.TabIndex = 16;
            this.label10.Text = "Job:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(595, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 30);
            this.label9.TabIndex = 15;
            this.label9.Text = "Religion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(595, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Age:";
            // 
            // tbx_alias
            // 
            this.tbx_alias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_alias.Location = new System.Drawing.Point(370, 234);
            this.tbx_alias.Multiline = true;
            this.tbx_alias.Name = "tbx_alias";
            this.tbx_alias.Size = new System.Drawing.Size(197, 31);
            this.tbx_alias.TabIndex = 10;
            this.tbx_alias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_lastName_KeyPress);
            // 
            // tbx_middleName
            // 
            this.tbx_middleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_middleName.Location = new System.Drawing.Point(370, 188);
            this.tbx_middleName.Multiline = true;
            this.tbx_middleName.Name = "tbx_middleName";
            this.tbx_middleName.Size = new System.Drawing.Size(197, 31);
            this.tbx_middleName.TabIndex = 9;
            this.tbx_middleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_lastName_KeyPress);
            // 
            // tbx_firstName
            // 
            this.tbx_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_firstName.Location = new System.Drawing.Point(370, 136);
            this.tbx_firstName.Multiline = true;
            this.tbx_firstName.Name = "tbx_firstName";
            this.tbx_firstName.Size = new System.Drawing.Size(197, 31);
            this.tbx_firstName.TabIndex = 8;
            this.tbx_firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_lastName_KeyPress);
            // 
            // tbx_lastName
            // 
            this.tbx_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_lastName.Location = new System.Drawing.Point(370, 86);
            this.tbx_lastName.Multiline = true;
            this.tbx_lastName.Name = "tbx_lastName";
            this.tbx_lastName.Size = new System.Drawing.Size(197, 31);
            this.tbx_lastName.TabIndex = 7;
            this.tbx_lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_lastName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(595, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Birth Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(189, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Marital Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(189, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(189, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(189, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(189, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(189, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // picturebox_image
            // 
            this.picturebox_image.BackColor = System.Drawing.Color.FloralWhite;
            this.picturebox_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox_image.Location = new System.Drawing.Point(19, 86);
            this.picturebox_image.Name = "picturebox_image";
            this.picturebox_image.Size = new System.Drawing.Size(150, 145);
            this.picturebox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_image.TabIndex = 20;
            this.picturebox_image.TabStop = false;
            this.picturebox_image.Click += new System.EventHandler(this.picturebox_image_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(364, 40);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 34);
            this.lbl_id.TabIndex = 28;
            // 
            // Edit_Residence_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 489);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_Residence_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmb_religion;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.DateTimePicker dtp_birthDate;
        public System.Windows.Forms.ComboBox cmb_maritalStatus;
        public System.Windows.Forms.RadioButton rbt_Female;
        public System.Windows.Forms.RadioButton rbt_Male;
        public System.Windows.Forms.PictureBox picturebox_image;
        public System.Windows.Forms.TextBox tbx_job;
        public System.Windows.Forms.TextBox tbx_Age;
        public System.Windows.Forms.TextBox tbx_alias;
        public System.Windows.Forms.TextBox tbx_middleName;
        public System.Windows.Forms.TextBox tbx_firstName;
        public System.Windows.Forms.TextBox tbx_lastName;
        public System.Windows.Forms.Label lbl_id;
    }
}