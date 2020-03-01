using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogomeren_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Деклариране на двумерен масив
            int[,] A = new int[2, 3];
            //Запълване с елементи
            int[,] B = {  {1, 2, 3 }, {4, 5, 6 }, };

            for (int i = 0; i < 2; i++)
            {
                for (int J = 0; J < 3; J++)
                {
                    Console.Write($"A[{i}, {J}=]");
                    A[i, J] = int.Parse(Console.ReadLine());
                }
            }

            //Печат на масив
            for (int i = 0; i < 2; i++)
            {
                for (int J = 0; J < 3; J++)
                {
                    Console.WriteLine($"A[{i},{J}= {A[i, J]}");
                }
                Console.WriteLine();
            }
        }
    }
}
