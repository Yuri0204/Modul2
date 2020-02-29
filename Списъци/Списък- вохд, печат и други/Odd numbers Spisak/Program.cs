using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_numbers_Spisak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int broi = 0;
            num.Sort();
            foreach (var item in num)
            {
                if (item%2==0)
                {
                    Console.WriteLine(item);
                    broi++;
                }
            }
            Console.WriteLine($"Broy na chetni: {broi}");
        }
    }
}
