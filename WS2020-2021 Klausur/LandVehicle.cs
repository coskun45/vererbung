using System;
using System.Collections.Generic;
using System.Text;

namespace WS2020_2021_Klausur
{
   abstract class LandVehicle
    {
        protected int numberWheels;
        public LandVehicle(int wheelsNumber)
        {
            this.numberWheels = wheelsNumber;

        }
    }
}
