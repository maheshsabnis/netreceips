using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk_AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# 3.0 Anonymous Type");
            var obj = new { Id=101, Name="ABC" };
            
            Console.WriteLine($"Data is {obj.Id} and {obj.Name}");
            Console.ReadLine(); 
        }

        
    }
}
