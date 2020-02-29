using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zadacha_14_tema_word
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            num.Sort();
            int min = num.Min();
            int max = num.Max();

            foreach (var item in num)
            {
                if (item==min)
                {
                    Console.Write(item + " ");
                }
            }
            foreach (var item in num)
            {
                if (item==max)
                {
                    Console.WriteLine(item + " ");
                }
            }
        }
    }
}
