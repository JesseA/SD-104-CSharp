using System;

namespace HW4_Alternates
{
    class Program
    {
        static void Main(string[] args)
        {   
            //1. Fantasy Football Score
            double passingYards = 0, rushingYards = 0, receivingYards = 0, fantasyScore=0;
            int passingTDs = 0, passingIntercepts = 0, rushingTDs = 0, receptions = 0, receivingTDs = 0;

            Console.WriteLine("<------ |Part 1| Welcome to the Fantasy Football Scoring Program ------>");
            do
            {
                Console.WriteLine("Please enter your football team's passing yards: ");
            }
            while (!double.TryParse(Console.ReadLine(), out passingYards));
            fantasyScore += (passingYards / 25);

            do
            {
                Console.WriteLine("Please enter your football team's passing touchdowns: ");
            }
            while (!int.TryParse(Console.ReadLine(), out passingTDs));
            fantasyScore += (4 * passingTDs);

            do
            {
                Console.WriteLine("Please enter your football team's passing interceptions: ");
            }
            while (!int.TryParse(Console.ReadLine(), out passingIntercepts));
            fantasyScore += (-2 * passingIntercepts);

            do
            {
                Console.WriteLine("Please enter your football team's rushing yards: ");
            }
            while (!double.TryParse(Console.ReadLine(), out rushingYards));
            fantasyScore += (rushingYards / 10);

            do
            {
                Console.WriteLine("Please enter your football team's rushing touchdowns: ");
            }
            while (!int.TryParse(Console.ReadLine(), out rushingTDs));
            fantasyScore += (6 * rushingTDs);

            do
            {
                Console.WriteLine("Please enter your football team's receptions: ");
            }
            while (!int.TryParse(Console.ReadLine(), out receptions));
            fantasyScore += receptions;

            do
            {
                Console.WriteLine("Please enter your football team's receiving yards: ");
            }
            while (!double.TryParse(Console.ReadLine(), out receivingYards));
            fantasyScore += (receivingYards / 10);

            do
            {
                Console.WriteLine("Please enter your football team's receiving touchdowns: ");
            }
            while (!int.TryParse(Console.ReadLine(), out receivingTDs));
            fantasyScore += (6 * receivingTDs);

            Console.WriteLine("");
            Console.Write("Your team's fantasy score is ");
            Console.WriteLine(fantasyScore);
            Console.WriteLine("");

            //Quarterback rating
            double a, b, c, d, yds, passerRating;
            int att, comp, td, inter;

            Console.WriteLine("<------ |Part 2| Welcome to the Quarterback Rating Program ------>");
            do
            {
                Console.WriteLine("Please enter the quarterback's number of passing completions: ");
            }
            while (!int.TryParse(Console.ReadLine(), out comp));

            do
            {
                do
                {
                    Console.WriteLine("Please enter the quarterback's number of passing attempts (non-zero): ");
                }
                while (!int.TryParse(Console.ReadLine(), out att));
            } while (att == 0);

            a = ((comp / att) - .3) * 5;

            if(a>2.375) { a = 2.375; }
            else if(a<0) { a = 0; }

            do
            {
                Console.WriteLine("Please enter the quarterback's number of passing yards: ");
            }
            while (!double.TryParse(Console.ReadLine(), out yds));

            b = ((yds / att) - 3) / 4;

            if (b > 2.375) { b = 2.375; }
            else if (b < 0) { b = 0; }

            do
            {
                Console.WriteLine("Please enter the quarterback's number of touchdown passes: ");
            }
            while (!int.TryParse(Console.ReadLine(), out td));

            c = (td / att) * 20;
            if (c > 2.375) { c = 2.375; }
            else if (c < 0) { c = 0; }

            do
            {
                Console.WriteLine("Please enter the quarterback's number of interceptions: ");
            }
            while (!int.TryParse(Console.ReadLine(), out inter));

            d = 2.375 - ((inter / att) * 25);
            if (d > 2.375) { d = 2.375; }
            else if (d < 0) { d = 0; }


            passerRating = ((a + b + c + d) / 6) * 100;

            Console.WriteLine("");
            Console.Write("Your quarterback's passer score is ");
            Console.WriteLine(passerRating);
            Console.WriteLine("");

            //binary equivalent 
            int userInt;
            byte[] myBits=new byte[32];
            byte[] myBitsRev = new byte[32];
            Console.WriteLine("<------ |Part 3| Welcome to the Binary Equivalent Program ------>");
            do
            {
                do
                {
                    Console.Write("Please enter a non-negative integer to display the binary representation for: ");
                }
                while (!int.TryParse(Console.ReadLine(), out userInt));
            } while (userInt < 0);

            for (int i = 31; i >-1; i--)
            {
                //Console.WriteLine(Math.Pow(2, i));
                myBits[i] = 0;
                if(userInt>=(Math.Pow(2,i)))
                {

                    myBits[i] = 1;
                    userInt -= (int)(Math.Pow(2, i));
                }
            }

            int bitCounter = 31;
            foreach(byte myBit in myBits)
            {
                myBitsRev[bitCounter] = myBit;
                bitCounter--;
            }


            bool whiteSpace = false;
            foreach (byte myBit in myBitsRev)
            {
                if(!whiteSpace)
                {
                    if(myBit==1)
                    {
                        whiteSpace = true;
                    }
                }

                if (whiteSpace)
                { Console.Write(myBit + " "); }
            }
            if(!whiteSpace) { Console.Write(0); }
            Console.WriteLine("");


            Console.ReadLine();

        }
    }
}
