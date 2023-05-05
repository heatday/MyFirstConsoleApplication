using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name:");
            string? name = Console.ReadLine();
            Console.WriteLine($"My name is {name}.");

            Console.WriteLine("Please enter your location:");
            string? location = Console.ReadLine();
            Console.WriteLine($"I am from {location}.");

            DateTime currentDate = DateTime.Today;
            Console.WriteLine($"The current date is {currentDate.ToString("MM/dd/yyyy")}.");

            DateTime christmas = new DateTime(currentDate.Year, 12, 25);
            int daysUntilChristmas = (christmas - currentDate).Days;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas.");

            //add code from 2.1 example
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter the width of the window in feet: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the height of the window in feet: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height) * 0.09290304;

            Console.WriteLine("The length of the wood is " +
                              woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
                  Math.Round(glassArea, 2) + " square meters");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

