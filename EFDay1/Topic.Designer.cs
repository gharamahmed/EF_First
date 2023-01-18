namespace EFDay1
{
    partial class Topic
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
            this.Topics = new System.Windows.Forms.DataGridView();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Topic = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_courses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Topics)).BeginInit();
            this.SuspendLayout();
            // 
            // Topics
            // 
            this.Topics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Topics.Location = new System.Drawing.Point(12, 135);
            this.Topics.Name = "Topics";
            this.Topics.RowTemplate.Height = 25;
            this.Topics.Size = new System.Drawing.Size(294, 162);
            this.Topics.TabIndex = 0;
            this.Topics.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(29, 84);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "ADD";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Topic Name";
            // 
            // Txt_Topic
            // 
            this.Txt_Topic.Location = new System.Drawing.Point(116, 28);
            this.Txt_Topic.Name = "Txt_Topic";
            this.Txt_Topic.Size = new System.Drawing.Size(150, 23);
            this.Txt_Topic.TabIndex = 3;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(110, 84);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(191, 84);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_courses
            // 
            this.Btn_courses.Location = new System.Drawing.Point(249, 312);
            this.Btn_courses.Name = "Btn_courses";
            this.Btn_courses.Size = new System.Drawing.Size(75, 23);
            this.Btn_courses.TabIndex = 6;
            this.Btn_courses.Text = "Courses";
            this.Btn_courses.UseVisualStyleBackColor = true;
            this.Btn_courses.Click += new System.EventHandler(this.Btn_courses_Click);
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 347);
            this.Controls.Add(this.Btn_courses);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Txt_Topic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Topics);
            this.Name = "Topic";
            this.Text = "Topic";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Topics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Topics;
        private Button Btn_Add;
        private Label label1;
        private TextBox Txt_Topic;
        private Button Btn_Update;
        private Button Btn_Delete;
        private Button Btn_courses;
    }
}