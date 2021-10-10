using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber, numberOfElements;
            Console.WriteLine("Enter the number of elements to Print: ");
            numberOfElements = int.Parse(Console.ReadLine());
            
            if (numberOfElements < 2)
            {
                Console.Write("Please enter a number greater than 2");
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
        }
    }
}
