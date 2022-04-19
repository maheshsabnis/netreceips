using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CS_TAsk_Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task Returnig data");
            // TAsk that is returning data
            Task<int> tResult =  Task.Factory.StartNew(() => {
                int res =  Add(10, 20);
                Console.WriteLine($"Result in TAsk = {res}");
                return res;
            });




            Console.WriteLine($"Result from Task in MAin = {tResult.Result}");


            Task<string[]> tFiles = Task.Factory.StartNew(() => {
                var files = GetFiles(@"c:\Coditas");
                return files;
            });

            foreach (var item in tFiles.Result)
            {
                Console.WriteLine($"File NAme = {item}");
            }


            Console.ReadLine();    
        }

        static int Add(int x, int y)
        { 
            return (x*x) + (y*y);
        }

        static string[] GetFiles(string path)
        {
            return Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories);
        }

    }
}
