using System;
using System.Collections.Generic;
using System.Text;

namespace WS2020_2021_Klausur
{
   abstract class AirVehicle:Vehicle
    {
        protected int numberEngines;
        public AirVehicle(int numberEngines,int vehicleID,int currentPosition):base(vehicleID,currentPosition)
        {
            this.numberEngines = numberEngines;
        }
    }
    sealed class AmphibiousAircraft : AirVehicle, IAmphibious
    {
        public int LoadVolume { get; }
        public int NumberWheels { get; }
        public AmphibiousAircraft(int loadVolume,int numberWheels,int numberEngines,int vehicleId,int currentPosition):base(numberEngines,vehicleId,currentPosition)
        {
            this.LoadVolume = loadVolume;
            this.NumberWheels = numberWheels;
        }
        public override string ToString()
        {
            return ($"({vehicleID}) - ({currentPosition}) - ({numberEngines}) - ({NumberWheels}) - ({LoadVolume})");
        }
    }
    interface IAmphibious
    {
        public int LoadVolume { get; }
        public int NumberWheels { get; }
    }
}
