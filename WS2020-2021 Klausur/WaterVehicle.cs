using System;
using System.Collections.Generic;
using System.Text;

namespace WS2020_2021_Klausur
{
    abstract class WaterVehicle : Vehicle
    {
        protected int loadVolume;
        public WaterVehicle(int loadVolume,int vehicleID,int currentPos):base(vehicleID,currentPos)
        {
            this.loadVolume = loadVolume;
        }
    }
    class Boat : WaterVehicle
    {
        protected bool anchor;
        public Boat(bool anchor, int loadVolume, int vehicleID, int currentPos) : base(loadVolume, vehicleID, currentPos)
        {
            this.anchor = anchor;
        }
        public override string ToString()
        {
            return ($"({vehicleID}) - ({currentPosition}) -  - ({loadVolume}) - ({anchor})");
        }
        private new int currentPosition;

        public virtual void Move(int strecke)
        {
            currentPosition += strecke;
        }
    }
    class SportBoat : Boat
    {
        public SportBoat(bool anchor, int loadVolume, int vehicleID, int currentPos) : base(anchor, loadVolume, vehicleID, currentPos)
        {

        }
        public override string ToString()
        {
            return ($"({vehicleID}) - ({currentPosition}) -  - ({loadVolume}) - ({anchor})");
        }
        public override void Move(int strecke)
        {
            currentPosition += 2 * strecke;
        }
        class AirBoat : Boat
        {
            public AirBoat(bool anchor, int loadVolume, int vehicleID, int currentPos) : base(anchor, loadVolume, vehicleID, currentPos)
            {

            }
            public override string ToString()
            {
                return ($"({vehicleID}) - ({currentPosition}) -  - ({loadVolume}) - ({anchor})");
            }
            public override void Move(int strecke)
            {
                currentPosition += strecke / 2;
            }
        }
    }
}
