using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        List<Buyer> buyers = new List<Buyer>();
        List<Finance> finances = new List<Finance>();
        Finance finance = new Finance();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMedicineOrOthers(object sender, EventArgs e)
        {
            Medicine dummy = new Medicine();
            int count = 0;
            foreach(Medicine m in medicines)
            {
                if(m.GetName().Equals(M_Name.Text))
                {
                    m.SetQuantity(Convert.ToString(Convert.ToInt32(m.GetQuantity()) + Convert.ToInt32(M_Quantity.Text)));
                    count++;
                }
            }
            if(count==0)
            {
                dummy.SetName(M_Name.Text);
                dummy.SetQuantity(M_Quantity.Text);
                dummy.SetPricePerQuantity(M_Price.Text);
                medicines.Add(dummy);
            }
          
            MessageBox.Show("Product has been added successfully");
        }

        private void ShowTotal(object sender, EventArgs e)
        {
            Buyer dummy = new Buyer();
            dummy.SetM_name(B_M_Name.Text);
            dummy.SetM_quantity(M_Quantity.Text);

            buyers.Add(dummy);

            
            foreach(Medicine me in medicines)
            {
                if(me.GetName().Equals(B_M_Name.Text))
                {
                    int Total_Price, a, b;
                    a =Convert.ToInt32(me.GetPricePerQuantity());
                    b = Convert.ToInt32(B_Quantity.Text);
                    Total_Price = a * b;
                    int newquantity = Convert.ToInt32( me.GetQuantity()) - b;
                    me.SetQuantity(Convert.ToString(newquantity));
                    finance.SetTotalSold(Total_Price+finance.GetTotalSold());
                    MessageBox.Show("Total Price is " + Total_Price);
                    break;
                }
            }
 
        }

        private void CheckAvailableAmount(object sender, EventArgs e)
        {
            foreach(Medicine me in medicines)
            {
                if(me.GetName().Equals(SearchName.Text))
                {
                    M_AvailableLBL.Text = me.GetQuantity();
                    break;
                }
            }
        }

        private void CheckProfitOnClick(object sender, EventArgs e)
        {
            TotalSoldLBL.Text = Convert.ToString(finance.GetTotalSold());           
        }
    }
}
