using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of a triangle:");

        // Prompt and read side lengths
        Console.Write("Side 1: ");
        string input1 = Console.ReadLine();

        Console.Write("Side 2: ");
        string input2 = Console.ReadLine();

        Console.Write("Side 3: ");
        string input3 = Console.ReadLine();

        // Attempt to parse the user input
        if (double.TryParse(input1, out double side1) &&
            double.TryParse(input2, out double side2) &&
            double.TryParse(input3, out double side3))
        {
            // Check if the sides can form a valid triangle
            if (side1 > 0 && side2 > 0 && side3 > 0 &&
                side1 + side2 > side3 &&
                side1 + side3 > side2 &&
                side2 + side3 > side1)
            {
                string triangleType;

                // Determine the type of the triangle
                if (side1 == side2 && side2 == side3)
                {
                    triangleType = "Equilateral";
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    triangleType = "Isosceles";
                }
                else
                {
                    triangleType = "Scalene";
                }

                // Output the type of the triangle
                Console.WriteLine($"The triangle is: {triangleType}");
            }
            else
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numerical lengths for all sides.");
        }
    }
}