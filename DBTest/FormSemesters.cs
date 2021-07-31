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
    public partial class FormSemesters : Form
    {
        public string Semester { get { return cbSemesters.Text; } }
        public FormSemesters()
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
    }
}
