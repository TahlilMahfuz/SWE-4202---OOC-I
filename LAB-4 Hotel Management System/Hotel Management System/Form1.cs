using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        List<Single> singles = new List<Single>();
        List<Double> doubles = new List<Double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddSingleRoom(object sender, EventArgs e)
        {
            Single SingleRoom = new Single();
            SingleRoom.Name = SingleNameTB.Text;
            SingleRoom.Quantity = Convert.ToInt32(SingleQuantityTB.Text);
            SingleRoom.AirCondition = SingleAirConditionerTB.Text;
            SingleRoom.Cost = 2000;
            if (GamingSetupTB.Text == "yes" || GamingSetupTB.Text == "YES")
            {
                SingleRoom.Cost = SingleRoom.Cost + 1000;
            }
            if(SingleRoom.AirCondition == "YES" || SingleRoom.AirCondition == "yes")
            {
                SingleRoom.Cost = SingleRoom.Cost + 500;
            }

            singles.Add(SingleRoom);

            MessageBox.Show("You have created " + SingleRoom.Quantity + " " + SingleRoom.Name+ " rooms which costs "+ SingleRoom.Cost);
        }

        private void AddDoubleRoom(object sender, EventArgs e)
        {
            Double DoubleRoom  = new Double();
            DoubleRoom.Name = DoubleNameTB.Text;
            DoubleRoom.TV = Convert.ToInt32(DoubleRoomtv.Text);
            DoubleRoom.Refrigerator = Convert.ToInt32(DoubleRefrigerator.Text);
            DoubleRoom.Quantity = Convert.ToInt32(DoubleQuantity.Text);
            DoubleRoom.AirCondition = DoubleAirConditioner.Text;
            DoubleRoom.ComplimenteryBreakfast = DoubleComplimenteryBreakfast.Text;
            DoubleRoom.ExtraTV = DoubleExtraTV.Text;
            DoubleRoom.Cost = 3500;
            if(DoubleRoom.AirCondition == "YES" || DoubleRoom.AirCondition == "yes")
            {
                DoubleRoom.Cost = DoubleRoom.Cost + 500;
            }
            if(DoubleRoom.ExtraTV == "YES" || DoubleRoom.ExtraTV == "yes")
            {
                DoubleRoom.Cost = DoubleRoom.Cost + 1000;
            }
            if(DoubleRoom.ComplimenteryBreakfast =="YES" || DoubleRoom.ComplimenteryBreakfast == "yes")
            {
                DoubleRoom.Cost = DoubleRoom.Cost + 500;
            }

            doubles.Add(DoubleRoom);

            MessageBox.Show("You have created " + DoubleRoom.Quantity + " " + DoubleRoom.Name + " rooms which costs " + DoubleRoom.Cost);
        }

        private void RentARoom(object sender, EventArgs e)
        {
            foreach(Room room in doubles)
            {
                if(RoomNameTB.Text == room.Name)
                {
                    room.Quantity = room.Quantity - Convert.ToInt32(RoomNameQuantity.Text);
                    int a= Convert.ToInt32(RoomNameQuantity.Text);
                    int b=room.Cost;
                    int price =a*b;
                    MessageBox.Show("The room has been booked and" + " your cost is " + price);
                }
            }
            foreach (Room room in singles)
            {
                if (RoomNameTB.Text == room.Name)
                {
                    room.Quantity = room.Quantity - Convert.ToInt32(RoomNameQuantity.Text);
                    int a = Convert.ToInt32(RoomNameQuantity.Text);
                    int b = room.Cost;
                    int price = a * b;
                    MessageBox.Show("The room has been booked and" + " your cost is " + price);
                }
            }

            
        }

        private void ShowAvailable(object sender, EventArgs e)
        {
            foreach (Room room in doubles)
            {
                if (RoomNameSecond.Text == room.Name)
                {
                    ShowAvailableLBL.Text = Convert.ToString(room.Quantity);
                    break;
                }
                
            }
            foreach (Room room in singles)
            {
                if (RoomNameSecond.Text == room.Name)
                {
                    ShowAvailableLBL.Text = Convert.ToString(room.Quantity);
                    break;
                }
                
            }
        }
    }
}
