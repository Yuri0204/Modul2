using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> person = new Dictionary<string, int>
            {
                {"Hristo", 22},
                {"Asen", 35},
                {"Petar", 25},
                {"Ivan", 22},
                {"Petq", 32},
                {"Stefan", 40},
          };

            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");
            }

             var sortperson = person.OrderBy(x => x.Key);
            Console.WriteLine("==========");
            foreach (var item in sortperson)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");
            }
            var sortAgeDes = person.OrderByDescending(x=>x.Value);
            foreach (var item in sortAgeDes)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");
            }
        }
    }
}
