
namespace Barangay_Management_System
{
    partial class Login_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_createAccount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_forPictureLogo = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_createAccount);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbx_password);
            this.panel1.Controls.Add(this.tbx_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_forPictureLogo);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Location = new System.Drawing.Point(106, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 477);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(206, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "or";
            // 
            // lbl_createAccount
            // 
            this.lbl_createAccount.AutoSize = true;
            this.lbl_createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createAccount.ForeColor = System.Drawing.Color.Blue;
            this.lbl_createAccount.Location = new System.Drawing.Point(152, 446);
            this.lbl_createAccount.Name = "lbl_createAccount";
            this.lbl_createAccount.Size = new System.Drawing.Size(134, 16);
            this.lbl_createAccount.TabIndex = 9;
            this.lbl_createAccount.Text = "Create an Account";
            this.lbl_createAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_createAccount_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Barangay_Management_System.Properties.Resources.password_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(56, 333);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 35);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Barangay_Management_System.Properties.Resources.profile_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(56, 274);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(94, 333);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_password.Multiline = true;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(251, 35);
            this.tbx_password.TabIndex = 6;
            this.tbx_password.TextChanged += new System.EventHandler(this.tbx_password_TextChanged);
            // 
            // tbx_username
            // 
            this.tbx_username.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_username.Location = new System.Drawing.Point(94, 274);
            this.tbx_username.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_username.Multiline = true;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(251, 39);
            this.tbx_username.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // panel_forPictureLogo
            // 
            this.panel_forPictureLogo.BackgroundImage = global::Barangay_Management_System.Properties.Resources.login_background;
            this.panel_forPictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_forPictureLogo.Location = new System.Drawing.Point(0, 0);
            this.panel_forPictureLogo.Name = "panel_forPictureLogo";
            this.panel_forPictureLogo.Size = new System.Drawing.Size(414, 219);
            this.panel_forPictureLogo.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkGray;
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(94, 388);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(251, 39);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.Red;
            this.lbl_exit.Location = new System.Drawing.Point(606, -1);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(27, 25);
            this.lbl_exit.TabIndex = 1;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Barangay_Management_System.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 571);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_forPictureLogo;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_createAccount;
        private System.Windows.Forms.Label lbl_exit;
    }
}

