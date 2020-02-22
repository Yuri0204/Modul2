using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den_ot_sedmicata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in a day of the week as a number:");
            int day = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day>=1 && day<=7)
            {
                Console.WriteLine(days[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
