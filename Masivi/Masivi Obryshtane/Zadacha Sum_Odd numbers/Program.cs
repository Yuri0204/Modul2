using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarirane na masiv//
            int[] a = { 3, 32, -5, 8, 9 };

            int sum = a.Sum();
            Console.WriteLine(sum);

            //Sortirane na masiva//
            Array.Sort(a);

            Console.WriteLine(string.Join(" ", a));
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");

            }Console.WriteLine();
            //Obryshtane na masiv//
            Array.Reverse(a);

            Console.WriteLine(string.Join(" ", a));
        }
    }
}
