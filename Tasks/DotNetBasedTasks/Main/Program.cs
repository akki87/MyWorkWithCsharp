// See https://aka.ms/new-console-template for more information
using ArraysAndLinq;
using DecimalToBinaryConversions;
using StringCompressor;
using intArrays;
using System.Diagnostics;
using Recursion;

internal class Program
{
    private static void Main(string[] args)
    {

        //LinqArray array = new LinqArray();
        //array.printAllNumbers();
        //array.printEvenNumbers();
        //array.printOddNumbers();
        //Console.WriteLine(Compressor.CompressString("kkkktttrrr747484"));
        //DecimalToBinaryConversions.RunProgram.Start(args);
        //ArrayOperations obj = new ArrayOperations();
        //obj.Add(2001);
        //Console.Write("\nEnter the element to find its position: ");
        //var number = Convert.ToInt32(Console.ReadLine());
        //var stopwatch = Stopwatch.StartNew();
        //stopwatch.Start();
        //obj.BinarySearch(number);
        //stopwatch.Stop();
        //Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        //Recursion.RunProgram.Start(args);
        //LinqOnEmployeeList.RunProgram.Start(args);
        ConcurrentApplication.RunProgram.Start(args);
        //LinqOnEmployeeList.RunProgram.Start(args);
        AsyncProgamming.RunProgram.Start(args);
        AsyncProgamming.RunProgram.StartAsync(args);

     }
}
