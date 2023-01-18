using EFDay1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFDay1
{
    public partial class Topic : Form
    {
        ITIContext Db;
        int ins_id;
        public Topic(int ins_id)
        {
            InitializeComponent();
            Db = new ITIContext();
            this.ins_id = ins_id;
        }
        int id;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             id = (int)Topics.SelectedRows[0].Cells[0].Value;
            Txt_Topic.Text = Topics.SelectedRows[0].Cells[1].Value.ToString();
            Btn_Update.Visible = true;
            Btn_Delete.Visible = true;
            Btn_Add.Visible = false;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

           // Topics.DataSource = Db.Courses.Include(n => n.Top).Select(n => new { TopicName = n.Top.Top_Name, n.Crs_Name }).ToList();
           Topics.DataSource = Db.Topics.ToList();
            Btn_Update.Visible= false;
            Btn_Delete.Visible= false;
          
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Models.Topic T = new Models.Topic()
            {
                Top_Name= Txt_Topic.Text

            };
            Db.Topics.Add(T);
            Db.SaveChanges();
            Txt_Topic.Text = "";
            Topics.DataSource = Db.Topics.ToList();

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Models.Topic T = Db.Topics.Where(n => n.Top_Id == id).SingleOrDefault();
            T.Top_Name = Txt_Topic.Text;
            Db.SaveChanges();
            Txt_Topic.Text = "";
            Topics.DataSource = Db.Topics.ToList();
            Btn_Update.Visible = false;
            Btn_Delete.Visible = false;
            Btn_Add.Visible = true;


        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Models.Topic T = Db.Topics.Where(n => n.Top_Id == id).SingleOrDefault();
            Db.Topics.Remove(T);
            Db.SaveChanges();
            Txt_Topic.Text = "";
            Topics.DataSource = Db.Topics.ToList();
            Btn_Update.Visible = false;
            Btn_Delete.Visible = false;
            Btn_Add.Visible = true;

        }

        private void Btn_courses_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form f = new INS_Courses(ins_id);
            f.ShowDialog();
        }
    }
}
