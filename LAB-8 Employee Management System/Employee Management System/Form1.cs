using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        class invalidEmpID : Exception
        {
            public invalidEmpID(string Message):base(Message)
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void AddEmpOnClick(object sender, EventArgs e)
        {
            DateTime date = Date.Value;
            DateTime leaves = Leaves.Value;
            Employee dummy = new Employee();
            dummy.Name = NameTB.Text;
            dummy.Contact  = ContactTB.Text;
            dummy.Salary = SalaryTB.Text;
            dummy.Leaves = Convert.ToString(leaves.Year);
            dummy.EmployeeID = EmpIDTB.Text;
            dummy.Designation = DesignationCB.Text;
            dummy.Date = Convert.ToString(date.Year);
            employees.Add(dummy);
            MessageBox.Show("Employee has been added");
        }

        private void SearchEmpIDOnCLick(object sender, EventArgs e)
        {
            int c= 0;
            foreach(Employee emp in employees)
            {
                if (emp.EmployeeID == SearchEmpIDTB.Text)
                {
                    c++;
                    int PaidAmount=0;
                    if(emp.Designation == "Manager")
                    {
                        Manager m = new Manager();
                        int y=Convert.ToInt32(emp.Leaves)- Convert.ToInt32(emp.Date);
                        PaidAmount= Convert.ToInt32(m.CountSalary(emp.Salary,y));
                    }
                    else if (emp.Designation == "Salesperson")
                    {
                        Salaesperson s = new Salaesperson();
                        int y = Convert.ToInt32(emp.Leaves) - Convert.ToInt32(emp.Date);
                        PaidAmount = Convert.ToInt32(s.CountSalary(emp.Salary, y));
                    }
                    else if (emp.Designation == "Typewriter")
                    {
                        Typewriter t= new Typewriter();
                        int y = Convert.ToInt32(emp.Leaves) - Convert.ToInt32(emp.Date);
                        PaidAmount = Convert.ToInt32(t.CountSalary(emp.Salary, y));
                    }
                    listBox.Items.Clear();
                    listBox.Items.Add(emp.EmployeeID + "\t" + emp.Name + "\t" + emp.Designation +"\t"+emp.Contact+"\t"
                        +emp.Date+"\t"+PaidAmount+"\t"+emp.Leaves);
                }
            }
            try
            {
                if(c==0)
                {
                    throw new invalidEmpID("Employee not found");
                }
            }
            catch(invalidEmpID ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            int cc = 0;
            foreach(Employee emp in employees)
            {
                if(emp.EmployeeID == UIDTB.Text)
                {
                    cc++;
                    DateTime date = UDateTB.Value;
                    DateTime leaves = ULeavesTB.Value;
                    if(UContactTB.Text!="")
                    {
                        emp.Contact = UContactTB.Text;
                    }
                    emp.Leaves = Convert.ToString(leaves.Year);
                    emp.Date = Convert.ToString(date.Year);
                    if (UContactTB.Text != "")
                    {
                        emp.Salary = Convert.ToString(USalaryTB.Text);
                    }
                    MessageBox.Show("Employee info has been updated");
                }
            }
            if(cc==0)
            {
                MessageBox.Show("Employee not found");
            }
        }
    }
}
