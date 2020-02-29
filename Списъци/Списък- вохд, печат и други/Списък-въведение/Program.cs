using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списък_въведение
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Spisak = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", Spisak));

            for (int i = 0; i < Spisak.Count; i++)
            {
                Console.WriteLine($"Spisak[i{i}]={Spisak[i]}");
            }

            foreach (var item in Spisak)
            {
                Console.WriteLine(item);
            }
            //Suma na spisak
            int sum = Spisak.Sum();
            Console.WriteLine($"sum={sum}");

            //Minimalen element
            int min = Spisak.Min();
            Console.WriteLine($"min = {min}");

            //Maksimalen element
            int max = Spisak.Max();
            Console.WriteLine($"max = {max}");

            //Sredno-aritmetichno
            double Avrg = Spisak.Average();
            Console.WriteLine($"Avrg = {Avrg}");

            //Sortirane na spisak
            Console.WriteLine("Sortirane na spisak");
            Spisak.Sort();
            Console.WriteLine(string.Join(" ", Spisak));

            //Obryshtane na elementi na spisak
            Console.WriteLine("Obryshtane na elementi na spisak");
            Spisak.Reverse();
            Console.WriteLine(string.Join(" ", Spisak));

            //Broj na elementi na spisak
            Console.WriteLine("Broj na elementi na spisak");
            int BrElSpisak = Spisak.Count();
            Console.WriteLine(BrElSpisak);

            //Dobavqne na element v kraq na spisaka
            Console.WriteLine("Dobavqne na elementi v kraq na spisaka");
            Spisak.Add(1111);
            Console.WriteLine(string.Join(" ", Spisak));

            //Iztrivane na  konkretna stoinost na spisak
            Console.WriteLine("Iztrivane na konkretna stoinost na spisak");
            Spisak.Remove(2);
            Console.WriteLine(string.Join(" ", Spisak));

            //Iztrivane na konkretna stoinost po index
            Console.WriteLine("Iztrivane na konkretna stoinost po index");
            Spisak.RemoveAt(0);
            Console.WriteLine(string.Join(" ", Spisak));

            //Vmakvane na element na konkretna poziciq
            Spisak.Insert(1, 222);
            Console.WriteLine(string.Join(" ", Spisak));
        }
    }
}
