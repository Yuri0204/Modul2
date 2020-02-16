using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_promenliva
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Convert.ToBoolean(n);
            if (n=="Richtig")
            {
                Console.WriteLine("JAA");
            }
            if (n=="Falsch")
            {
                Console.WriteLine("9");
            }
        }
    }
}
