namespace DBTest
{
    partial class Form1
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
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.initializeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursePrerequisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesOfferedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesTakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMajorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCoursesOfferedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEnrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(44, 127);
            this.btnShowUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(148, 36);
            this.btnShowUsers.TabIndex = 0;
            this.btnShowUsers.Text = "Show Users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // dgUsers
            // 
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Location = new System.Drawing.Point(240, 137);
            this.dgUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersWidth = 82;
            this.dgUsers.RowTemplate.Height = 24;
            this.dgUsers.Size = new System.Drawing.Size(560, 252);
            this.dgUsers.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(44, 190);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDBToolStripMenuItem,
            this.studentManagementToolStripMenuItem,
            this.courseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 48);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // initializeDBToolStripMenuItem
            // 
            this.initializeDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.professorsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.coursePrerequisitesToolStripMenuItem,
            this.coursesOfferedToolStripMenuItem,
            this.coursesTakenToolStripMenuItem,
            this.studentCoursesToolStripMenuItem,
            this.studentMajorsToolStripMenuItem,
            this.professorDepartmentsToolStripMenuItem});
            this.initializeDBToolStripMenuItem.Name = "initializeDBToolStripMenuItem";
            this.initializeDBToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.initializeDBToolStripMenuItem.Text = "InitializeDB";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.departmentsToolStripMenuItem.Text = "Departments";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // professorsToolStripMenuItem
            // 
            this.professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            this.professorsToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.professorsToolStripMenuItem.Text = "Professors";
            this.professorsToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // coursePrerequisitesToolStripMenuItem
            // 
            this.coursePrerequisitesToolStripMenuItem.Name = "coursePrerequisitesToolStripMenuItem";
            this.coursePrerequisitesToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.coursePrerequisitesToolStripMenuItem.Text = "CoursePrerequisites";
            this.coursePrerequisitesToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // coursesOfferedToolStripMenuItem
            // 
            this.coursesOfferedToolStripMenuItem.Name = "coursesOfferedToolStripMenuItem";
            this.coursesOfferedToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.coursesOfferedToolStripMenuItem.Text = "CoursesOffered";
            this.coursesOfferedToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // coursesTakenToolStripMenuItem
            // 
            this.coursesTakenToolStripMenuItem.Name = "coursesTakenToolStripMenuItem";
            this.coursesTakenToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.coursesTakenToolStripMenuItem.Text = "CoursesTaken";
            this.coursesTakenToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // studentCoursesToolStripMenuItem
            // 
            this.studentCoursesToolStripMenuItem.Name = "studentCoursesToolStripMenuItem";
            this.studentCoursesToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.studentCoursesToolStripMenuItem.Text = "StudentCourses";
            this.studentCoursesToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // studentMajorsToolStripMenuItem
            // 
            this.studentMajorsToolStripMenuItem.Name = "studentMajorsToolStripMenuItem";
            this.studentMajorsToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.studentMajorsToolStripMenuItem.Text = "StudentMajors";
            this.studentMajorsToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // professorDepartmentsToolStripMenuItem
            // 
            this.professorDepartmentsToolStripMenuItem.Name = "professorDepartmentsToolStripMenuItem";
            this.professorDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.professorDepartmentsToolStripMenuItem.Text = "ProfessorDepartments";
            this.professorDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.viewStudentGradesToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(370, 44);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudents_Click);
            // 
            // viewStudentGradesToolStripMenuItem
            // 
            this.viewStudentGradesToolStripMenuItem.Name = "viewStudentGradesToolStripMenuItem";
            this.viewStudentGradesToolStripMenuItem.Size = new System.Drawing.Size(370, 44);
            this.viewStudentGradesToolStripMenuItem.Text = "View Student Grades";
            this.viewStudentGradesToolStripMenuItem.Click += new System.EventHandler(this.viewStudentGradesToolStripMenuItem_Click);
            // 
            // courseManagementToolStripMenuItem
            // 
            this.courseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCoursesOfferedToolStripMenuItem,
            this.viewEnrollmentsToolStripMenuItem});
            this.courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            this.courseManagementToolStripMenuItem.Size = new System.Drawing.Size(259, 40);
            this.courseManagementToolStripMenuItem.Text = "Course Management";
            // 
            // viewCoursesOfferedToolStripMenuItem
            // 
            this.viewCoursesOfferedToolStripMenuItem.Name = "viewCoursesOfferedToolStripMenuItem";
            this.viewCoursesOfferedToolStripMenuItem.Size = new System.Drawing.Size(380, 44);
            this.viewCoursesOfferedToolStripMenuItem.Text = "View Courses Offered";
            this.viewCoursesOfferedToolStripMenuItem.Click += new System.EventHandler(this.viewCoursesOfferedToolStripMenuItem_Click);
            // 
            // viewEnrollmentsToolStripMenuItem
            // 
            this.viewEnrollmentsToolStripMenuItem.Name = "viewEnrollmentsToolStripMenuItem";
            this.viewEnrollmentsToolStripMenuItem.Size = new System.Drawing.Size(380, 44);
            this.viewEnrollmentsToolStripMenuItem.Text = "View Enrollments";
            this.viewEnrollmentsToolStripMenuItem.Click += new System.EventHandler(this.viewEnrollmentsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 502);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem initializeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursePrerequisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesOfferedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesTakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentMajorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentGradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCoursesOfferedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEnrollmentsToolStripMenuItem;
    }
}

