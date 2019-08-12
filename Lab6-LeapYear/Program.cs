using System;

namespace Lab6_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            bool bExtitCondition = true;
            int nYear = 2019;
            bool bIsDiv4 = false, bIsDiv100 = false, bIsDiv400=false;

            do {
                try {
                    do { Console.Write("Please Enter a Year to see if it was or will be a Leap Year: "); }
                    while (!int.TryParse(Console.ReadLine(), out nYear));

                    bIsDiv4 = nYear % 4 == 0 ? true : false;
                    bIsDiv100 = nYear % 100 == 0 ? true : false;
                    bIsDiv400 = nYear % 400 == 0 ? true : false;

                    if ((bIsDiv4 && bIsDiv100 && bIsDiv400) || (bIsDiv4 && (!bIsDiv100) && (!bIsDiv400)))
                    { Console.WriteLine(nYear + " is a Leap Year."); }
                    else
                    { Console.WriteLine(nYear + " is not a Leap Year."); }

                    Console.WriteLine("Would you like to test another Year? Enter 'Y' or 'Yes' to continue; Enter anyting else to Exit the program: ");
                    bExtitCondition=("y".Equals(Console.ReadLine().ToLower().Trim()))|| ("yes".Equals(Console.ReadLine().ToLower().Trim()));
                    Console.WriteLine("");
                } catch (Exception) { continue; }    
             } while (bExtitCondition);
            Console.Write("Exiting...");
        }
    }
}
