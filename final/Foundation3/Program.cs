using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Advanced Crochet Plushies", "Learn how to level up your crochet plushy skills.", "4/2/2025", "12:30 PM", "Rando Address", "Lecture", "Yarn-Woman", "25");

        Console.WriteLine(lecture.ShortDetails());
        Console.WriteLine("");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine("");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine("");

        Reception reception = new Reception("Magic_Woman's funeral", "Come celebrate the life of Magic_Woman and all she did to protect the universe from evil.", "4/8/24", "6:45 PM", "Some rando church", "Reception", "phoneyemail@mail.com");

        Console.WriteLine(reception.ShortDetails());
        Console.WriteLine("");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine("");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine("");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Figure Drawing Class", "Gather in the great outdoors to study Pencil Woman and her drawing abilities.", "3/5/23", "12:00 AM", "Top of a rando mountain", "Outdoor Gathering", "Torential Downpour");

        Console.WriteLine(outdoorGathering.ShortDetails());
        Console.WriteLine("");
        Console.WriteLine(outdoorGathering.StandardDetails());
        Console.WriteLine("");
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine("");
    }
}