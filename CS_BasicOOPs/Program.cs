using System;

namespace CS_BasicOOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define an instance of the Mathematics class
            // this will call the constructor
            Mathematics math = new Mathematics();

            Console.WriteLine($"Add = {math.Add()}");
            Console.WriteLine($"Sub = {math.Sub()}");
            Console.WriteLine($"Multiplication = {math.Mult()}");
            Console.WriteLine($"Division = {math.Div()}");
            Console.ReadLine();    
        }
    }
}
