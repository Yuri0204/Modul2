using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iztrivane_na_otricatelni_elementi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            num.Reverse();
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]<0)
                {
                    num.Remove(num[i]);
                }
            }

            int count = num.Count();

            if (count>0)
            {
                Console.WriteLine(string.Join(" ", num));
            }
            else if (count == 0)
            {
                Console.WriteLine("Empty");
            }


            Console.WriteLine(string.Join(" ",num));
        }
    }
}
