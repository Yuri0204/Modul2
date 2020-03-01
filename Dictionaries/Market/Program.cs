using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> market = new Dictionary<string, List<double>>();
            double s = 0;

            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                var stoka = line[0];
                if (stoka == "stocked")
                {
                    break;
                }
                var price = double.Parse(line[1]);
                double quantity = double.Parse(line[2]);
                if (market.ContainsKey(stoka))
                {
                    for (int i = 0; i < market[stoka].Count; i++)
                    {
                        if (market[stoka][0]!=price)
                        {
                            market[stoka][0] = price;
                        }
                        market[stoka][1] = market[stoka][1] + quantity;
                    }
                 }
                else
                {
                    List<double> spisak = new List<double>();
                    spisak.Add(price);
                    spisak.Add(quantity);
                    market.Add(stoka, spisak);
                }

            }
            foreach (var item in market)
            {
                Console.WriteLine($"{item.Key}:${item.Value[0]:f2}*{item.Value[1]}= ${item.Value[0]}*{item.Value[1]:f2}");
                s += item.Value[0] * item.Value[1];

            }
            Console.WriteLine("--------------------");
            Console.WriteLine($"Grand Total: ${s}");
        }
    }
}
