using System;

namespace Lab4_GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();
            int hidden = -2, guess = -1;
            String sExitAnswer;

            

            while (true)
            {
                try
                {
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.WriteLine("The Hidden Number Guessing Game");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.WriteLine("");

                    hidden = myRand.Next(100);
                   // Console.WriteLine(hidden);

                    do
                    {
                        do { Console.Write("Please guess a number between 0 - 100: "); }
                        while (!Int32.TryParse(Console.ReadLine().Trim(), out guess));
                        if (guess < 0)  { Console.WriteLine("Sorry, your guess " + guess + " was too low!"); Console.WriteLine(""); hidden = myRand.Next(100); }
                        else if (guess > 100) { Console.WriteLine("Sorry, your guess " + guess + " was too high!"); Console.WriteLine(""); hidden = myRand.Next(100); }
                    }
                    while ((guess < 0) || (guess > 100));

                    Console.WriteLine("");
                    Console.WriteLine((guess == hidden) ? "Winner!! Your guess " + guess + " was Correct!! You are a Winner!!" : "Sorry, your guess " + guess + " was Wrong!! The hidden number was "+hidden+"!!");

                    Console.Write("Would you like to play again? Enter 'Y' or 'Yes' to continue; Enter anyting else to Exit the program: ");
                    sExitAnswer = Console.ReadLine().ToLower().Trim();
                    if (("y".Equals(sExitAnswer)) || ("yes".Equals(sExitAnswer)))
                    {  Console.WriteLine(""); continue; }
                    else { Console.WriteLine(""); break; }
                }
                catch (Exception) { Console.WriteLine(""); continue; }
            }
        }
    }
}
