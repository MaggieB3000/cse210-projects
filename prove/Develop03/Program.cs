using System;


class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedTextScripture());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideWords(3); // Hide 3 words at a time

            if (scripture.IsCompletelyHidden())
                break;
        }
    }


}