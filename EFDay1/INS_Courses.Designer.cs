namespace EFDay1
{
    partial class INS_Courses
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
            this.DGV_Courses = new System.Windows.Forms.DataGridView();
            this.Crs = new System.Windows.Forms.Label();
            this.CBCrs_Name = new System.Windows.Forms.ComboBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Courses)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Courses
            // 
            this.DGV_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Courses.Location = new System.Drawing.Point(12, 146);
            this.DGV_Courses.Name = "DGV_Courses";
            this.DGV_Courses.RowTemplate.Height = 25;
            this.DGV_Courses.Size = new System.Drawing.Size(507, 204);
            this.DGV_Courses.TabIndex = 0;
            this.DGV_Courses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Courses_RowHeaderMouseDoubleClick);
            // 
            // Crs
            // 
            this.Crs.AutoSize = true;
            this.Crs.Location = new System.Drawing.Point(97, 76);
            this.Crs.Name = "Crs";
            this.Crs.Size = new System.Drawing.Size(79, 15);
            this.Crs.TabIndex = 1;
            this.Crs.Text = "Cousre Name";
            // 
            // CBCrs_Name
            // 
            this.CBCrs_Name.FormattingEnabled = true;
            this.CBCrs_Name.Location = new System.Drawing.Point(192, 68);
            this.CBCrs_Name.Name = "CBCrs_Name";
            this.CBCrs_Name.Size = new System.Drawing.Size(121, 23);
            this.CBCrs_Name.TabIndex = 2;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(340, 68);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 3;
            this.Btn_Add.Text = "ADD";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(170, 106);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(263, 106);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // INS_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 381);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.CBCrs_Name);
            this.Controls.Add(this.Crs);
            this.Controls.Add(this.DGV_Courses);
            this.Name = "INS_Courses";
            this.Text = "INS_Courses";
            this.Load += new System.EventHandler(this.INS_Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGV_Courses;
        private Label Crs;
        private ComboBox CBCrs_Name;
        private Button Btn_Add;
        private Button Btn_Update;
        private Button Btn_Delete;
    }
}