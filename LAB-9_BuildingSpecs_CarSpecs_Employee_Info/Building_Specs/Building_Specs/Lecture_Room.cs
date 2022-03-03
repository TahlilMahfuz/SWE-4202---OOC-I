using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Specs
{
    internal class Lecture_Room
    {
        private string roomName;
        private string roomN0, Capacity;

        public string getRoomName()
        {
            return roomName;
        }
        public void setRoomName(string RN)
        {
            roomName = RN;
        }

        public string getRoomNo()
        {
            return roomN0;
        }
        public void setRoomNo(string RNO)
        {
            roomN0 = RNO;
        }

        public string getCapacity()
        {
            return Capacity;
        }
        public void setCapacity(string capacity)
        {
            Capacity = capacity;
        }

        
    }
}
