namespace EFDay1
{
    partial class Register
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
            this.CB_Depts = new System.Windows.Forms.ComboBox();
            this.INs_Password = new System.Windows.Forms.TextBox();
            this.INs_Email = new System.Windows.Forms.TextBox();
            this.INs_Degree = new System.Windows.Forms.TextBox();
            this.INS_Fname = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.Department_Name = new System.Windows.Forms.Label();
            this.Degree = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Ins_Salary = new System.Windows.Forms.TextBox();
            this.Btn_Topic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Depts
            // 
            this.CB_Depts.FormattingEnabled = true;
            this.CB_Depts.Location = new System.Drawing.Point(188, 159);
            this.CB_Depts.Name = "CB_Depts";
            this.CB_Depts.Size = new System.Drawing.Size(149, 23);
            this.CB_Depts.TabIndex = 50;
            // 
            // INs_Password
            // 
            this.INs_Password.Location = new System.Drawing.Point(188, 236);
            this.INs_Password.Name = "INs_Password";
            this.INs_Password.PasswordChar = '*';
            this.INs_Password.Size = new System.Drawing.Size(149, 23);
            this.INs_Password.TabIndex = 49;
            // 
            // INs_Email
            // 
            this.INs_Email.Location = new System.Drawing.Point(188, 201);
            this.INs_Email.Name = "INs_Email";
            this.INs_Email.Size = new System.Drawing.Size(149, 23);
            this.INs_Email.TabIndex = 48;
            // 
            // INs_Degree
            // 
            this.INs_Degree.Location = new System.Drawing.Point(188, 94);
            this.INs_Degree.Name = "INs_Degree";
            this.INs_Degree.Size = new System.Drawing.Size(149, 23);
            this.INs_Degree.TabIndex = 47;
            // 
            // INS_Fname
            // 
            this.INS_Fname.Location = new System.Drawing.Point(188, 54);
            this.INS_Fname.Name = "INS_Fname";
            this.INS_Fname.Size = new System.Drawing.Size(149, 23);
            this.INS_Fname.TabIndex = 44;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(41, 236);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 15);
            this.Password.TabIndex = 43;
            this.Password.Text = "Password";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(41, 201);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 42;
            this.Email.Text = "Email";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(41, 131);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(38, 15);
            this.Salary.TabIndex = 41;
            this.Salary.Text = "Salary";
            // 
            // Department_Name
            // 
            this.Department_Name.AutoSize = true;
            this.Department_Name.Location = new System.Drawing.Point(41, 167);
            this.Department_Name.Name = "Department_Name";
            this.Department_Name.Size = new System.Drawing.Size(107, 15);
            this.Department_Name.TabIndex = 40;
            this.Department_Name.Text = "Department_Name";
            // 
            // Degree
            // 
            this.Degree.AutoSize = true;
            this.Degree.Location = new System.Drawing.Point(41, 94);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(44, 15);
            this.Degree.TabIndex = 39;
            this.Degree.Text = "Degree";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(41, 54);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(39, 15);
            this.Fname.TabIndex = 36;
            this.Fname.Text = "Name";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(65, 280);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(108, 23);
            this.Btn_Login.TabIndex = 35;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Ins_Salary
            // 
            this.Ins_Salary.Location = new System.Drawing.Point(188, 123);
            this.Ins_Salary.Name = "Ins_Salary";
            this.Ins_Salary.Size = new System.Drawing.Size(149, 23);
            this.Ins_Salary.TabIndex = 51;
            // 
            // Btn_Topic
            // 
            this.Btn_Topic.Location = new System.Drawing.Point(188, 280);
            this.Btn_Topic.Name = "Btn_Topic";
            this.Btn_Topic.Size = new System.Drawing.Size(75, 23);
            this.Btn_Topic.TabIndex = 52;
            this.Btn_Topic.Text = "ADD";
            this.Btn_Topic.UseVisualStyleBackColor = true;
            this.Btn_Topic.Click += new System.EventHandler(this.Btn_Topic_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 330);
            this.Controls.Add(this.Btn_Topic);
            this.Controls.Add(this.Ins_Salary);
            this.Controls.Add(this.CB_Depts);
            this.Controls.Add(this.INs_Password);
            this.Controls.Add(this.INs_Email);
            this.Controls.Add(this.INs_Degree);
            this.Controls.Add(this.INS_Fname);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Department_Name);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Btn_Login);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CB_Depts;
        private TextBox INs_Password;
        private TextBox INs_Email;
        private TextBox INs_Degree;
        private TextBox INS_Fname;
        private Label Password;
        private Label Email;
        private Label Salary;
        private Label Department_Name;
        private Label Degree;
        private Label Fname;
        private Button Btn_Login;
        private TextBox Ins_Salary;
        private Button Btn_Topic;
    }
}