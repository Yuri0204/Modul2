﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masivi_vhod
{
    class Program
    {
        static void Main(string[] args)
        {
      using System;
      using System.Collections.Generic;
      using System.Linq;
      using System.Text;
      using System.Threading.Tasks;

class Program
        {
            static void Main(string[] args)
            {
                //Deklarirane na dvumeren masiv
                int[,] A = new int[3, 4];
                int[,] B = { { 1, 2, 3 }, { 4, 5, 6 }, };

                for (int i = 0; i < 3; i++)
                {
                    for (int i2 = 0; i2 < 4; i2++)
                    {
                        Console.Write($"A {i} ,{i2} = ");
                        A[i, i2] = int.Parse(Console.ReadLine());

                    }
                }
                //Pechat na masiv
                for (int i = 0; i < 2; i++)
                {
                    for (int i2 = 0; i2 < 3; i2++)
                    {
                        Console.Write($"A{i},{i2} = {A[i, i2]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    } }
