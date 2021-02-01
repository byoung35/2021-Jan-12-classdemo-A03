using System;

namespace DecisionMakingExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            char servicePackage;
            double hoursUsed;
            double costPackageA;
            double costPackageB;
            double costPackageC;

            string inputPackage;
            Console.WriteLine("Which service package do you have: A, B, or C\t");
            inputPackage = Console.ReadLine();
            servicePackage = char.Parse(inputPackage);

            string inputTemp;
            Console.WriteLine("How many hours have you used the ISP?\t");
            inputTemp = Console.ReadLine();
            hoursUsed = double.Parse(inputTemp);

            costPackageA = 9.95 + (2 * (hoursUsed - 10));
            costPackageB = 13.95 + (1 * (hoursUsed - 20));
            costPackageC = 19.95;

            switch (servicePackage)
            {
                case 'A':
                    if (hoursUsed > 10)
                    {
                        Console.WriteLine($"Your bill this month is ${costPackageA}.");
                    }
                    else
                    {
                        Console.WriteLine("Your bill this month is $9.95.");
                    }
                    break;

                case 'B':
                    if (hoursUsed > 20)
                    {
                        Console.WriteLine($"Your bill this month is ${costPackageB}");
                    }
                    else
                    {
                        Console.WriteLine("Your bill this month is 13.95");
                    }
                    break;
                case 'C':
                    Console.WriteLine($"Your bill this month is ${costPackageC}");
                    break;
                default:
                    Console.WriteLine("That's not a valid package we have. Please pick between packages A, B, and C.");
                    break;



            }
        }
    }
}
