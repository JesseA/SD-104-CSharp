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

            bool QuartLast=false,DimesLast = false, NickelsLast = false;
            int numOfTerms = 0;


            //Make Quarters
            while (myChange>=(decimal).25)
            {
                myChange -= (decimal).25;
                quarters++;
            }
            
            if(quarters>0)
            {
                QuartLast = true;
                numOfTerms++;
            }

            //Make Dimes
            while(myChange >= (decimal).10)
            {
                myChange -= (decimal).10;
                dimes++;
            }
            if (dimes > 0)
            {
                DimesLast = true;
                QuartLast = false;
                numOfTerms++;
            }

            //Make Nickels
            while (myChange>=(decimal).05)
            {
                myChange -= (decimal).05;
                nickels++;
            }
            if (nickels > 0)
            {
                NickelsLast = true;
                QuartLast = false;
                DimesLast = false;
                numOfTerms++;
            }

            //make Pennies
            while (myChange>=(decimal).01)
            {
                myChange -= (decimal).01;
                pennies++;
            }
            if (pennies > 0)
            {

                NickelsLast = false;
                QuartLast = false;
                DimesLast = false;
                numOfTerms++;
            }

            //add quarters
            if (quarters>0)
            {
                changeStr +=" "+ quarters + " Quarter";
                if(quarters>1) {changeStr += "s";}
                if (QuartLast) { changeStr += "."; }
            }

            //add dimes
            if (dimes>0)
            {
                if(numOfTerms>2&&quarters>0) { changeStr += ","; }
                if(numOfTerms>1&&DimesLast) { changeStr += " and"; }
                changeStr += " " + dimes + " Dime";
                if (dimes>1) { changeStr += "s"; }
                if (DimesLast) { changeStr += "."; }
            }
            //add nickels
            if(nickels>0)
            {
                if (numOfTerms>2&&(quarters > 0||dimes>0)) { changeStr += ","; }
                if (numOfTerms > 1 && NickelsLast) { changeStr += " and"; }
                changeStr += " " + nickels + " Nickel";
                if (nickels>1) { changeStr += "s"; }
                if (NickelsLast) { changeStr += "."; }
            }
            //add pennies
            if(pennies>0)
            {
                if (numOfTerms>2&&(quarters > 0 || dimes > 0||nickels>0)) { changeStr += ","; }
                if (numOfTerms > 1) { changeStr += " and"; }
                changeStr += " " + pennies + " Cent";
                if (pennies>1) { changeStr += "s"; }
                changeStr += ".";
            }
            return changeStr;
        }
    }
}
