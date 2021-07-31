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
    public partial class FormViewStudents : Form
    {
        public string Department { get { return cbDepartments.Text; } }
    
        public FormViewStudents()
        {
            InitializeComponent();
            setDepartments();
        }

        private void setDepartments()
        {
            string sql = "select * from Departments";
            DataTable dt = UBDataAcess.GetManyRowsCols(sql);
            foreach(DataRow dr in dt.Rows)
            {
                cbDepartments.Items.Add(dr.ItemArray[0]+","+dr.ItemArray[1].ToString());
                
            }
        }

    }
}
