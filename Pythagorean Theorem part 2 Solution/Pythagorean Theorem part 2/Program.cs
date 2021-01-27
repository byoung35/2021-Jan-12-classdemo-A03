using System;

namespace Pythagorean_Theorem_part_2
{
    class Program
    {
        static void Main(string[] args)
        {//Pythagorean Theorem
         //declare 3 double variables
         //prompt and read number for height
         //prompt and read number for base
         //calculate hypotenuse
         //formula hypotenuse = squareroot(height squared + base squared)
         //display data



            double triangleHeight;
            double triangleBase;
            double hypotenuse;
            Console.Write("enter the triangle's height:\t");

            //declare and assign a value to a variable
            string inputTriangleHeight1 = Console.ReadLine();

            triangleHeight = double.Parse(inputTriangleHeight1);
            Console.Write("Enter the triangle's base:\t");


            string inputTriangleBase1 = Console.ReadLine();
            triangleBase = double.Parse(inputTriangleBase1);

            //Math.Sqrt calculates the square root
            //Math.Pow calculates a value raised to a specified power
            hypotenuse = Math.Sqrt(Math.Pow(triangleHeight, 2) + Math.Pow(triangleBase, 2));
            Console.WriteLine($"The hypotenuse of a triangle with a height of {triangleHeight}" + $" and a base of {triangleBase} is {hypotenuse}");
        }
    }
}
