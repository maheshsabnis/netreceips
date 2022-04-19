using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.Models
{
    /// <summary>
    /// The class implements the IMath interface
    /// Rule: All methods of the interface MUST be implemeented by the class
    /// The following is an example of Implicit Implementation
    /// </summary>
    internal class ClsMathBasic : IMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Multi(int x, int y)
        {
            return x * y;
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }

    /// <summary>
    /// Explicit Implementation
    /// Methods are owned by the Intarface
    /// No Access specifier is needed, it will be received from the interface itself (Public)
    /// </summary>
    internal class ClsMathExplicit : IMath
    {
        int IMath.Add(int x, int y)
        {
            return x + y;
        }
        int IMath.Sub(int x, int y)
        {
            return x - y;
        }
        int IMath.Multi(int x, int y)
        {
            return x * y;
        }
        int IMath.Divide(int x, int y)
        {
            return x / y;
        }
    }
}
