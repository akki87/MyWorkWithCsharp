using System.Collections.Concurrent;
using System.Diagnostics;

namespace ConcurrentApplication
{
    public class RunProgram
    {
        public static async void Start(string[] args)
        {
            Employee e = new Employee();

            Records r = new Records();
            Operations operations = new Operations();
            Stopwatch stopwatch = new Stopwatch();
            ConcurrentQueue<Employee> filteredQueue = new ConcurrentQueue<Employee>(Records.EmployeeQueue.Take(10));
            int number = Convert.ToInt32(Console.ReadLine());
            stopwatch.Start();
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < number; i++)
            {
                tasks.Add(Task.Run(() => operations.PrintEmployee(filteredQueue)));
            }
            Task.WaitAll(tasks.ToArray());
            stopwatch.Stop();
            Console.ReadLine();
            Console.WriteLine($"For Multiple tasks of {number} it takes {stopwatch.ElapsedMilliseconds/1000} seconds");

        }
    }
}