//Created by Margaret Binns

using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Initial set up.

        bool do_loop = true;
        List<int> numbers = new List<int>();
        int sum_of_numbers = 0;
        float average_of_numbers = 0;
        int max_of_numbers = 0;

        while (do_loop == true)
        {
            //Prompt the user for a number.

            Console.Write("Type a positive whole number or type 0 to quit. ");
            string user_number_string = Console.ReadLine();

            int user_number = Convert.ToInt32(user_number_string);

            //Append user_number to numbers List if not 0, otherwise exit loop.

            if (user_number != 0)
            {
                numbers.Add(user_number);
            }

            else
            {
                do_loop = false;
            }

        }


        //Compute the sum.

        foreach (int number in numbers)
        {
            sum_of_numbers += number;
        }

        //Find the average.

        average_of_numbers = ((float)sum_of_numbers) / numbers.Count;

        //find the max.

        foreach (int number in numbers)
        {
            if (number > max_of_numbers)
            {
                max_of_numbers = number;
            }
        }

        //Print the sum, average, and max.

        Console.WriteLine($"The sum is {sum_of_numbers}.\nThe average is {average_of_numbers}.\nThe max is {max_of_numbers}.");

    }
}
