using System;
using System.Diagnostics;

namespace ConsoleApp27
{
    class Program
    {
        static int linear_search(int[] v, int a)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == a)
                    return i;
            }
            return -1;
        }

        static void print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        static int rand_int(Random rnd, int a, int b)
        {
            return rnd.Next(a, b);
        }

        const int MAX_VALUE = 200000;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] v = new int[MAX_VALUE];

            int i;
            for (i = 0; i < v.Length; i++)
            {
                v[i] = rand_int(rnd, 1, MAX_VALUE * 10);
            }

            Console.WriteLine("------------------------------");
            print(v);

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Enter number to search for: ");
            int n = int.Parse(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int j = linear_search(v, n);
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("Found in position {0}", j);
            Console.WriteLine();
            Console.WriteLine($"Time: {stopwatch.ElapsedTicks} ticks");
        }
    }
}
