using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Partial
{


    internal partial class MyClass : MyBase
    {
        public override void MyBaseMethod()
        {
            Console.WriteLine("I am Overridden");
            base.MyBaseMethod();
        }
    }
}
