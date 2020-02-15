using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            if (X>10)
            {
                Console.WriteLine("Chisloto e dvucifreno");
            }
            else
            {
                Console.WriteLine("Other");
            }
        }
    }
}
