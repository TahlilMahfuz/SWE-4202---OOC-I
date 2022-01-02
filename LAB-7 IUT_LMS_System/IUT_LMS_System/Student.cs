using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT_LMS_System
{
    internal class Student:Course
    {
        public string StudentName;
        public string StudentSemester;
        public string StudentCourseTitle;

        public Student(string name, string semester,string course):base(semester,course)
        {
            StudentName = name;
            StudentSemester = semester;
            StudentCourseTitle = course;
        }
    }
}
