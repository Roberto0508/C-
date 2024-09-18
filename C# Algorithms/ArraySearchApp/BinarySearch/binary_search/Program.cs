using System;
using System.Diagnostics;
using BinarySearch.MergeSort;

namespace binary_search
{
    class Program
    {

        static int binary_search(int[] v, int from, int to, int a)
        {
            if (from > to)
                return -1;
            int mid = (from + to) / 2;
            if (v[mid] == a)
                return mid;
            else if (v[mid] < a)
                return binary_search(v, mid + 1, to, a);
            else
                return binary_search(v, from, mid - 1, a);
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

            MergeSort.merge_sort(v, 0, MAX_VALUE - 1);
            Console.WriteLine("------------------------------");
            print(v);

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Enter number to search for: ");
            int n;
            n = int.Parse(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int j = binary_search(v, 0, v.Length - 1, n);
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("Found in position {0}", j);
            Console.WriteLine();
            Console.WriteLine($"Time: {stopwatch.ElapsedTicks} ticks");
        }
    }
}
