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
            Dictionary<string, string> phonebook = new Dictionary<string, string>();           
            while (true)
            {
                var line = Console.ReadLine().Split().ToList();
                var command = line[0];
                if (command=="end")
                {
                    break;
                }
                if (command=="add")
                {
                    var name = line[1];
                    var number = line[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = number;
                    }
                    else
                    {
                        phonebook.Add(name, number);
                    }

                }
                if (command=="print")
                {
                    var name = line[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist");
                    }
                }
            }
        }
    }
}
