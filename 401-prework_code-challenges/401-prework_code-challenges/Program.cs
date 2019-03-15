using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _401_prework_code_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 401 prework code challenges!");
            // Console.ReadLine();

            // Call method for challenge 1
            ScoreGame();

            // Call method for challenge 2

            // Call method for challenge 3

            // Call method for challenge 4

        }

        // Solution for challenge 1

        private static int ComputeScore(int[] chosenArray, int chosenNumber)
        {

            // Multiply selected number by number of times it occurs in the array
            int count = 0;
            foreach (int number in chosenArray)
            {
                if (number == chosenNumber)
                {
                    count++;
                }
            }

            int score = count * chosenNumber;

            // Print the "score" to the console
            return Console.WriteLine($"Your score is {score}!");
        }

        private static string ScoreGame()
        {
            // Get user's numbers to include in array
            Console.WriteLine("Welcome! Enter a list of five numbers separated by commas.");

            // Arrayify the five numbers
            int[] arrayifiedNumbers = new int[5] { Console.ReadLine() };

            // Print user's selected array of five numbers to console
            Console.WriteLine($"You selected these numbers: {arrayifiedNumbers}");

            // Prompt user to select a number from the array
            Console.WriteLine("Enter a number of your choice from among the five numbers you entered.");
            int numberChoice = Console.ReadLine();

            return ComputeScore(arrayifiedNumbers, numberChoice);
        }

        // Solution for challenge 2

        // Solution for challenge 3

        // Solution for challenge 4

    }
}
