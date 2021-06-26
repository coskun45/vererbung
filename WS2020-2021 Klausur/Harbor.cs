using System;
using System.Collections.Generic;
using System.Text;

namespace WS2020_2021_Klausur
{
    class Harbor
    {
        Boat[] Pier = new Boat[10];

        public Harbor()
        {

        }
        int counter = 0;
        public void PushVehicle(Vehicle element)
        {
            Boat neuElement = element as Boat;
            if (neuElement == null)
            {
                throw new Exception("Cast not successful");
            }
            else
            {
                
                if (counter > 9)
                {
                    throw new Exception("Stack full");
                }
                else
                {
                    for (int i = counter; i > 0; i--)
                    {
                       Pier[i]= Pier[i-1]  ;
                    }
                    Pier[0] = neuElement;
                    
                }
                counter++;

            }

        }
        public void Write()
        {
            for (int i = 0; i < Pier.Length; i++)
            {
                Console.WriteLine(Pier[i]);
            }
        }
    }
}
