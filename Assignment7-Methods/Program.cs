using System;

namespace Assignment7_Methods
{
    class Program
    {

        static int userNumber, hiddenNumber, numberOfGuesses;
        static bool playAgain, found;
        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            hiddenNumber = random.Next(min, max);
            return hiddenNumber;
        }

        private static int RequestNumber()
        {
            int req;
            bool valid = false;
            do
            {
                Console.Write("Please Guess a Number: ");
                if(Int32.TryParse(Console.ReadLine(), out req))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input Detected...");
                }
            }while(!valid);
            userNumber = req;
            return req;
        }

        private static void CompareGuess()
        {
            if(userNumber==hiddenNumber)
            {
                Console.WriteLine("You guessed the hidden number "+hiddenNumber+" correctly!! You took "+numberOfGuesses+" guesses to get the answer!");
                Console.WriteLine("");
                Console.Write("Would you like to play again? Enter 'Y' or 'Yes' to continue playing...");
                string ans = Console.ReadLine().Trim().ToUpper();
                found = true;
                playAgain = (ans=="Y"||ans=="YES");
            }
            else if(userNumber<hiddenNumber)
            {
                Console.WriteLine("Your guess " + userNumber + " was too low.");
            }
            else if(userNumber>hiddenNumber)
            {
                Console.WriteLine("Your guess " + userNumber + " was too high.");
            }
        }

        static void Main(string[] args)
        {
            int hiddenNumber;
            int userGuess;

           
            do
            {

                Console.WriteLine("--------- Guess the hidden number between 1 and 100 ---------");
                playAgain = false;
                found = false;
                numberOfGuesses = 0;
                hiddenNumber = RandomNumber(0, 100);

                while (!found)
                {
                    userGuess = RequestNumber();
                    numberOfGuesses++;
                    CompareGuess();
                    Console.WriteLine("");
                }

            } while (playAgain);
        }
    }
}
