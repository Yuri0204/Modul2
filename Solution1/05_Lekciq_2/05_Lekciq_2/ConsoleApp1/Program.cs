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
            Console.Write("Broy hora: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Kapacitet Asansyor: ");
            int p = int.Parse(Console.ReadLine());

            int kursove = n / p;
            int ostatak = n % p;
            if (ostatak!=0)
            {
                Console.WriteLine($"Broy kursove = {kursove}");
            }
            else
            {
                kursove++;
                Console.WriteLine($"Broy kursove = {kursove}");

            }
        }
    }
}
