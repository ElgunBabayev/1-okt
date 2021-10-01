using System;
using System.Collections.Generic;
using System.Text;

namespace Motored_Vehicle
{
    class Car:MotoredVehicle
    {
        public bool IsOn;
        public int FTS;
        public Car(string make, string model, int year):base(make, model, year)
        {

        }
        public Car(string make, string model, int year, int fueltanksize):base( make, model, year)
        {
            FTS = fueltanksize;
        }


        public bool TurnOn()
        {

            return IsOn = true;
            
        }
        public bool TurnOff()
        {
            return IsOn = false;
             

        }
         
        public void Go()
        {
            if (IsOn == true)
            {
                int distance = Convert.ToInt32(Console.ReadLine());
                int fueltanksize = 50;
                double fuelperkm = 0.5;
                double result = (distance * fuelperkm) / 10;

                if (fueltanksize >= result)
                {
                    Console.WriteLine(distance + "km qet edildi");
                    Console.WriteLine(fueltanksize - result + " Yanacaq qaldi");

                }
                else
                {
                    Console.WriteLine("Kifayet qeder yanacaq yoxdur");
                }

            }
            else
            {
                Console.WriteLine("Muherriki ise sal");
            }
        }
        public override void GetDetailedInfo()
        {
            base.GetDetailedInfo();
            Console.WriteLine($"{ FTS}");
        }

    }
}
