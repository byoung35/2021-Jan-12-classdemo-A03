using System;

namespace GreaterOrLessThan0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1.
            //declare a double variable
            //declare a string variable for user input
            //Prompt and read value for user input
            //Convert user input value into double variable
            //Declare an if statement as following
            /*if the number is != to 0
             * if the number is < 0
             *      Display that number is negative
             * else
             *      Display that number is positive
             *else
             *  if the number is == 0
             *      Display that number is == 0
             */

            //double number;
            //string userInput;
            //Console.WriteLine("Enter a number:\t");
            //userInput = Console.ReadLine();

            //number = double.Parse(userInput);

            //if (number != 0)
            //{
            //    if (number < 0)
            //    {
            //        Console.WriteLine($"{number} is negative.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is positive.");
            //    }
            //}
            //else
            //{
            //if (number == 0)
            //{
            //Console.WriteLine($"{number} is zero");
            //}
            //}






            //Question 2.
            //declare int variable
            //declare 4 double variables
            //declare string for user input
            //convert user input value into int variable
            //declare an if statement as following

            /* if customerAge <= 6
             *      Display childPrice
             * else if customerAge <= 17
             *      Display studentPrice
             * else if customerAge <= 54
             *      Display adultPrice
             * else
             *      Display seniorPrice
             */

            //int customerAge;
            //double childPrice = 0.00;
            //double studentPrice = 9.80;
            //double adultPrice = 11.35;
            //double seniorPrice = 10.00;
            //string userInput;

            //Console.WriteLine("What is your age?\t");
            //userInput = Console.ReadLine();

            //customerAge = int.Parse(userInput);

            //if (customerAge <= 6)
            //{
            //    Console.WriteLine($"Your admission fee is: ${childPrice}");
            //}
            //else if (customerAge <= 17)
            //{
            //    Console.WriteLine($"Your admission fee is: ${studentPrice}");
            //}
            //else if (customerAge <= 54)
            //{
            //    Console.WriteLine($"Your admission fee is: ${adultPrice}");
            //}
            //else
            //{
            //    Console.WriteLine($"Your admission fee is: ${seniorPrice}");
            //}


            //Question 3.
            //declare string variable for user input for grade
            //declare string variable for user input for name
            //declare double variable for grade
            //if statement as follows
            /*if (grade >= 90)
             *      Display name with A grade
             *else if (grade >= 80)
             *      Display name with B grade
             *else if (grade >= 70)
             *      Display name with C grade
             *else if (grade >= 50)
             *      Display name with D grade
             *else
             *      Display name with F grade
             */

            //string userName;
            //string userGrade;
            //double Grade;

            //Console.WriteLine("Enter your name: ");
            //userName = Console.ReadLine();

            //Console.WriteLine("Enter your test score: ");
            //userGrade = Console.ReadLine();
            //Grade = double.Parse(userGrade);

            //if (Grade >= 90)
            //{
            //    Console.WriteLine($"{userName} your grade is an A");
            //}
            //else if (Grade >= 80)
            //{
            //    Console.WriteLine($"{userName} your grade is an B");
            //}
            //else if (Grade >= 70)
            //{
            //    Console.WriteLine($"{userName} your grade is an C");
            //}
            //else if (Grade >= 50)
            //{
            //    Console.WriteLine($"{userName} your grade is an D");
            //}
            //else
            //{
            //    Console.WriteLine($"{userName} your grade is an F");
            //}



            //Question 4.
            //declare string variable for user input
            //convert user input into double variable
            //declare 4 double variables
            //if statement as follows
            /*if (incomeAmount <= 50000)
             *      Display lowTaxDue
             *else if (incomeAmount <= 100000)
             *      Display mediumTaxDue
             *else
             *      Display highTaxDue
             */

            //string userInput;
            //double incomeAmount;

            //Console.WriteLine("Enter your income amount:\t");
            //userInput = Console.ReadLine();
            //incomeAmount = double.Parse(userInput);

            //double taxLow = 0.00 + (0.05 * incomeAmount);
            //double taxMedium = 2500 + (0.07 * (incomeAmount - 50000));
            //double taxHigh = 6000 + (0.09 * (incomeAmount - 100000));

            //if (incomeAmount <= 50000)
            //{
            //    Console.WriteLine($"Your income tax due is: ${Math.Round(taxLow, 2)}.");
            //}
            //else if (incomeAmount <= 100000)
            //{
            //    Console.WriteLine($"Your income tax due is: ${Math.Round(taxMedium, 2)}.");
            //}
            //else
            //    Console.WriteLine($"Your income tax due is: ${Math.Round(taxHigh, 2)}.");
        }
    }
}
