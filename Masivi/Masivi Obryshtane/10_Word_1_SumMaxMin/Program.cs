using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Word_1_SumMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ",num));

            int SumEl = num.Sum();
            Console.WriteLine($"Sum = {SumEl}");

            int maxEl = num.Max();
            Console.WriteLine($"Max = {maxEl}");


            int minEl = num.Min();

            Console.WriteLine($"Min={minEl}");

            double AvergEl = num.Average();
            Console.WriteLine($"Average = {AvergEl:f2}");
        }
    }
}
