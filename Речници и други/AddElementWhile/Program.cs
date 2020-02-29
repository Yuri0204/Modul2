using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> market = new Dictionary<string, int>();
            int S = 0;
            while (true)
            {
                Console.WriteLine("stoka: ");
                string stoka = Console.ReadLine();
                if (stoka == "stop")
                {
                    break;
                }

                Console.WriteLine("Cena: ");
                int price = int.Parse(Console.ReadLine());

                market.Add(stoka, price);


            }
            Console.WriteLine("==============");
            foreach (var item in market)
            {
                Console.WriteLine($"Stoka: {item.Key}: Cena{item.Value}");
                S += item.Value;
            }
            Console.WriteLine(S);
        }
    }
}
