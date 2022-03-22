using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IUT_Result_Processing_System
{
    public partial class Form1 : Form
    {
        List<StudentMarks> marks = new List<StudentMarks>();
        public Form1()
        {
            InitializeComponent();//C:\Users\TahlilsZenBook\Desktop\C#\IUT Result Processing System
            var lines = File.ReadAllLines(@"C:\Users\TahlilsZenBook\Desktop\C#\IUT Result Processing System\SWE4201MarkSheet.csv");
            listBox1.Items.Add("ID" + "\t" + "Name" + "\t" + "Percentage" + "\t" + "Grade" + "\n");
            foreach (var line in lines)
            {
                var values = line.Split(',');
                StudentMarks dummy = new StudentMarks();
                dummy.ID = values[0];
                dummy.Name = values[1];
                dummy.attendance = values[2];
                dummy.quizi = values[3];
                dummy.quizii = values[4];
                dummy.quiziii = values[5];
                dummy.quiziv = values[6];
                int a=Convert.ToInt32(values[3]);
                int b=Convert.ToInt32(values[4]);
                int c=Convert.ToInt32(values[5]);
                int d=Convert.ToInt32(values[6]);
                int e, f, g, h;
                e = a + b + c;
                f = b + c + d;
                g= c + d+a;
                h= d+a+b;
                if(e>f && e>g && e > h) { dummy.bestQuiz = Convert.ToString(e); }
                else if(f > e && f > g && f > h) { dummy.bestQuiz = Convert.ToString(f); }
                else if(g > e && g > f&& g > h) { dummy.bestQuiz = Convert.ToString(g); }
                else dummy.bestQuiz = Convert.ToString(h);
                dummy.mid = values[7];
                dummy.final = values[8];
                dummy.viva = values[9];

                int total = Convert.ToInt32(dummy.attendance) + 
                    Convert.ToInt32(dummy.bestQuiz)+ 
                    Convert.ToInt32(dummy.mid) + 
                    Convert.ToInt32(dummy.final) + 
                    Convert.ToInt32(dummy.viva);
                dummy.total = Convert.ToString(total);
                double per = ((total / 300.0) * 100.0);
                dummy.percentage = Convert.ToString(per);
                double p = per;

                if (p >= 80) { dummy.grade = "A+"; }
                else if (p >= 75 && p<=79) { dummy.grade = "A"; }
                else if (p >= 70 && p <= 74) { dummy.grade = "A-"; }
                else if (p >= 65 && p <= 69) { dummy.grade = "B+"; }
                else if (p >= 60 && p <= 64) { dummy.grade = "B"; }
                else if (p >= 55 && p <= 59) { dummy.grade = "B-"; }
                else if (p >= 50 && p <= 54) { dummy.grade = "C+"; }
                else if (p >= 45 && p <= 49) { dummy.grade = "C"; }
                else if (p >= 40 && p <= 44) { dummy.grade = "D"; }
                else if (p >= 0 && p <= 39) { dummy.grade = "F"; }

                marks.Add(dummy);

                //listBox.Items.Clear();
                listBox1.Items.Add(dummy.ID + '\t' + dummy.Name + '\t' + dummy.percentage+"%"+"\t"+ dummy.grade + "\n");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchStudentsOnClick(object sender, EventArgs e)
        {
            var searchedInfo = from info in marks
                               where info.ID == StudentIDTB.Text
                               select info;
            foreach (var info in searchedInfo)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Attendence : " + info.attendance + "\n");
                listBox2.Items.Add("Quiz 1 : " + info.quizi + "\n");
                listBox2.Items.Add("Quiz 2 : " + info.quizii + "\n");
                listBox2.Items.Add("Quiz 3 : " + info.quiziii + "\n");
                listBox2.Items.Add("Quiz 4 : " + info.quiziv + "\n");
                listBox2.Items.Add("Quiz Total(Best 3) : " + info.bestQuiz + "\n");
                listBox2.Items.Add("Mid : " + info.mid + "\n");
                listBox2.Items.Add("Final : " + info.final + "\n");
                listBox2.Items.Add("Viva : " + info.viva + "\n");
                listBox2.Items.Add("Total : " + info.total+ "\n");
                listBox2.Items.Add("Percentage : " +info.percentage+"%"+ "\n");
                listBox2.Items.Add("Grade : " +info.grade+"\n");
                break;
            }
        }
    }
}
