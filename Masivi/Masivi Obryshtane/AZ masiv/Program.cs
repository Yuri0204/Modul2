﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[30];
            int j = 0;
            for (char i = 'a';  i <= 'z';  i++)
            {
                alphabet[j] = i;
                j++;
            }
            Console.WriteLine(string.Join(" ",alphabet));
            Console.WriteLine("Vavedete duma: ");
            string word = Console.ReadLine();
            Console.WriteLine(string.Join(" ", word));

            for (int i = 0; i < word.Length; i++)
            {
                for (int j1 = 0; j1 < alphabet.Length; j1++)
                {
                    if (word[i]==alphabet[j1])
                    {
                        Console.WriteLine($"{word[i]}-->{alphabet[j1]}");
                    }
                }
            }
        }
    }
}
