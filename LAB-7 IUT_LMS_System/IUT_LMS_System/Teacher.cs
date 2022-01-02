using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT_LMS_System
{
    internal class Teacher:Course
    {
        public string TeacherName;
        public string TeacherType;

        public Teacher(string Name,string Type,string coursecode, string coursetype, string coursetitle, string semester):base(coursecode,coursetype,coursetitle,semester)
        {
            this.TeacherName = Name;
            this.TeacherType = Type;
        }  
    }
}
