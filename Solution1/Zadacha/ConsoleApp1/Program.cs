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
            int n = int.Parse(Console.ReadLine());
            int Sum = 0;
            
           
            for (int i = 0; i <n ; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Sum = Sum + a % b;               
            }
            Console.WriteLine($"sum={Sum}");

        }
    }
}
