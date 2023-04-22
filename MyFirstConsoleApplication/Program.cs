using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Please enter your location:");
            string? location = Console.ReadLine();

            Console.WriteLine($"Hello my name is {name}.");
            Console.WriteLine($"I am from {location}.");

            DateTime currentDate = DateTime.Today;
            Console.WriteLine($"The current date is {currentDate.ToString("MM/dd/yyyy")}.");

            DateTime christmas = new DateTime(currentDate.Year, 12, 25);
            int daysUntilChristmas = (christmas - currentDate).Days;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas.");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
