using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            while(true)
            {
                List<string> current = Console.ReadLine().Split(' ').ToList();
                string command = current[0];
                if(command == "end")
                {
                    Console.WriteLine(String.Join(", ", input));
                    break;
                }
                else if(command == "add")
                {
                    int number = int.Parse(current[1]);
                    input.Add(number);
                }
                else if(command == "remove")
                {
                    int index = int.Parse(current[1]);
                    input.RemoveAt(index);
                }
                else if(command == "contains")
                {
                    int number = int.Parse(current[1]);
                    if(input.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }
    }
}
