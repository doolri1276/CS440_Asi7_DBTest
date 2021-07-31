using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTest
{
    public partial class FormEnrollments : Form
    {

        public string Semester { get { return cbSemesters.Text; } }
        public string Course { get { return cbCourse.Text; } }
        public FormEnrollments()
        {
            InitializeComponent();
            setSemesters();
        }

        private void setSemesters()
        {
            string sql = "select DISTINCT CoursesOffered.Semester from CoursesOffered";
            DataTable dt = UBDataAcess.GetManyRowsCols(sql);
            foreach (DataRow dr in dt.Rows)
            {
                cbSemesters.Items.Add(dr.ItemArray[0]);

            }
        }

        private void cbSemesters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from CoursesOffered where Semester='" + cbSemesters.Text + "';";
            DataTable dt = UBDataAcess.GetManyRowsCols(sql);
            foreach (DataRow dr in dt.Rows)
            {
                cbCourse.Items.Add(dr.ItemArray[0]);
            }
            cbCourse.Enabled = true;
        }
    }
}
