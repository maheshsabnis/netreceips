using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.Models
{
    /// <summary>
    /// Polymorphism using Interfaces
    /// </summary>
    internal class ClsAllMath : IMath, IMathNew
    {
        int IMath.Add(int x, int y)
        {
            return x + y;
        }

        int IMathNew.Add(int x, int y)
        {
            return (x * x) + 2 * x * y + (y * y);
        }

        int IMath.Divide(int x, int y)
        {
            return x / y;
        }

        int IMathNew.Divide(int x, int y)
        {
            return (x * x) / (y * y);  
        }

        int IMath.Multi(int x, int y)
        {
            return x * y;
        }

        int IMathNew.Multi(int x, int y)
        {
            return (x * x) * 2 * x * y + (y * y);
        }

        int IMath.Sub(int x, int y)
        {
            return x - y;
        }

        int IMathNew.Sub(int x, int y)
        {
            return (x * x) - 2 * x * y + (y * y);
        }
    }
}
