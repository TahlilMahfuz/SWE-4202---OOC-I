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

namespace FileHandlingInCSharp
{
    public partial class Form1 : Form
    {
        List<Employee> emp = new List<Employee>();    

        public Form1()
        {
            InitializeComponent();
            var lines = File.ReadAllLines(@"C:\Users\TahlilsZenBook\Desktop\c#\FileHandlingInCSharp\userInfo.csv");
            foreach (var line in lines)
            {
                var values = line.Split(',');
                Employee dummy = new Employee();
                dummy.FIRST_NAME = values[0];
                dummy.LAST_NAME = values[1];
                dummy.ADDRESS = values[2];
                dummy.CITY = values[3];
                dummy.COUNTRY = values[4];
                dummy.STATE = values[5];
                dummy.ZIP = values[6];
                dummy.PHONE_NUMBER1 = values[7];
                dummy.PHONE_NUMBER = values[8];
                dummy.EMAIL = values[9];

                emp.Add(dummy);

                //listBox.Items.Clear();
                listBox.Items.Add(dummy.FIRST_NAME + '\t' + dummy.LAST_NAME + '\t' + dummy.EMAIL + "\n");

            }

        }

        private void CityTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowEmployeeOnCLick(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(@"C:\Users\TahlilsZenBook\Desktop\c#\FileHandlingInCSharp\userInfo.csv");
            foreach (var line in lines)
            {
                var values = line.Split(',');
                Employee dummy = new Employee();
                dummy.FIRST_NAME = values[0];
                dummy.LAST_NAME = values[1];
                dummy.ADDRESS = values[2];
                dummy.CITY = values[3];
                dummy.COUNTRY = values[4];
                dummy.STATE = values[5];
                dummy.ZIP = values[6];
                dummy.PHONE_NUMBER1 = values[7];
                dummy.PHONE_NUMBER = values[8];
                dummy.EMAIL = values[9];

                emp.Add(dummy);

            }
            int i = 0;
            foreach (Employee emp in emp)
            {
                if (emp.EMAIL == EmpEmail.Text)
                {
                    using (StreamWriter sw = File.AppendText(@"C:\Users\TahlilsZenBook\Desktop\c#\FileHandlingInCSharp\Write.txt"))
                    {
                        sw.WriteLine(emp.FIRST_NAME + " " + emp.LAST_NAME + " " 
                            +emp.ADDRESS+" "+emp.CITY+" "+emp.COUNTRY+" "+
                            emp.STATE+" "+emp.ZIP+" "+emp.PHONE_NUMBER1+" "+emp.PHONE_NUMBER
                            +" "+emp.EMAIL);
                    }
                    /*listBox.Items.Clear();
                    listBox.Items.Add("First Name" + "\t" + "Last Name" +"\t" + "Email"+"\n");
                    listBox.Items.Add(emp.FIRST_NAME + '\t' + emp.LAST_NAME + '\t'+ emp.EMAIL + "\n");*/

                    FirstNameTB.Text = emp.FIRST_NAME;
                    LastNameTB.Text = emp.LAST_NAME;  
                    AddressTB.Text = emp.ADDRESS;
                    CityTB.Text = emp.CITY; 
                    CountryTB.Text = emp.COUNTRY;
                    StateTB.Text = emp.STATE;   
                    Zip.Text = emp.ZIP;
                    Phone1.Text = emp.PHONE_NUMBER1;
                    Phone.Text = emp.PHONE_NUMBER;
                    EmailTB.Text = emp.EMAIL;

                    MessageBox.Show("Search Complete");
                    i++;
                    break;
                }
                
            }
            if(i==0)
            {
                using (StreamWriter sw = File.AppendText(@"C:\Users\TahlilsZenBook\Desktop\c#\FileHandlingInCSharp\Write.txt"))
                {
                    sw.WriteLine("Not Found");
                    MessageBox.Show("Information not found");
                }
            }
        }
    }
}
