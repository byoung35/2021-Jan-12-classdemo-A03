using System;

namespace DecisionStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            double score1, score2, score3, average;

            //Prompt and read in the first test score.
            Console.WriteLine("Enter score #1: ");
            score1 = double.Parse(Console.ReadLine());

            //Promt and read in the second test score.
            Console.WriteLine("Enter score #2: ");
            score2 = double.Parse(Console.ReadLine());

            //Prompt and read in the third test score.
            Console.WriteLine("Enter score #3: ");
            score3 = double.Parse(Console.ReadLine());

            //Calculate the average score.
            average = (score1 + score2 + score3) / 3.0;
            //Display the average score.
            Console.WriteLine($"The average is: {average}");

            //Congratulate user if high average
            if (average > 95)
                Console.WriteLine("That's a great average!");
        }
    }
}
