using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        string x = Console.ReadLine();
        int grade_percent = int.Parse(x);

        string letter = "";

        if (grade_percent >= 90)
        {
            letter = "A";
        }

        else if (grade_percent >= 80)
        {
            letter = "B";
        }

        else if (grade_percent >= 70)
        {
            letter = "C";
        }

        else if (grade_percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine ($"Your grade is: {letter}");

        if (grade_percent >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Better luck next time!");
        }



    }
}