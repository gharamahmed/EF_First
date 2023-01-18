namespace EFDay1
{
    partial class login
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
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.Login_Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.INS_Password = new System.Windows.Forms.TextBox();
            this.INS_Email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Password
            // 
            this.Login_Password.Location = new System.Drawing.Point(148, 310);
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.PasswordChar = '*';
            this.Login_Password.Size = new System.Drawing.Size(173, 23);
            this.Login_Password.TabIndex = 10;
            // 
            // Login_Email
            // 
            this.Login_Email.Location = new System.Drawing.Point(148, 232);
            this.Login_Email.Name = "Login_Email";
            this.Login_Email.Size = new System.Drawing.Size(173, 23);
            this.Login_Email.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(47, 313);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 15);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(47, 235);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EFDay1.Properties.Resources.Group_1259;
            this.pictureBox1.Location = new System.Drawing.Point(81, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 172);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(100, 364);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(123, 23);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // INS_Password
            // 
            this.INS_Password.Location = new System.Drawing.Point(145, 296);
            this.INS_Password.Name = "INS_Password";
            this.INS_Password.PasswordChar = '*';
            this.INS_Password.Size = new System.Drawing.Size(173, 23);
            this.INS_Password.TabIndex = 10;
            // 
            // INS_Email
            // 
            this.INS_Email.Location = new System.Drawing.Point(145, 218);
            this.INS_Email.Name = "INS_Email";
            this.INS_Email.Size = new System.Drawing.Size(173, 23);
            this.INS_Email.TabIndex = 9;
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.Location = new System.Drawing.Point(44, 299);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(57, 15);
            this.txt_password.TabIndex = 8;
            this.txt_password.Text = "Password";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Location = new System.Drawing.Point(44, 221);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(36, 15);
            this.txt_email.TabIndex = 7;
            this.txt_email.Text = "Email";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EFDay1.Properties.Resources.Group_1259;
            this.pictureBox2.Location = new System.Drawing.Point(78, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 172);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // login
            // 
            this.ClientSize = new System.Drawing.Size(354, 397);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.INS_Password);
            this.Controls.Add(this.INS_Email);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.pictureBox2);
            this.Name = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Login;
        private TextBox Login_Password;
        private TextBox Login_Email;
        private Label Password;
        private Label Email;
        private PictureBox pictureBox1;
        private Button btn_Login;
        private TextBox INS_Password;
        private TextBox INS_Email;
        private Label txt_password;
        private Label txt_email;
        private PictureBox pictureBox2;
    }
}