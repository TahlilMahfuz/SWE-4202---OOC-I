using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT_LMS_System
{
    internal class Course
    {
        public string CourseCode;
        public string CourseType;
        public string CourseTitle;
        public string Semester;
        public string Teacher;

        public Course(string coursecode,string coursetype,string coursetitle,string semester)
        {
            this.CourseCode = coursecode;
            this.CourseType = coursetype;
            this.CourseTitle = coursetitle;
            this.Semester = semester;
        }

        public Course(string semester,string title)
        {
            this.CourseTitle = title;
            this.Semester = semester;
        }

        public Course()
        {

        }
    }
}
