using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance
{
    /// <summary>
    /// Base and Derive has same method with same signeture
    /// Signituere : Name of method, Number of parameters, type of parameters and order of parameters
    /// </summary>

    public  class MyBase
    {
        public void PrintMessage(string msg)
        {
            Console.WriteLine($"Base class = {msg}");
        }
    }


    public class MyDerive : MyBase
    {
        /// <summary>
        /// The PrintMessage() will shadow the matching method for the base class
        /// using an instance of the derived class 
        /// JIT will be aware that the PrintMesage() method
        /// need not to link with the base class method
        /// </summary>
        /// <param name="msg"></param>
        public new void PrintMessage(string msg)
        {
            Console.WriteLine($"Derive class = {msg}");
        }
    }
}
