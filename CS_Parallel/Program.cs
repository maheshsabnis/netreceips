using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// The TPL NAmespace
using System.Threading.Tasks;

namespace CS_Parallel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parallel Class");
            FileOPerations fileOPerations = new FileOPerations();
            // invking 2 methods at a time
            Parallel.Invoke(() =>
            {
                fileOPerations.ReadFileJB();
                fileOPerations.ReadFileIJ();    
            });

                
            Console.ReadLine(); 
        }
    }
}
