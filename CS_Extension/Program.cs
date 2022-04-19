using System;

namespace CS_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMO Extension Method");
            StrinOperations strOp = new StrinOperations ();
            string str = "I am String";
            Console.WriteLine($"The length of {str} is = {strOp.GetLength(str)}");
            Console.WriteLine($"The Upper case of {str} is = {strOp.ChangeCase('U',str)}");
            Console.WriteLine($"The Lower case of {str} is = {strOp.ChangeCase('L', str)}");
            Console.WriteLine($"Reverse of {str} is = {strOp.Reverse(str)}");
            Console.WriteLine($"Blankl Spaces in {str} is = {str.GetBlankCount()} ");
            Console.ReadLine(); 
        }
    }
    /// <summary>
    /// Consider that this class is provided by client
    /// </summary>
    public sealed class StrinOperations
    {
        public int GetLength(string str)
        {
            return str.Length;
        }
        public string ChangeCase(char c, string str)
        {
            if (c == 'U' || c == 'u') return str.ToUpper();
            if (c == 'L' || c == 'l') return str.ToLower();
            return str;
        }
    }


    // Lets add an extension method for the StrinOperations class
    /// <summary>
    /// Class is Static
    /// </summary>
    public static class MyExtension
    {
        /// <summary>
        /// Method is static
        /// First parameter of the method is 'this' refered reference of StrinOperations
        /// </summary>
        /// <param name="str"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Reverse(this StrinOperations str, string s)
        {
            string result = String.Empty;
            for (int i = s.Length-1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }
        /// <summary>
        /// Extension Method for the 'string' class
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetBlankCount(this string str)
        { 
            int count = 0;
            foreach (char c in str)
            {
                if(c == ' ')
                    count++;
            }
            return count;
        }
    }

}
