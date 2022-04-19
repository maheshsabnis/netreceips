using System;

namespace CS_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using for loop
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($" i = {i}");
            }

            string strName = "Mahesh Sabnis";
            // Iterate over the string
            for (int i = 0; i < strName.Length; i++)
            {
                Console.WriteLine($" Character at {i}th postion is = {strName[i]}");
            }

            // Using foreach loop
            foreach (char c in strName)
            {
                Console.WriteLine(c);
            }

            // the while..loop
            // WILL execcute till the condition is true
            int j = 0;
            while (strName.Length > 0)
            {
                Console.WriteLine($" Character at {j}th postion is = {strName[j]}");
                j++;
            }
        }
    }
}
