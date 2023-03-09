using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace AsyncProgamming
{
    public class RunProgram
    {
        

        public static void Start(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            SynchronousExecution obj1 = new SynchronousExecution();
            s1.Start();
            Console.WriteLine("Synchronous Execution");
            obj1.ShortTimeTakingMethod();
            obj1.LongTimeTakingMethod();
           
            s1.Stop();
            Console.WriteLine($"Time taken to execute Synchronous program:{s1.ElapsedMilliseconds}");
      
        }
        public static async Task StartAsync(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            AsynchronousExecution obj2 = new AsynchronousExecution();
            s1.Reset();
            s1.Restart();
            Console.WriteLine();
            Console.WriteLine("Asynchronous Execution");
            //obj2.LongTimeTakingMethod();
            //obj2.ShortTimeTakingMethod();
            var t1 = obj2.ShortTimeReturnsSqaureAsync(4);
            var t2 = obj2.LongTimeReturnsSquareOfSquareAsync(4);
            var t = Task.Run(() => { obj2.MethodAsync(); });
            Console.ReadLine();
            var r1 = await t1;
            var r2 = await t2;
            t.Wait();
            s1.Stop();
            Console.WriteLine($"Time taken to execute Asynchronous program:{s1.ElapsedMilliseconds}");
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
}