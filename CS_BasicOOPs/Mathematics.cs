using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_BasicOOPs
{
    public class Mathematics
    {
        // private members
        private int x,y,z;

        /// <summary>
        /// Constructor Function
        /// </summary>
        public Mathematics()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        private void AccessValues()
        {
            try
            {
                Console.WriteLine("Enter x");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occured while Converting data {ex.Message}");
                y = 0;
            }
        }

        public int Add()
        {
            AccessValues();
            z = x + y;
            return z;
        }

        public int Sub()
        {
            this.AccessValues();
            z = x - y;
            return z;
        }

        public int Mult()
        {
            this.AccessValues();
            z = x * y;
            return z;
        }
        public double Div()
        {
            this.AccessValues();
            double result = 0;
            try
            {
                if (y <= 0)
                {
                    // explicitely throwing an exception based on condition
                    throw new Exception("Sorry !!! the denominator cannot be 0 or -ve");
                }
                // Type-Casting of the result 
                // double result = (double)x / y;
                result = (double)x / y;
                // return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occured {ex.Message}");
              //  return 0;
            }
            return result;
            
        }
    }
}
