using System;

namespace _401_prework_code_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 401 prework code challenges!");

            // Call method for challenge 1
            // ScoreGame();

            // Call method for challenge 2
           // CalculateLeapYear();
            // Call method for challenge 3

            // Call method for challenge 4

            Console.ReadLine();

        }
        
        // Solution for challenge 1
        private static void ComputeScore(int[] chosenArray, int chosenNumber)
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
            Console.WriteLine($"Your score is {score}!");
        }

        private static void ScoreGame()
        {
            // Get user's numbers to include in array
            Console.WriteLine("Enter a list of five numbers separated by commas (with no spaces in between).");

            string userNumbers = Console.ReadLine();

            // Print user's selected array of five numbers to console
            Console.WriteLine($"You selected these numbers: {userNumbers}");

            // Arrayify the five numbers
            string[] stringArray = userNumbers.Split(",");

            int[] arrayifiedNumbers = new int[5];

            arrayifiedNumbers[0] = int.Parse(stringArray[0]);
            arrayifiedNumbers[1] = int.Parse(stringArray[1]);
            arrayifiedNumbers[2] = int.Parse(stringArray[2]);
            arrayifiedNumbers[3] = int.Parse(stringArray[3]);
            arrayifiedNumbers[4] = int.Parse(stringArray[4]);

            // Prompt user to select a number from the array
            Console.WriteLine("Enter a number of your choice from among the five numbers you entered.");
            int numberChoice = int.Parse(Console.ReadLine());

            ComputeScore(arrayifiedNumbers, numberChoice);
        }

        // Solution for challenge 2
        private static void CalculateLeapYear()
        {
            Console.WriteLine("Enter a year to see if it's a leap year.");

            string userGuess = Console.ReadLine();

            int userGuessToInt = int.Parse(userGuess);

            if (userGuessToInt % 4 == 0)
            {
                if (userGuessToInt % 100 == 0)
                {
                    if (userGuessToInt % 400 == 0)
                    {
                        Console.WriteLine("The year you entered is a leap year!");
                    }
                    else
                    {
                        Console.WriteLine("The year you entered isn't a leap year.");
                    }
                }
            } else
            {
                Console.WriteLine("The year you entered isn't a leap year.");
            }

            Console.ReadLine();
        }

        // Solution for challenge 3

        // Solution for challenge 4

    }
}
