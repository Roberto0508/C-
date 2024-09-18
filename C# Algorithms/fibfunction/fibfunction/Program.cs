using System;
using System.Diagnostics;

namespace fibfunction
{
    class Program
    {
        static long fib(int n)
        {
            if (n <= 2) return 1;
            else return fib(n - 1) + fib(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long f = fib(n);
            stopwatch.Stop();
            Console.WriteLine($"fib {n} = {f}");
            Console.WriteLine($"Elapsed time = {stopwatch.ElapsedTicks} ticks");
        }
    }
}