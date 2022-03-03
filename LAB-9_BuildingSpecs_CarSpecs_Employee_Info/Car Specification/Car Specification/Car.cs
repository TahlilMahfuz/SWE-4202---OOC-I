using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Specification
{
    internal class Car
    {
        public int Max_acceleration, Fuel_capacity;

        public Seat seat;
        public Wheel wheel;
        public Door door;
        public Engine engine;

        public void display()
        {
            Console.WriteLine("Seat : "+seat.Seat_warmer + seat.Comfortability+"\n"+"Wheel :"+wheel.Circumference+"\n"+
                "Door: "+ door.Opening_Mode);
        }
    }
}
