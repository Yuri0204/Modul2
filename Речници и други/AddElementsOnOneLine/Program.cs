using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementsOnOneLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> market = new Dictionary<string, int>();
            var linia = Console.ReadLine().Split();
            while (true)
            {
                string stoka = linia[0];
                if (stoka == "stop")
                {
                    break;
                }
                int price = int.Parse(linia[1]);
                if (market.ContainsKey(stoka))
                {
                    market[stoka] + price;
                }
                else
                {
                    market.Add(stoka, price);
                }

                linia = Console.ReadLine().Split();
            }
            foreach ( var item in market)
            {
                Console.WriteLine($"{item.Key} => {item.Value} leva");
            }
        }
    }
}
