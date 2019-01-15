using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a Random generator [ will be used all over the program!!!! ]
            Random randomGenerator = new Random();

            // ========================================== Example 1
            // == dynamic size single dimensional array
            // == filling the array with random numbers
            // how to create an array in dynamic size and fill it with random numbers

            Console.WriteLine("Example 1:");

            int numberParsed;
            double avg;
            int sum = 0;
            // 1. get a number from the user
            Console.WriteLine("Please enter the array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            
            // 2. create a one dimensional array with the input size
            int[] arrayInDynamicSize = new int[size];

            // 3. fill the array with random numbers between 1-500 using the random generator
            for (int i = 0; i < arrayInDynamicSize.Length; i++)
            {
                bool isParsed;
              
                do
                {
                    Console.WriteLine($"Enter grade for student {i}:");

                    isParsed = int.TryParse(Console.ReadLine(), out numberParsed);

                }
                while (!isParsed);
               
               
                    arrayInDynamicSize[i] = numberParsed;
                sum = sum + arrayInDynamicSize[i];

            }
            Console.WriteLine();  
            // 5. print the array
            for (int i = 0; i < arrayInDynamicSize.Length; i++)
            {
                Console.WriteLine(arrayInDynamicSize[i]);
            }
            avg = sum / size;
            Console.WriteLine($"The avarage  of the grades is {avg }:");
            Console.ReadLine();

        }
    }
}
