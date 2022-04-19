using System;

namespace CS_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = JoinStrings("James", "Bond");
            Console.WriteLine(str);
            // Calling GetStringLength() method in WriteLine() because it returns value 
            Console.WriteLine("Length of " + str + " is = " + GetStringLength(str));

            string res = ProcessString(str, 'U');
            Console.WriteLine(res);
            res = ProcessString(str, 'u');
            Console.WriteLine(res);
            res = ProcessString(str, 'L');
            Console.WriteLine(res);
            res = ProcessString(str, 'l');
            Console.WriteLine(res);
            
        }

        static string JoinStrings(string s1, string s2)
        {
            return s1 + s2;
        }

        static int GetStringLength(string st)
        {
            return st.Length;
        }

        /// <summary>
        ///  usign switch case
        /// </summary>
        /// <param name="st"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static string ProcessString(string st, char c)
        {
            switch (c)
            {
                case 'U':
                    return st.ToUpper();
                case 'u':
                    return st.ToUpper();
                case 'L':
                    return st.ToLower();
                case 'l':
                    return st.ToLower();
                default:
                        return st;
            }
            return st;
        }

        static void CheckCharacterCount(string str, char charToCheck, out int dotcount, out int statementCount, out int blankspaceCount, out int commacount)
        {
            // logic

            dotcount = 100;
            statementCount = 0;
            blankspaceCount = 0;
            commacount = 0;

            
        }
    }



    
}
