using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Dispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo DIspose");
            MyClass myClass = new MyClass();
            myClass.Display();
            myClass.Dispose();

            // USing the 'using' block

            using (MyClass m2 = new MyClass())
            {
                Console.WriteLine("Inside USing Bock");
                m2.Display();
            }

            
                Console.ReadLine();
        }
    }

    public class MyClass : IDisposable
    {
        public MyClass()
        {
            Console.WriteLine(" Ctor Called");
        }
        public void Display()
        {
            Console.WriteLine("Call Display");
        }

        public void Dispose()
        {
            Console.WriteLine("Calling Dispose");
            // Immedialy Call FInalize and Kill the Object
            GC.SuppressFinalize(this);
        }

        ~MyClass()
        {
            Console.WriteLine("Called Destructor");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("HAHAHAHAHAHOOOOOHIIII");
            }
            Console.ReadLine(); 
        }
    }
}
