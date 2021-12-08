using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRS_Dependencies;

namespace CarRentalSystem
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void User_Save(object sender, EventArgs e)
        {
            User DummyUser = new User();
            DummyUser.UserID = UserIDTB.Text;
            DummyUser.UserName = UserNameTB.Text;
            DummyUser.Address=AddressTB.Text;
            DummyUser.Destination = DestinationTB.Text;

            users.Add(DummyUser);
            MessageBox.Show("User has been added");
        }

        private void Car_save(object sender, EventArgs e)
        {
            Car DummyCar = new Car();
            DummyCar.CarName = CarNameTB.Text;
            DummyCar.Model=ModelTB2.Text;
            DummyCar.NumberOfCars = NumberOfCarsTB.Text;

            cars.Add(DummyCar);
            MessageBox.Show("Car has been added");
        }

        private void CarHistoryOnClick(object sender, EventArgs e)
        {
            string DummyName = carNameTB2.Text;
            foreach(Car Car in cars)
            {
                if(Car.CarName == DummyName)
                {
                    AvailableUnitLBL.Text = Car.NumberOfCars;
                }
            }
        }

        private void RentCar(object sender, EventArgs e)
        {
            string RentedUser = RentCarUserIDTB.Text;
            string RentedCar  = RentCarCarNameTB.Text;
            foreach(User user in users)
            {
                if(user.UserID == RentedUser)
                {
                    foreach (Car car in cars)
                    {
                        if (car.CarName == RentedCar)
                        {
                            user.UserRentedCar = RentedCar;
                            int n = Convert.ToInt32(car.NumberOfCars);
                            n = n - 1;
                            car.NumberOfCars = Convert.ToString(n);
                            break;
                        }
                    }
                }
            }
            
            MessageBox.Show("Car has been added to user");
        }

        private void ShowUserHistoryOnClick(object sender, EventArgs e)
        {
            string searchID = UserHistoryUserID.Text;
            foreach(User User in users)
            {
                if(User.UserID == searchID)
                {
                    UserNameLBL.Text = User.UserName;
                    AddressLBL.Text = User.Address;
                    RentedCarLBL.Text = User.UserRentedCar;
                    DestinationLBL.Text = User.Destination;
                }    
            }
        }
    }
}
