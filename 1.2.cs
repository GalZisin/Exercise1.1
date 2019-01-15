using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int[,] theMatrix = new int[5, 5]; // 2 rows and 8 columns, fixed size
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    theMatrix[i, j] = randomGenerator.Next(1, 11);
                }
            }

            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    Console.Write("[" + i + "," + j + "]: ");
                    Console.WriteLine(theMatrix[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                   if(theMatrix[i, j]== num)
                    {
                        Console.Write("[" + i + "," + j + "]: ");
                    }
                }
            }
            Console.ReadLine();
        }
    }     
}
