using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zadacha_15_tema
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int firstEl = num[0];
            int lastEl = num[num.Count - 1];
            int br = 0;

            while (num.Contains(lastEl))
            {
                num.Remove(lastEl);
                br++;
            }


            Console.WriteLine(string.Join(" ", num));
        }
    }
}
