using System;
using System.Diagnostics;

namespace fibfunction
{
    class Program
    {
        static long fib(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
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