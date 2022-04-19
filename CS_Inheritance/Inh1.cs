using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance
{
    /// <summary>
    /// Common Base class with the Common Logic
    /// </summary>
    public class Vehicle
    {
        internal double CheckAdditivePercentage(string additiveType)
        {
            if (additiveType == "Mithen") return 0.02;
            if (additiveType == "Lead") return 0.05;
            return 0.01;

        }
        public void EngineCapacity(int capacity)
        {
            Console.WriteLine($"Engine Capacity {capacity}");
        }
        public double GetAverage(double km, double fuel, string additive)
        {
            double checkAdditive = CheckAdditivePercentage(additive);
            return km / (fuel * checkAdditive) ;
        }
    }

    public class TwoWheelar : Vehicle
    {
        public void GetManufacturer(string manufacturer)
        {
            // base.CheckAdditivePercentage("");
            Console.WriteLine($"Manufacturer {manufacturer}");
        }
    }


    public class FourWheelar : Vehicle
    {
        public void SeatingCapacity(int seating)
        {
            Console.WriteLine($"Seating Capacity is  = {seating}");
        }
    }
}
