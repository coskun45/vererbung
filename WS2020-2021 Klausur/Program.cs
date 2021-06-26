using System;
using System.Collections.Generic;
using System.Text;

namespace WS2020_2021_Klausur
{
    class Program
    {
        static void Main(string[] args)
        {
            Harbor har = new Harbor();

            har.PushVehicle(new Boat(true, 1, 2, 3));
            har.PushVehicle(new Boat(false, 10, 22, 33));
            har.PushVehicle(new Boat(true, 15, 24, 32));
            har.PushVehicle(new Boat(false, 17, 82, 73));
            har.PushVehicle(new Vehicle(1, 2));
            har.Write();


        }
    }
}
