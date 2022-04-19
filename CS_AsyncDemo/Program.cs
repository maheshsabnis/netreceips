using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_AsyncDemo
{
    public delegate int MathHandler(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Async Demo");
            Console.WriteLine($"Calling From MAin THraed {Thread.CurrentThread.ManagedThreadId} ");
            MathHandler math = new MathHandler(Add);

            // STart an Async OPeration

            IAsyncResult ar = math.BeginInvoke(100, 200, null, null);
            int i = 0;
            while (ar.IsCompleted == false)
            {
                Console.WriteLine($"Main Main Main {i}");
                i++;
            }


            int Res = math.EndInvoke(ar); 
            Console.WriteLine($"Res = {Res}");
            Console.ReadLine(); 
        }

        static int Add(int x, int y)
        {
            Console.WriteLine($"Executing From Add THraed {Thread.CurrentThread.ManagedThreadId} ");
            //Thread.Sleep(10000);
            return x + y;
        }
    }
}
