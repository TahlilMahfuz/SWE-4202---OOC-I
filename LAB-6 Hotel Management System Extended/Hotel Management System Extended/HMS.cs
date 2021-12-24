using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_Extended
{
    internal class HMS: User
    {
        public static int BookingID = 0;
        public static int roomnumber=0;
        public int bookingID;
        public string roomNumber;
        public string RoomChoice;
        public string RoomQuantity;
        public string EntryDate;
        public string DepartureDate;
        public int Amount;
        public string Status;


        public int Single;
        public int Double;
        public int SuiteDeluxe;

        public HMS(string userid, string username, string contact, string adderss,string roomchoice, string roomquantity,string entrydate,string departuredate):base(userid,username,contact,adderss)
        {
            BookingID++;
            roomnumber++;
            RoomChoice = roomchoice;
            RoomQuantity = roomquantity;
            EntryDate = entrydate;
            DepartureDate = departuredate;
        }
    }
}
