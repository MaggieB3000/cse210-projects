/*. 
Created by Margaret Binns
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        //Game intro.

        Console.WriteLine("This is a \'guess the number\' game. You try to guess a random number in the smallest number of attempts.\n");

        //Difficulty selection.

        Console.Write("What difficulty do you want? \nChoose how big you want the range to be (must be an positive whole number): ");

        string max_value_string = Console.ReadLine();

        int max_value = Convert.ToInt32(max_value_string);

        int max_value_random = max_value + 1;

        //Generate a number between 1 and the max_value.

        Random randomGenerator = new Random();

        int value_random = randomGenerator.Next(1,max_value_random);

        //Game set up.

        bool game_loop = true;
        int number_of_guesses = 0;

        //Game loop.

        while (game_loop == true)
        {
            //Prompt for a guess.

            Console.Write($"\nGuess a number between 1 and {max_value}!\nType your answer here: ");

            string user_guess_string = Console.ReadLine();

            int user_guess = Convert.ToInt32(user_guess_string);

            number_of_guesses++;

            //Make decision.

            if (user_guess > value_random)
            {
                Console.WriteLine("Too high!");
            }

            else if (user_guess < value_random)
            {
                Console.WriteLine("Too Low!");
            }

            else
            {
                Console.WriteLine($"You got it! The answer was {value_random}! It took you {number_of_guesses} tries to guess the number!");

                game_loop = false;
            }
        }
        

    }
}