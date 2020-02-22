using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Pr_2_ObryshtaneMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(' ').ToArray();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }
            //Obryshtane na elementi na masiv
            Array.Reverse(word);
            Console.WriteLine(string.Join(" ",word));
        }
    }
}
