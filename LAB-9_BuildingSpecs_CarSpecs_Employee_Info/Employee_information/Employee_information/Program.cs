using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_information
{
    internal class Program
    {
        List<Staff> staffs = new List<Staff>();
        static void Main(string[] args)
        {
            Staff staff = new Staff(200,"Tahlil");
            Teacher teacher = new Teacher(100,"Mahfuz","English","Lecture");
            Typist Typist = new Typist(10, "Faruk", "Fast");
            Officer officer = new Officer(1,"Tanzim","Professor");
            Regular regular = new Regular(10,"Shahriar","Medium");
            Casual casual = new Casual(11,"Nazmul","slow","100");

            Console.WriteLine(teacher.whoami());
            Console.ReadKey();
        }
    }
}
