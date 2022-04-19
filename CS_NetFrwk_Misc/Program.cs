using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk_Misc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Misc Operators");
            //  UsingSkip();
            // UsingSkipWhile();
            // UsingTake();
            // UsingSkipTake();
            UsingDistinct();
            Console.ReadLine(); 
        }

        /// <summary>
        /// Skips specific number of Records from the sequence
        /// </summary>
        /// 
        static void UsingSkip()
        {
            IList<string> lstString = new List<string>() 
            {
                "Tejas", "Mahesh", "Ramesh", "Ram",
                "Vivek", "Satish", "Mukesh", "Sandeep",
                "Vinay", "Tushar"
            };

            // Skip First 3 Records and Print reat all

            var res = lstString.Skip(3);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            res = from s in lstString.Skip(3)
                select s;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }


        static void UsingSkipWhile()
        {
            IList<string> lstString = new List<string>()
            {
                "Tejas", "Mahesh", "Ramesh", "Ram",
                "Vivek", "Satish", "Mukesh", "Sandeep",
                "Vinay", "Tushar"
            };

            var res = lstString.SkipWhile(s=>s.Length == 6);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
           
        }


        static void UsingTake()
        {
            IList<string> lstString = new List<string>()
            {
                "Tejas", "Mahesh", "Ramesh", "Ram",
                "Vivek", "Satish", "Mukesh", "Sandeep",
                "Vinay", "Tushar"
            };

            // Take First 2 Records and Print reat all

            var res = lstString.Take(2);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //var res1 = from s in lstString.Skip(2)
            //      select s;
            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item);
            //}
        }


        static void UsingSkipTake()
        {
            IList<string> lstString = new List<string>()
            {
                "Tejas", "Mahesh", "Ramesh", "Ram",
                "Vivek", "Satish", "Mukesh", "Sandeep",
                "Vinay", "Tushar"
            };

            // Take First 2 Records and Print reat all

            var res = lstString.Skip(3).Take(2);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            
           
        }

        static void UsingDistinct()
        {
            IList<int> numbers = new List<int>() {100,200,300,400,400,100,300,200,500,600,100,300 };

            // get only distinct records
            var res = from n in numbers.Distinct()
                      select n;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
