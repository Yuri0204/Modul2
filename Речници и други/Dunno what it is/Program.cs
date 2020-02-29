using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno_what_it_is
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            Console.Write("brElRechnik:");
            int BrEl = int.Parse(Console.ReadLine());

            for (int i = 0; i < BrEl; i++)
            {
                Console.Write("Ime:");
                string name = Console.ReadLine();
                Console.Write("Nomer");
                string number = Console.ReadLine();

                if (phonebook.ContainsKey(name)
                {
                    phonebook[name] = number;
                }
                else
                {
                    phonebook.Add(name, number);
                }




                phonebook.Add(name, number);





            }

            foreach ( var item in phonebook)
            {
                Console.WriteLine($"iMe: {item.Key} => nOMER: {item.Value}");
            }
            phonebook.Remove("Asen");
            Console.Write(string.Join(" ", phonebook));

            int countRe = phonebook.Count();
            Console.WriteLine($"");


        }
    }
}
