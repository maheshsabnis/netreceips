using System;
using CS_Interface.Models;
namespace CS_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsMathBasic m1 = new ClsMathBasic();
            // Accessing Inetrafce methods owned by class using the Class Instance
            Console.WriteLine($"Add m1 is = {m1.Add(20,10)}");
            Console.WriteLine($"Sub m1 is = {m1.Sub(20, 10)}");
            Console.WriteLine($"Multi m1 is = {m1.Multi(20, 10)}");
            Console.WriteLine($"Divide m1 is = {m1.Divide(20, 10)}");

            //define an interface reference and instantiate it using the class
            // because IMath is implemented by the ClsMathBasic class
            IMath m2 = new ClsMathBasic();
            Console.WriteLine($"Add m2 is = {m2.Add(20, 10)}");
            Console.WriteLine($"Sub m2 is = {m2.Sub(20, 10)}");
            Console.WriteLine($"Multi m2 is = {m2.Multi(20, 10)}");
            Console.WriteLine($"Divide m2 is = {m2.Divide(20, 10)}");

            // Accessing Methods from class that is explicitely implementing the interface

            IMath m3 = new ClsMathExplicit();

            Console.WriteLine($"Explicit Add m3 is = {m3.Add(20, 10)}");
            Console.WriteLine($"Explicit Sub m3 is = {m3.Sub(20, 10)}");
            Console.WriteLine($"Explicit Multi m3 is = {m3.Multi(20, 10)}");
            Console.WriteLine($"Explicit Divide m3 is = {m3.Divide(20, 10)}");

            // Create An instance of ClsAllMath and while accessing its methods
            // Cast it to the Corresponding interface

            ClsAllMath m4 = new ClsAllMath();
            // Interface with Polymorphic Behavior for Accessing methods
            // This is the Runtime call to specific method of the interface
            Console.WriteLine($"IMath.Add is = {((IMath)m4).Add(10,20)}");
            Console.WriteLine($"IMathNew.Add is = {((IMathNew)m4).Add(10, 20)}");

            // Define Interface Reference and instantiate it using the ClsAllMath class
            // and access its methods

            IMath m5 = new ClsAllMath();
            Console.WriteLine($"IMath.Sub is = {m5.Sub(20,10)}");
            IMathNew m6 = new ClsAllMath();
            Console.WriteLine($"IMathNew.Sub is = {m6.Sub(20, 10)}");



            Console.ReadLine();
        }
    }
}
