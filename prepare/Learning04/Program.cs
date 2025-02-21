using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Peggy", "Science");

        WritingAssignment assignment2 = new WritingAssignment("Peggy", "English", "1.5", "1-5");

        MathAssignment assignment3 = new MathAssignment("Peggy", "English", "Math for the Real World");


        string assignment1string = assignment1.GetSummary();
        string assignment2string = assignment2.GetHomeworkList();
        string assignment3string = assignment3.GetWritingInfo();

        Console.WriteLine($"{assignment1string}\n{assignment2string}\n{assignment3string}");
    }
}