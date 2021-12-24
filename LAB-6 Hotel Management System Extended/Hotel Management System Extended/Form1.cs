using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_Extended
{
    public partial class Form1 : Form
    {
        List<User> CreateUser = new List<User>();
        List<HMS> hms = new List<HMS>();
        List<RoomDetails>rooms= new List<RoomDetails>();
        int currentBalace = 0;
        int roomnumber=100;
        public Form1()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccountOnClick(object sender, EventArgs e)
        {
            User dummy = new User(UserIDTB.Text, UserNameTB.Text,UserContactTB.Text, UserAddressTB.Text);

            CreateUser.Add(dummy);

            MessageBox.Show("User has been created");
        }

        private void PlaceBookingOnClick(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (User p in CreateUser)
            {
                if (p.UserID == UserID.Text)
                {
                    HMS dummy = new HMS(p.UserID, p.UserName,p.Contact, p.Address,RoomChoice.Text,Quantity.Text,Entry.Text,Departure.Text);
                    dummy.bookingID = HMS.BookingID;
                    dummy.Status = "Confirmed";
                    if(Quantity.Text == "1")
                    {
                        dummy.roomNumber = Convert.ToString(++roomnumber);
                    }
                    if(Quantity.Text == "3")
                    {
                        dummy.roomNumber = Convert.ToString(++roomnumber) +" "+Convert.ToString(++roomnumber)+" " +Convert.ToString(++roomnumber);
                    }
                    if(Quantity.Text == "2")
                    {
                        dummy.roomNumber = Convert.ToString(++roomnumber) + " " + Convert.ToString(++roomnumber);
                    }

                    if(RoomChoice.Text == "Single")
                    {
                        dummy.Single = 100 * Convert.ToInt32(dummy.RoomQuantity);
                        dummy.Amount=dummy.Single;
                    }
                    else if (RoomChoice.Text == "Double")
                    {
                        dummy.Double = 200 * Convert.ToInt32(dummy.RoomQuantity);
                        dummy.Amount = dummy.Double;
                    }
                    else if (RoomChoice.Text == "Suite Deluxe")
                    {
                        dummy.SuiteDeluxe = 300 * Convert.ToInt32(dummy.RoomQuantity);
                        dummy.Amount = dummy.SuiteDeluxe;
                    }

                    currentBalace=currentBalace+dummy.Amount;
                    RoomDetails addRooms = new RoomDetails();
                    addRooms.Roomtype = RoomChoice.Text;
                    addRooms.RoomQuantity= Quantity.Text;
                    addRooms.Amount = Convert.ToString(dummy.Amount);
                    rooms.Add(addRooms);

                    hms.Add(dummy);

                    flag++;

                    MessageBox.Show("Your details are updated. Your Booking id is " + HMS.BookingID);
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("BookingID not found. Please create an account");
            }
        }

        private void ShowRoomsOnClick(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add("RoomType" + '\t' + "RoomQuantity" + '\t' + "Amount" + '\t');
            foreach (RoomDetails ro in rooms)
            {
                listBox.Items.Add(ro.Roomtype + '\t'+'\t' + ro.RoomQuantity + '\t'+'\t' + ro.Amount);
            }
        }

        private void SeeOrderOnClick(object sender, EventArgs e)
        {
            foreach(HMS find in hms)
            {
                if(find.bookingID== Convert.ToInt32(SeeBookingIDTB.Text))
                {
                    StatusLBL.Text = find.Status;
                    RoomNoLBL.Text = Convert.ToString(find.roomNumber);
                    AmountLBL.Text = Convert.ToString(find.Amount);
                    UserNameLBL.Text = find.UserName;
                    AddressLBL.Text = find.Address;
                }
            }
        }

        private void SetStatusOnClick(object sender, EventArgs e)
        {
            CurrentBalanceLBL.Text = Convert.ToString(currentBalace);
            foreach(HMS find in hms)
            {
                if(find.bookingID == Convert.ToInt32(Owner_BookingIDTB.Text))
                {
                    find.Status = Owner_statusTB.Text;
                }
            }
        }
    }
}
