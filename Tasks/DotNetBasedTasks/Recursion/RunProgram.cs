using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class RunProgram
    {
        public static void Start(string[] args)
        {
            Multiplication obj = new Multiplication();

            Console.Write("\n\tEnter the first number: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.Write("\n\tEnter the first number: ");
            var number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n\t Iterative Multiplication :{obj.IterativeMultiplication(number1, number2)}");
            var st = Stopwatch.StartNew();
            st.Start();
            Console.WriteLine($"\n\t Recursive Multiplication :{obj.RecursiveMultiplication(number1, number2)}");
            st.Stop();
            Console.WriteLine(st.Elapsed);
        }
    }
}
