using System;

namespace DailyInterviewQuestion_MakingChange
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "";
            Random rnd = new Random();
            while (!exit.Equals("x"))
            {
                int intPrice = rnd.Next(1, 100);
                decimal price = (decimal)intPrice / 100.00M + rnd.Next(10);
                int tendered = rnd.Next((int)price + 1, (int)price +1+ rnd.Next(5));
                string change = MakingChange(tendered - price);
                Console.WriteLine(change);
                Console.Write("Type x to stop ");
                exit = Console.ReadLine();
            }
        }

        static string MakingChange(decimal change)
        {
            decimal myChange = change;
            int quarters = 0, dimes = 0, nickels = 0, pennies = 0;
            string changeStr = "Change due:";
            while(myChange>=(decimal).25)
            {
                myChange -= (decimal).25;
                quarters++;
            }

            while(myChange >= (decimal).10)
            {
                myChange -= (decimal).10;
                dimes++;
            }

            while(myChange>=(decimal).05)
            {
                myChange -= (decimal).05;
                nickels++;
            }

            while(myChange>=(decimal).01)
            {
                myChange -= (decimal).01;
                pennies++;
            }

            if(quarters>0)
            {
                changeStr +=" "+ quarters + " Quarters";
            }
            if (dimes>0)
            {
                changeStr += " " + dimes + " Dimes";
            }
            if(nickels>0)
            {
                changeStr += " " + nickels + " Nickels";
            }
            if(pennies>0)
            {
                changeStr += " " + pennies + " Cents";
            }
            return changeStr;
        }
    }
}
