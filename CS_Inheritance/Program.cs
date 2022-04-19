using System;

namespace CS_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            Consultant consultant = new Consultant();

            // Reference of the Base class (emp)
            // is Instantiated using the Derived Class
            // Manager-is-a-Employee
            Employee emp = new Manager();
            // emp will not have an access to public proeprties of Manager class
            // emp.TravelAllowance = 100;
            // To access the public members of the derive class using the
            // Reference of the Base class, Cast the Base class Reference using
            // the Derive class (DownCasting)
            ((Manager)emp).TravelAllowance = 1000;
            // The Access of the proeprty of the Base Type of Manager i.e. FullTime
            // Manager-is-a-FullTime
            ((Manager)emp).DeptName = "IT";

            // Practices
            Employee e1 = null;
            
            e1 = new FullTime(); // Access Public properties of FullTime Only
            ((FullTime)e1).DeptName = "HR";
            Console.WriteLine($"Type of e1 is = {e1.GetType()}"); // FullTime


            e1 = new Manager(); // Access Public properties of FullTime and Manager 
            ((Manager)e1).PetrolAllowance = 1000;
            Console.WriteLine($"Type of e1 is = {e1.GetType()}"); // Manager

            e1 = new Consultant(); // Access Public properties of Consultant Only
            ((Consultant)e1).ConsultationFees = 10000;
            Console.WriteLine($"Type of e1 is = {e1.GetType()}"); // Consultant


            TwoWheelar two = new TwoWheelar();
            two.GetManufacturer("R.E.");
            two.EngineCapacity(350);
            Console.WriteLine($"Average = {two.GetAverage(2000, 40, "Lead")}");
           
            Safari safari = new Safari();

            Console.WriteLine($"Average is  = {safari.GetAverage(5000, 100, 1000)}");

            Console.WriteLine($"Max Speed is = {safari.GetMaxAllowedSpped(5000, 1.5, 3.5, 0.5,0.5)}");

            Console.WriteLine($"Max Fuel Capacity {safari.MaxFuel(400)}");


            MyDerive obj = new MyDerive();

            obj.PrintMessage("Hello"); // call Derive class method


            OverloadingWithSameNameButDifferentParameters ov1 = new OverloadingWithSameNameButDifferentParameters();

            Console.WriteLine($"Add 2 = {ov1.Add(2,3)}");
            Console.WriteLine($"Add 2 = {ov1.Add(2, 3,4)}");

            OverloadingSameNameButDifferentTypeParameters ov2 = new OverloadingSameNameButDifferentTypeParameters();

            Console.WriteLine($"Concate for string = {ov2.Concat("Mahesh", "Sabnis")}");
            Console.WriteLine($"Concate for date and string = {ov2.Concat(DateTime.Now, "Sabnis")}");

            OverloadingWithSameNameButDifferOrderOfParameters ov3 = new OverloadingWithSameNameButDifferOrderOfParameters ();

            Console.WriteLine($"Process 1 = {ov3.Process(10,100.564)}");
            Console.WriteLine($"Process 2 = {ov3.Process(100.56, 100)}");

            Console.ReadLine();
        }
    }
}
