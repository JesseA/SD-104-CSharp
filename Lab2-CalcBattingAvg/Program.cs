/*
 Project:       Lab 2 Calculate Batting Average
 Date:
 Author:
 Notes: The program reads in a baseball player's name, number of hits, and number at bats.
 The player's batting average is calculated and displayed.
 */
using System;

namespace Lab2_CalcBattingAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            String sPlayerName;
            double nHits, nAtBats;
            double dBattingAverage;

            //user prompt
            Console.WriteLine("This program calculates a basebal player's batting average");
            Console.WriteLine("Enter 'Exit' as the  player name to end the program");
            Console.WriteLine("<-------------------------------------------------------->");
            while(true)
            {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Please enter the player's name: ");
            sPlayerName=Console.ReadLine();
            if(sPlayerName.ToLower()=="exit")
                {
                    System.Environment.Exit(0);
                }
                else { 
            Console.Write("Please enter "+sPlayerName+"'s number of hits: ");
            nHits = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter " + sPlayerName + "'s number at bats: ");
            nAtBats= Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("");

             Console.WriteLine("Player Name: "+sPlayerName);
            Console.WriteLine(sPlayerName+"'s Number of Hits: "+nHits);
            Console.WriteLine(sPlayerName + "'s Number at Bats: " + nAtBats);
            dBattingAverage = nHits / nAtBats;
            Console.WriteLine(sPlayerName + "'s Batting Average: " + dBattingAverage);
                }
            }

        }
    }
}
