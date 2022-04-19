using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CS_Task_Continution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Continue Across TAsks");
            SetTaskContinution();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"MAin {i}");
            }
            Console.ReadLine();
        }

        static void Op1()
        {
            Console.WriteLine("Operation 1");
        }
        static void Op2()
        {
            Console.WriteLine("Operation 2");
        }
        static void Op3()
        {
            Console.WriteLine("Operation 3");
        }

        static void SetTaskContinution()
        {
            var duration = Stopwatch.StartNew();

            Task task = Task.Factory.StartNew(() => Op1())
                .ContinueWith(delegate { Op2(); })
                .ContinueWith(delegate { Op3(); });

            Console.WriteLine($"Time to COmplete {duration.Elapsed.TotalMilliseconds}");
        }


    }
}
