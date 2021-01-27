using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            int FahrenheitTemp = 75;
            int CelsiusTemp = 0;

            Console.Write("Enter a Fahrenheit temperature: ");
            FahrenheitTemp = int.Parse(Console.ReadLine());
            

            CelsiusTemp = (FahrenheitTemp - 32) * 5 / 9;

            if (CelsiusTemp < 0)
            {
                Console.WriteLine("It's freezing outside.");

            }
            else if(CelsiusTemp < 15)
            {
                Console.WriteLine("Wear a jacket.");
            }
            else if(CelsiusTemp < 30)
            {
                Console.WriteLine("It's a lovely day.");
            }
            else
            {
                Console.WriteLine("It's finally summer.");
            }




















        }
    }
}
