using System;

namespace Motored_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Audi", "A8", 2004, 50);
            car1.GetDetailedInfo();
            Console.WriteLine(car1.TurnOn());
            car1.Go();
        
        }   
       
        
        
        
            


    }
}
