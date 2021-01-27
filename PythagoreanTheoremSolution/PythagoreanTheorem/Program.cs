using System;

namespace PythagoreanTheorem
    
    
    
    /*This program asks the user for 3 real number inputs and returns the average of the 3 numbers back to the user.
     * This program uses Console.ReadLine() to get input from the user to assign to the matching variable name
     * 
     * 
     * This program was created by: Brandon Young
     * Last edited on: 2021/01/19 6:47PM
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 real numbers to get the average of the inputs rounded to 2 decimal points.");
            Console.Write("Enter the first number: ");
            string firstInput;
            firstInput = Console.ReadLine();
            double firstNumberInput = double.Parse(firstInput);

            Console.Write("Enter the second number: ");
            string secondInput;
            secondInput = Console.ReadLine();
            double secondNumberInput = double.Parse(secondInput);

            Console.Write("Enter the third number: ");
            string thirdInput;
            thirdInput = Console.ReadLine();
            double thirdNumberInput = double.Parse(thirdInput);

            double averageNumber = (firstNumberInput + secondNumberInput + thirdNumberInput) / 3.0;
            double roundedNumber;
            roundedNumber = Math.Round(averageNumber, 2);
            Console.WriteLine($"The average of the 3 numbers is: " + $"{roundedNumber}");
            
            
            
        }
    }
}
