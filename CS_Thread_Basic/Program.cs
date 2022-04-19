using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace CS_Thread_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THreading");
            // 1. set the thred name
            Thread.CurrentThread.Name = "Main THread";
            Console.WriteLine($"The CUrrent THread {Thread.CurrentThread.Name}\t" +
                $"{Thread.CurrentThread.ManagedThreadId}\t" +
                $"{Thread.CurrentThread.CurrentCulture}\t" +
                $"{Thread.CurrentThread.Priority}" 
                );

            // 2. To Execute a method (Code) on seperate thread, use ThreadStart Delegate
            Thread t1 = new Thread(()=>Increment());
            Thread t2 = new Thread(()=>Decrement());
            // 3. start thread
            t1.Start();
            t2.Priority = ThreadPriority.Highest;
            t2.Start();
            Console.ReadLine(); 
        }

        static void Increment()
        {
            Console.WriteLine($"Increment method THread Id {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Increent {i}");
                if (i == 5)
                {
                    // Ask the Thread whiching executing this code to
                    // wait for  second
                    Thread.Sleep(1000);
                }
            }
        }

        static void Decrement()
        {
            Console.WriteLine($"Decrement method THread Id {Thread.CurrentThread.ManagedThreadId}");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Decreent {i}");
                if (i == 5)
                {
                    // suspend the thread
                   // Thread.CurrentThread.Suspend();
                   Thread.CurrentThread.Abort(); // Kill
                }
                //else
                //{
                //    // Error Condition
                //    Thread.CurrentThread.Resume();
                //}
            }
        }
    }
}
