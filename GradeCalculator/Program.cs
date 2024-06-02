using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a numerical grade between 0 and 100:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                string letterGrade;

                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                Console.WriteLine($"You had a {letterGrade}");
            }
            else
            {
                Console.WriteLine("The grade entered is out of the valid range (0-100).");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
        }
    }
}