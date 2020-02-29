using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniorska_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mina = new Dictionary<string, int>();

            while (true)
            {
                string izkopaemo = Console.ReadLine();
                if (izkopaemo=="stop")
                {
                    break;
                }
                int kolich = int.Parse(Console.ReadLine());
                if (mina.ContainsKey(izkopaemo))
                {
                    mina[izkopaemo] += kolich;
                }
                else
                {
                    mina.Add(izkopaemo, kolich);
                }
                foreach (var item in mina)
                {
                    Console.WriteLine($"{item.Key} => {item.Value} ");
                }
            }
        }
    }
}
