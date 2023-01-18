using EFDay1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDay1
{
    public partial class Register : Form
    {
        ITIContext Db;
        public Register()
        {
            InitializeComponent();
            Db=new ITIContext();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            CB_Depts.DataSource = Db.Departments.ToList();
            CB_Depts.DisplayMember = "Dept_Name";
            CB_Depts.ValueMember = "Dept_Id";


        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form t = new login();
            t.ShowDialog();

        }

        private void Btn_Topic_Click(object sender, EventArgs e)
        {
            
            Instructor In = new Instructor()
            {

                Ins_Name = INS_Fname.Text,
                Ins_Degree = INs_Degree.Text,
                Salary = (decimal)int.Parse(Ins_Salary.Text),
                Dept_Id = (int)CB_Depts.SelectedValue,
                Email = INs_Email.Text,
                Password = INs_Password.Text

            };
            Db.Instructors.Add(In);
            Db.SaveChanges();
            this.Hide();
            Form f = new login();
            f.ShowDialog();

        }
    }
}
