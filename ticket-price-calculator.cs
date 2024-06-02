using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static string ticketPriceCalculator(int age)
        {
            if (age >= 65 || age <= 12)
            {
                return "GHC7";
            }
            else
            {
                return "GHC10";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");

            string input = Console.ReadLine();

            int age;
            if (int.TryParse(input, out age))
            {
                string ticketPrice = ticketPriceCalculator(age);
                Console.WriteLine("The ticket price is: " + ticketPrice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
