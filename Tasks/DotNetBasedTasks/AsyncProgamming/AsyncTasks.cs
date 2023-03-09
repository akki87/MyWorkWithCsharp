using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgamming
{
    public  class SynchronousExecution
    {

        public  virtual void ShortTimeTakingMethod()
        {
            Console.WriteLine("Shortmethod Execution Started");
            process();
            Thread.Sleep(5000);
            Console.WriteLine($"Shortmethod Execution Stopped, Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        }

        public  virtual void  LongTimeTakingMethod()
        {
            Console.WriteLine("Longmethod Execution Started");
            process();
            Console.WriteLine($"Longmethod Execution Stopped, Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        }

        public Task<string> MethodAsync()
        {
            Console.WriteLine("Synchronous function executing asynchronously started..");
            Thread.Sleep(12000);
            Console.WriteLine("Synchronous function executing asynchronously stopped..");
            return Task.Run(()=> { return "Done"; });
        }

        public void process() { Console.WriteLine("Processing.."); }
    }

    public class AsynchronousExecution:SynchronousExecution  
    {
        public override void ShortTimeTakingMethod()
        {
            Console.WriteLine("Shortmethod Execution Started");
            base.process();
            Thread.Sleep(5000);
            Console.WriteLine($"Shortmethod Execution Stopped, Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        }

        public async override void LongTimeTakingMethod()
        {
            Console.WriteLine($"Longmethod Execution Started, Thread ID : {Thread.CurrentThread.ManagedThreadId}");
            base.process();
            await Task.Delay(10000);
            Console.WriteLine($"Completed Long time taking process, Thread ID : {Thread.CurrentThread.ManagedThreadId}");
            
        }

        public async Task<int> ShortTimeReturnsSqaureAsync(int n)
        {
            Console.WriteLine("Got the number");
            base.process();
            await Task.Delay(5000);
            Console.WriteLine("ShortTimeReturnsSqaureAsync is done here the result");
            return n *n;
        }
        public async Task<int> LongTimeReturnsSquareOfSquareAsync(int n)
        {
            int res = n * n;
            Console.WriteLine("Got the number");
            base.process();
            await Task.Delay(10000);
            Console.WriteLine("LongTimeReturnsSquareOfSquareAsync id done here the result");
            return res * res;
        }



    }
}
