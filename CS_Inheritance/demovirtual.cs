using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance
{
    /// <summary>
    /// Abstract classs that will not be instantiated
    /// </summary>
    public abstract class Suv
    {
        /// <summary>
        /// The virtual menas the derive class can either use the
        /// method logic (behavior) as-it-is or can enhance it
        /// by writing new pr extended logic for the virtual method 
        /// </summary>
        /// <param name="km"></param>
        /// <param name="fuel"></param>
        /// <param name="enginecapacity"></param>
        /// <returns></returns>
        public virtual double GetAverage(double km, double fuel, double enginecapacity)
        { 
            return km / fuel * (enginecapacity * 0.02);
        }
        // abstract method 
        public abstract double GetMaxAllowedSpped(double enginecapacity, double height, double width, double wheelwidth, double widthheight);

        public double MaxFuel(double fuelTankCapacity)
        {
            return fuelTankCapacity - (fuelTankCapacity * 0.03);
        }
    }


    public class Safari : Suv
    {
        /// <summary>
        /// The 'override' is using the base class behavior for the method as-it-is and
        /// enhancing it using the new logic
        /// </summary>
        /// <param name="km"></param>
        /// <param name="fuel"></param>
        /// <param name="enginecapacity"></param>
        /// <returns></returns>
        public override double GetAverage(double km, double fuel, double enginecapacity)
        {
            return base.GetAverage(km, fuel, enginecapacity) * 0.5;
        }

        public override double GetMaxAllowedSpped(double enginecapacity, double height, double width, double wheelwidth, double widthheight)
        {
            double SafariArea =  height * width;
            double WheelArea = wheelwidth * wheelwidth;

            double maxSpeed = (enginecapacity / (SafariArea * WheelArea)) * 100;

            return maxSpeed;
        }
    }
    /// <summary>
    /// The Gloster class is overriding all methods of Suv abstract class
    /// with complete new implementation
    /// </summary>
    public class Gloster : Suv
    {
        /// <summary>
        /// Complete new Implementation 
        /// </summary>
        /// <param name="km"></param>
        /// <param name="fuel"></param>
        /// <param name="enginecapacity"></param>
        /// <returns></returns>
        public override double GetAverage(double km, double fuel, double enginecapacity)
        {
            return km / fuel / enginecapacity;
        }

        public override double GetMaxAllowedSpped(double enginecapacity, double height, double width, double wheelwidth, double widthheight)
        {
            return enginecapacity / (height * width) / (wheelwidth * widthheight);
        }

    }

}
