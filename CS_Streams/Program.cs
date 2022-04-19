using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CS_Streams.Logic;

namespace CS_Streams
{
    internal class Program
    {

        static FileStreamOperations fsOp;
        static void Main(string[] args)
        {
            Console.WriteLine("Using Streams");
            fsOp = new FileStreamOperations();

            fsOp.CreateFile("MyStream.txt");

            // fsOp.WriteFile("MyStream.txt");

            fsOp.ReadFile("MyStream.txt");
          //  fsOp.AppendFile("MyStream.txt");

            Console.ReadLine(); 
        }
    }
}
