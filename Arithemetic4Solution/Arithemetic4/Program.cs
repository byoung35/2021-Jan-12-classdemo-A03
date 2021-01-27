using System;

namespace Arithemetic4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program will prompt the user for a three-digit whole number
            //The program will then calculate the sum of the digits of the number
            //The program will then display both the number and the sum of its digits
            //Created by: Brandon Young
            //Last modified 2021-01-24 10:24PM

            //Assign 3 integer variables
            int inputNumber;
            int modulo1;
            int sum = 0;

            //Prompt user to enter a number
            Console.Write("Enter a three-digit whole number: ");

            //Parse input to an integer from string so it can be used in calculations
            inputNumber = int.Parse(Console.ReadLine());

            //Display the number input by the user before calculations are done
            Console.WriteLine("The integer is: " + inputNumber);

            //Calculate the sum of the 3 digits using modulo division
            while (inputNumber > 0)
            {
                modulo1 = inputNumber % 10;
                sum = sum + modulo1;
                inputNumber = inputNumber / 10;
            }

            //Output the sum of the 3 digits
            Console.Write("The sum of the 3 digits = " + sum);
        }
    }
}
