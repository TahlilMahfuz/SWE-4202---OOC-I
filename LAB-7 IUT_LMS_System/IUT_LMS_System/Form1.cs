using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUT_LMS_System
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<TeacherInfo> teacherinfo = new List<TeacherInfo>();
        List<Course> courses = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddTeacherOnClick(object sender, EventArgs e)
        {
            TeacherInfo dummy = new TeacherInfo();

            dummy.TeacherName = TNameTB.Text;
            dummy.TeacherType = TTypeCB.Text;

            teacherinfo.Add(dummy);

            CTeacherCB.Items.Add(dummy.TeacherName);
            LBCBTeacher.Items.Add(dummy.TeacherName);

            MessageBox.Show("Teacher has been added");
        }

        private void AddCourse(object sender, EventArgs e)
        {
            // Course dummy = new Course(coursecode, string coursetype, string coursetitle, string semester);
            Course dummy = new Course();
            dummy.CourseCode =CCodeTB.Text;
            dummy.CourseType = CTypeCB.Text;
            dummy.CourseTitle = CTitleTB.Text;
            dummy.Semester = CSemesterCB.Text;
            dummy.Teacher = CTeacherCB.Text;

            SCourseCB.Items.Add(dummy.CourseCode);

            foreach (TeacherInfo info in teacherinfo)
            {
                if(dummy.Teacher == info.TeacherName)
                {
                    if(info.TeacherType == "Lecturer")
                    {
                        dummy.CourseType = "Lab";
                        CTypeCB.Text = "Lab";
                    }
                    else
                    {
                        dummy.CourseType = "Theory";
                    }
                    break;
                }
            }
            courses.Add(dummy);

            MessageBox.Show("Course Has been added");
        }

        private void AddStudentOnClick(object sender, EventArgs e)
        {
            Student dummy = new Student(SNameTB.Text, SSemesterCB.Text, SCourseCB.Text);
            LBCBStudent.Items.Add(SNameTB.Text);


            students.Add(dummy);

            MessageBox.Show("Student has been added");
        }

        private void ShowStudentInfo(object sender, EventArgs e)
        {
            foreach(Student find in students)
            {
                if(LBCBStudent.Text == find.StudentName)
                {
                    listBoxStudent.Items.Clear();
                    listBoxStudent.Items.Add(find.StudentName+'\t'+find.StudentSemester+'\t'+find.StudentCourseTitle);
                    break;
                }
            }
        }

        private void ShowTeacherInfo(object sender, EventArgs e)
        {
            foreach (Course find in courses)
            {
                if (LBCBTeacher.Text == find.Teacher)
                {
                    listBoxTeacher.Items.Clear();
                    if(find.CourseType == "Lab")
                    {
                        listBoxTeacher.Items.Add(find.Teacher + '\t' + find.CourseCode + '\t' + find.CourseType + '\t' + find.CourseTitle + '\t' + find.Semester + '\t' + "1.5");
                    }
                    else
                    {
                        listBoxTeacher.Items.Add(find.Teacher + '\t' + find.CourseCode + '\t' + find.CourseType + '\t' + find.CourseTitle + '\t' + find.Semester + '\t' + "3");
                    }
                    
                    break;
                }
            }
        }
    }
}
