using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x>0)
            {
                Console.WriteLine("Chisloto e polojitelno");
            }
            if (x<0)
            {
                Console.WriteLine("Chisloto e otricatelno");
            }
            else if  (x==0)
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
