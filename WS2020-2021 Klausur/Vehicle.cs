using System;
using System.Collections.Generic;
using System.Text;

namespace WS2020_2021_Klausur
{
    class Vehicle
    {
        protected int vehicleID;
        protected int currentPosition;
        public Vehicle(int vehicleID,int currentPosition)
        {
            this.vehicleID = vehicleID;
            this.currentPosition = currentPosition;
        }
    }
}
