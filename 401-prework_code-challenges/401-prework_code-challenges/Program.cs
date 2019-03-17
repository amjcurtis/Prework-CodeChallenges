using System;

namespace _401_prework_code_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 401 prework code challenges!");
            Console.WriteLine(" ");

            // Call method for challenge 1
            //ScoreGame();

            // Call method for challenge 2
            CalculateLeapYear();

            // Call method for challenge 3
            TestForPerfectSequence();

            // Call method for challenge 4
            GetSumOfRows();

            Console.ReadLine();
        }

        
        ///////////////////////////////////////
        // Solution for challenge 1
        ///////////////////////////////////////
        
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
            // Console.WriteLine($"stringArray: {stringArray}");

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

            Console.WriteLine(" ");
        }


        ///////////////////////////////////////
        // Solution for challenge 2
        ///////////////////////////////////////
        
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
                else
                {
                    Console.WriteLine("The year you entered is a leap year!");
                }
            }
            else
            {
                Console.WriteLine("The year you entered isn't a leap year.");
            }
            Console.WriteLine(" ");
        }


        ///////////////////////////////////////
        // Solution for challenge 3
        ///////////////////////////////////////

        private static void TestForPerfectSequence()
        {
            Console.WriteLine("Enter a list of non-negative integers to see if they are a perfect sequence. " + 
                "(The numbers must be separated by commas with no spaces in between.)");

            // Get user input
            string userInput = Console.ReadLine();

            // Turn user input into a string array
            string[] stringArray = userInput.Split(",");
            
            // Declare empty integer array of length of user's string array
            int[] intArray = new int[stringArray.Length]; 

            // Populate integer array with numbers from user's string array (after converting them from strings to ints)
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }

            // Set counters
            int productOfElements = 1;
            int sumOfElements = 0;

            // Calculate product and sum of array elements
            for (int i = 0; i < intArray.Length; i++)
            {
                productOfElements *= intArray[i];
                sumOfElements += intArray[i];
            }

            // Test for perfect sequence
            if (productOfElements == sumOfElements)
            {
                Console.WriteLine("The numbers you entered are a perfect sequence!");
            } else
            {
                Console.WriteLine("The numbers you entered are not a perfect sequence.");
            }

            Console.WriteLine(" ");
        }


        ///////////////////////////////////////
        // Solution for challenge 4
        ///////////////////////////////////////

        private static void GetSumOfRows()
        {
            Console.WriteLine("Let's create a multidimensional array and sum its rows!");

            // Get number for m (row) dimension of matrix from user
            Console.WriteLine("Enter a positive integer for the number of rows you want in the array.");
            string mDimensionAsString = Console.ReadLine();
            int mDimensionAsInt = int.Parse(mDimensionAsString);
            Console.WriteLine($"Thanks! You entered {mDimensionAsInt}");
            Console.WriteLine($" ");

            // Get number for n (column) dimension of matrix from user
            Console.WriteLine("Enter a positive integer for the number of columns you want in the array.");
            string nDimensionAsString = Console.ReadLine();
            int nDimensionAsInt = int.Parse(nDimensionAsString);
            Console.WriteLine($"Thanks! You entered {nDimensionAsInt}");
            Console.WriteLine($" ");

            // Declare empty array based on dimensions input by user
            int[,] userArray = new int[mDimensionAsInt, nDimensionAsInt];

            // Populate matrix with random numbers
            Random newRandNum = new Random();
            for (int i = 0; i < userArray.GetLength(0); i++)
            {
                for (int j = 0; j < userArray.GetLength(1); j++)
                {
                    userArray[i, j] = newRandNum.Next(1,10);
                }
            }

            // Take initialized matrix and sum its rows
            sumRows(userArray);
        }

        // Helper function that takes array as param and sums row(s)
        private static void sumRows(int[,] array)
        {
            int total = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    total += array[i, j];
                }
            }
            Console.WriteLine($"The sum of all the elements in your multidimensional array is {total}");
        }
    }
}
