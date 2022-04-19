using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance
{
    public class OverloadingWithSameNameButDifferentParameters
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
    }

    public class OverloadingSameNameButDifferentTypeParameters
    {
        public string Concat(string s1, string s2)
        { 
            return s1 + s2;
        }

        public string Concat(DateTime d, string s2)
        {
            return s2 + d.ToString();
        }
    }

    public class OverloadingWithSameNameButDifferOrderOfParameters
    {
        public double Process(int x, double d)
        { 
            return x * d;
        }

        public double Process(double d, int x)
        {
            return x * d * 100;
        }
    }

}
