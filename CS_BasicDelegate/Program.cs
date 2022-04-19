using System;

namespace CS_BasicDelegate
{

    // Lets define a delegate at namespace level
    // The Signeture of Delegate MUSt mathci with the Mathod Signeture that is to be Invoked
    // The followign delegate will be used to execute the method 
    // That has two input parameter of integer type and return type as integer
    public delegate int ProcessHandler(int x, int y);

    public delegate string StringProcessorHandler(string s1, string s2);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Delegate to execute a method with its reference");
            // Call Method Directly
            Console.WriteLine($"Add = {Add(10,20)}");

            // Using Delegate
            // Step 1. Define a Delegate Type Instance and pass the Method Reference that is to be invoked
            ProcessHandler addHandler = new ProcessHandler(Add);
            // Step 2. Pass Parameters to Delegate Type Instance that will invoke the method
            // using its reference that is passed in Step 1
            // Internall this will call the Invoke method of System.Delegate
            int Result = addHandler(100, 200);
            // Step 3: Print Result
            Console.WriteLine($"Add Call using Delegated is = {Result}");


            // Enhance the 'addHandler' to call 'Sub' method
            addHandler = new ProcessHandler(Sub);
            // Pass Parameters and Invoke the Sub Method
            Console.WriteLine($"Sub using Delegate is = {addHandler.Invoke(400,300)}" );
            addHandler = new ProcessHandler(Sub);
            

            // Using StringProcessorHandler
            Operatrion op = new Operatrion();
            // Reference of 'Concat()' method is stored in the Delegate
            StringProcessorHandler stringProcessor = new StringProcessorHandler(op.Concat);
            Console.WriteLine($"Concate = {stringProcessor("Mahesh","Sabnis")}");
            // In the existing Delegate we are adding a new node for new method Reference
            stringProcessor += new StringProcessorHandler(op.ChangeCase);
            Console.WriteLine($"Upper Case is = {stringProcessor("Mahesh", "U")}");
            // Removing the Reference of 'ChangeCase()' method
            stringProcessor -= new StringProcessorHandler(op.ChangeCase);
            Console.WriteLine($"Result After Removing Reference of ChangeCase is = {stringProcessor("Tejas", "U")}");

            Console.ReadLine();
        }

        // Lets define a method that will be executed using a Delegate

        static int Add(int x, int y)
        { 
            return x + y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
