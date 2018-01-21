using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var delay = Task.Delay(1000).ContinueWith(_ =>
            {
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });

            Console.WriteLine("Elapsed milliseconds: {0}", delay.Result);

            /*  Console.WriteLine(DateTime.Now);
              Task.Delay(5);
              Console.WriteLine(DateTime.Now);
              Test();
              Console.WriteLine("Main end");*/
            Console.ReadKey();
        }

        static async void Test()
        {
            Console.WriteLine("first call");
            await DoSomethingAsync();
            Console.WriteLine("second call");
            Console.WriteLine("Test end");
        }

        static async Task DoSomethingAsync()
        {
            int val = 13;
            await Task.Delay(TimeSpan.FromSeconds(1));
            val *= 2;
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("Async end");
            Trace.WriteLine(val);
        }

    }
}
