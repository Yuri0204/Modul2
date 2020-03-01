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

            for (int i = 0; i <2 ; i++)
            {
                double sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(A[i,j] + " ");
                    sum += A[i, j];
                }
                double avg = sum / 3;
                Console.WriteLine($"ave={avg}");
            }
            int brRed = A.GetLength(0);
            Console.WriteLine($"brRed={brRed}");
            int brKoloni = A.GetLength(1);
            Console.WriteLine($"brRed={brKoloni}");
        }
    }
}
