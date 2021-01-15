using System;

namespace ArithmeticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //The special character \n adds an extra blank line
            //It is called the 'next line' character
            Console.WriteLine("Arithmetic Samples\n");

            //declare a variable of datatype double
            //syntax; datatype variablename assignment operator literal numeric value;
            //         double    Total               =                           0.0;
            double Total = 0.0;
            double Cost = 15.23;
            double Tax = 0.81;

            //arithmetic assignment operation
            //syntax;   receiving variable    assignment operator     binary arithmetic expression (Addition+)
            //                    Total             =                     Cost + Tax;

            //action: the expression will be executed and the results will be placed into the receiving variable
            Total = Cost + Tax;

            Console.WriteLine($"The result of {Cost} + {Tax} is {Total}");

            //An alternate way of outputting your variables will be to use a string concatenation.
            //String concatenation uses the operator + 
            Console.WriteLine("The result of " + Cost + " + " + Tax + " is " + Total);

            //An alternate way is to use placeholders
            //Placeholders start at 0 and increment by 1
            //Placeholder value are in a list after the string
            //ORDER IS IMPORTANT
            Console.WriteLine("The result of {0} + {1} is {2}",Cost,Tax,Total);

        }
    }
}
