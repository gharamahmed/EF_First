using EFDay1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDay1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            ITIContext DB = new ITIContext();
            int id;
            try
            {
                id = DB.Instructors.Where(n => n.Email == INS_Email.Text && n.Password == INS_Password.Text).Select(n => n.Ins_Id).Single();
                this.Hide();
                Form f3 = new Topic(id);
                f3.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show("Enter Valid Data");
            }

        }
    }
}
