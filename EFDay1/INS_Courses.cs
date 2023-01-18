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

namespace EFDay1
{
    public partial class INS_Courses : Form
    {
        int id;
        ITIContext DB;
        public INS_Courses(int Ins_id)
        {
            InitializeComponent();
            id = Ins_id;
            DB= new ITIContext();
        }

        private void INS_Courses_Load(object sender, EventArgs e)
        {
            DGV_Courses.DataSource = DB.Ins_Courses.Where(n => n.Ins_Id == id).Include(n => n.Crs).Include(n => n.Ins).Select(n => new { n.Crs_Id, n.Ins.Ins_Name, n.Ins.Ins_Degree, n.Ins.Dept.Dept_Name, n.Crs.Crs_Name, n.Crs.Crs_Duration }).ToList();
            CBCrs_Name.DataSource=DB.Courses.ToList();
            CBCrs_Name.DisplayMember = "Crs_Name";
            CBCrs_Name.ValueMember = "Crs_Id";
            Btn_Update.Visible = false;
            Btn_Delete.Visible = false;
            Btn_Add.Visible = true;

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Ins_Course ic= new Ins_Course() { Crs_Id=(int)CBCrs_Name.SelectedValue,Ins_Id=id};
            DB.Ins_Courses.Add(ic);
            DB.SaveChanges();
            DGV_Courses.DataSource = DB.Ins_Courses.Where(n => n.Ins_Id == id).Include(n => n.Crs).Include(n => n.Ins).Select(n => new {n.Crs_Id ,n.Ins.Ins_Name, n.Ins.Ins_Degree, n.Ins.Dept.Dept_Name, n.Crs.Crs_Name, n.Crs.Crs_Duration }).ToList();


        }
        int del;
        private void DGV_Courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            del = (int)DGV_Courses.SelectedRows[0].Cells[0].Value;
            Btn_Update.Visible = true;
            Btn_Delete.Visible= true;
            Btn_Add.Visible= false;
            Ins_Course I = DB.Ins_Courses.Where(n => n.Crs_Id == del && n.Ins_Id==id).SingleOrDefault();
            CBCrs_Name.SelectedValue =I.Crs_Id;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Ins_Course IC=DB.Ins_Courses.Where(n => n.Crs_Id == del && n.Ins_Id == id).Single();
            //IC.Crs_Id =(int) CBCrs_Name.SelectedValue;
            Btn_Delete_Click(null, null);
            Btn_Add_Click(null, null);
            //DB.SaveChanges();
            Btn_Update.Visible = false;
            Btn_Delete.Visible = false;
            Btn_Add.Visible = true;
            DGV_Courses.DataSource = DB.Ins_Courses.Where(n => n.Ins_Id == id).Include(n => n.Crs).Include(n => n.Ins).Select(n => new { n.Crs_Id, n.Ins.Ins_Name, n.Ins.Ins_Degree, n.Ins.Dept.Dept_Name, n.Crs.Crs_Name, n.Crs.Crs_Duration }).ToList();

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Ins_Course IC = DB.Ins_Courses.Where(n => n.Crs_Id == del && n.Ins_Id == id).Single();
            DB.Ins_Courses.Remove(IC);
            DB.SaveChanges();
            Btn_Update.Visible = false;
            Btn_Delete.Visible = false;
            Btn_Add.Visible = true;
            DGV_Courses.DataSource = DB.Ins_Courses.Where(n => n.Ins_Id == id).Include(n => n.Crs).Include(n => n.Ins).Select(n => new { n.Crs_Id, n.Ins.Ins_Name, n.Ins.Ins_Degree, n.Ins.Dept.Dept_Name, n.Crs.Crs_Name, n.Crs.Crs_Duration }).ToList();
        }
    }
}
