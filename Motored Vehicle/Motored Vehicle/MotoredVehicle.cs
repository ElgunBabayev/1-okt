using System;
using System.Collections.Generic;
using System.Text;

namespace Motored_Vehicle
{
    class MotoredVehicle
    {
        public MotoredVehicle()
        {
            Console.WriteLine("New car added");
        }

        public MotoredVehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make;
        public string Model;
        public string Color;
        public int Year;
        public int MotorSize;
        public int FuelAmount;
        public int FuelUsedPerKm;
        public int Transmission;
        public int HorsePower;
        public int PassangerCount;
         public virtual void GetDetailedInfo() 
        {
            Console.WriteLine($"{GetInfo()} {Year}");   
        }
         

        public string GetInfo()
        {
            return $"{Make} {Model}";
        }
       

        








    }
}
