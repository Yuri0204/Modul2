﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masiv_entrance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"num=[{i}] = ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("=====FOR=====");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num=[{i}] ={num[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("=====FOREACH=====");
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("====string.Join=====");
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
