using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Users";
                DataTable dt = DataAccess.GetManyRowsCols(sql);
                dgUsers.DataSource = dt;
                dgUsers.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin fmLogin = new FormLogin();
            if (fmLogin.ShowDialog() == DialogResult.OK)
            {
                string sql = "select Username from Users " +
                    "where Username='" + fmLogin.Username + "' and " +
                    "Password='" + fmLogin.Password + "'";
                object obj = DataAccess.GetSingleAnswer(sql);
                if (obj != null)
                    MessageBox.Show("Login successful..");
                else
                    MessageBox.Show("invalid login..");
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            updateDB(((ToolStripMenuItem)sender).Text);
        }

        private void updateDB(String clickedItem)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:\\Users\\kyungminum\\Documents\\Programming\\CPSC-440\\DBTest\\DBTest";
                ofd.Filter = "text files|*.txt|docx files|*.docx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    
                    if (!filename.Contains(clickedItem+".txt"))
                        throw new Exception(filename+" "+clickedItem+" Wrong file selected");

                    FileInfo fi = new FileInfo(filename);

                    Stream str = fi.Open(FileMode.Open, FileAccess.Read);

                    StreamReader sstr = new StreamReader(str);

                    //Stream Reader is a text type of stream
                    string sLine = sstr.ReadLine();
                    //MessageBox.Show(sLine);
                    char[] seps = { ',' };
                    string sql = "";
                    while (sLine != null)
                    {
                        string[] parts = sLine.Split(seps);
                        sql += "INSERT INTO " + clickedItem + " VALUES (";
                        for (int i = 0; i < parts.Length; i++)
                        {
                            if (i > 0) sql += ",";
                            string s = parts[i];
                            sql += "\'" + s + "\'";
                            
                        }
                        sql += ");\n";
                        sLine = sstr.ReadLine();
                        if (sLine == null)
                            break;
                        if (sLine.Trim() == "")
                            break;
                    }
                    MessageBox.Show("sql : " + sql);
                    UBDataAcess.InsertUpdateDelete(sql);
                    MessageBox.Show("DONE");
                }
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show("FE : " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EX : " + ex.Message + "\n" +
                    ex.StackTrace);

            }
           
        }

        private void viewStudents_Click(object sender, EventArgs e)
        {
            FormViewStudents fmLogin = new FormViewStudents();
            if (fmLogin.ShowDialog() == DialogResult.OK)
            {
                char[] seps = { ',' };
                string department = fmLogin.Department.Split(seps)[0];
                try
                {
                    string sql = "SELECT* from Students, StudentMajors where DepartmentId = '"+department+"' AND Students.StudentId = StudentMajors.StudentId;";
                    DataTable dt = DataAccess.GetManyRowsCols(sql);
                    dgUsers.DataSource = dt;
                    dgUsers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void viewStudentGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch fmSearch = new FormSearch();
            if (fmSearch.ShowDialog() == DialogResult.OK)
            {
                string firstname = fmSearch.Firstname;
                try
                {
                    string sql = "SELECT DISTINCT Courses.CourseNum, Courses.CourseName, CoursesTaken.Grade from Courses, CoursesTaken, StudentCourses, Students where(Students.FirstName = '"+firstname+"' AND CoursesTaken.StudentId = Students.StudentId AND Courses.CourseNum = CoursesTaken.CourseNum); ";
                    DataTable dt = DataAccess.GetManyRowsCols(sql);
                    dgUsers.DataSource = dt;
                    dgUsers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void viewCoursesOfferedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSemesters fmSemesters = new FormSemesters();
            if (fmSemesters.ShowDialog() == DialogResult.OK)
            {
                string semester = fmSemesters.Semester;
                try
                {
                    string sql = "SELECT * from CoursesOffered where Semester = '" + semester + "';";
                    DataTable dt = DataAccess.GetManyRowsCols(sql);
                    dgUsers.DataSource = dt;
                    dgUsers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void viewEnrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnrollments fmEnrollments = new FormEnrollments();
            if (fmEnrollments.ShowDialog() == DialogResult.OK)
            {
                string semester = fmEnrollments.Semester;
                string course = fmEnrollments.Course;
                try
                {
                    string sql = "SELECT * from StudentCourses where Semester = '" + semester + "' AND CourseNum='"+course+"';";
                    DataTable dt = DataAccess.GetManyRowsCols(sql);
                    dgUsers.DataSource = dt;
                    dgUsers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
       
    
}
