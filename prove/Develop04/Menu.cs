using System;
using System.Collections.Generic;
using System.Threading;

class Menu
{
    public void Run()
    {
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            DisplayMenu();

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Breathing breathingActivity = new Breathing();
                    breathingActivity.RunActivity();
                    break;

                case "2":
                    Reflections reflectionActivity = new Reflections();
                    reflectionActivity.RunActivity();
                    break;

                case "3":
                    Listing listingActivity = new Listing();
                    listingActivity.RunActivity();
                    break;

                case "4":
                    quit = true;
                    Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness App\n\nMenu Options:\n\n1. Start breathing activity\n2. Start reflection activity\n3. Start listing activity\n4. Quit\n\nSelect a choice from the menu: ");
    }
}