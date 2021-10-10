using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciExample
    {
        public static void Main()
        {
            int firstNumber = 0, secondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to print: ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please enter a number greater than " + numberOfElements);
            }
            else
            {
                Console.Write(firstNumber + " " + secondNumber + " ");
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
            Console.ReadKey();
        }
    }
}
