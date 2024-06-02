using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            const int regularPrice = 10;
            const int discountPrice = 7;
            int ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = discountPrice;
            }
            else
            {
                ticketPrice = regularPrice;
            }

            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}