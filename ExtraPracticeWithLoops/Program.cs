using System;
using System.Collections.Generic;

namespace ExtraPracticeWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int myArrCount = -1, myArrValue = -1, minValue = int.MaxValue, maxValue = int.MinValue;
                do
                {
                    do
                    {
                        Console.Write("Please enter how many integers you want in your array: ");
                    } while (!Int32.TryParse(Console.ReadLine(), out myArrCount));
                } while (myArrCount < 0);

                List<int> myList = new List<int>();

                for (int num = 0; num < myArrCount; num++)
                {
                    do
                    {
                        Console.Write("Please enter the value for element number " + (num + 1)+": ");
                    } while (!Int32.TryParse(Console.ReadLine(), out myArrValue));
                    myList.Add(myArrValue);
                    if (myArrValue > maxValue) { maxValue = myArrValue; }
                    else if (myArrValue < minValue) { minValue = myArrValue; }
                }
                /*
                for (int num = 0; num < myArrCount; num++)
                {
                    do
                    {
                        Console.Write("Please enter the value for element number " + (num + 1) + ": ");
                    } while (!Int32.TryParse(Console.ReadLine(), out myArrValue));
                    myList.Add(myArrValue);
                    if (myArrValue > maxValue) { maxValue = myArrValue; }
                    else if (myArrValue < minValue) { minValue = myArrValue; }
                }*/

                Console.WriteLine("Your minimum number was "+minValue);
                Console.WriteLine("Your maximum number was " + maxValue);

            }
            catch (Exception e) { Console.WriteLine("Exception: "+e.Message); Console.WriteLine("Source: " + e.Source); }
        }
    }
}
