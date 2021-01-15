using System;

namespace InputOutputMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement a temperature converter from
             * Celcius to Fahrenheit
             * 
             * Jan 2021
             */


            //Input: Celcius temperature
            //      string  inputTemp
            //      double theCelciusTemperature

            //output: Fahrenheit temperature
            //       double theFahrenheitTemperature

            //expression (calculate): (ct * (9.0/5.0)) + 32
            //check with ct = 0 expect ft = 32
            // check withct = 100 expect ft = 212
            //check with ct = -40 expect ft = -40

            //prompt for a celcius temperature
            // .Write() keeps your cursor on the same line
            Console.Write("Enter a Celcius Temperature: ");

            //How does the program pull in the entry from the user
            //to obtain the key strokes that the user types (input)
            // .ReadLine()
            //important!!!
            // data comes into the program as a string
            // DOES NOT matter if you enter a number, it is treated as a string

            //declare the variable:     datatype variablename;
            string inputTemp;
            //assignment statement:     expression on the right is placed into the variable on the left
            //expression (action):      read the user input
            inputTemp = Console.ReadLine();

            //you could do both statements on one line

            //currently the celcius value is a string
            //the value needs to be converted to a number to be used in a math calculation
            //convert the data into a different data type
            //to do this; you will use a technique called parsing
            // syntax:  datatypeTo.Parse(string value)

            //WARNING: I am assuming the user will enter valid data
            //If the user doesnt enter a number, this program will abort on the execution of this line
            double theCelciusTemperature = double.Parse(inputTemp);

            //calculation using the conversion expression
            double theFahrenheitTemperature =
                (theCelciusTemperature * (9.0 / 5.0)) + 32;

            //output
            // .WriteLine() which automatically goes to the next line.
            Console.WriteLine($"The Celcius temperature of {theCelciusTemperature} is "
                + 
                    $"{theFahrenheitTemperature} in fahrenheit");

        }
    }
}
