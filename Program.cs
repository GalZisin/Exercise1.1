using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int[,] theMatrix = new int[3, 3]; 
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    theMatrix[i, j] = randomGenerator.Next(0, 2);
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
            Console.WriteLine("Enter arow num");
            int rowNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter colum num");
            int columNum = Convert.ToInt32(Console.ReadLine());
            
                   if(theMatrix[rowNum, columNum]== 1)
                    {
                        Console.WriteLine("BOOM!");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
              
            
            Console.ReadLine();
        }
    }
}
