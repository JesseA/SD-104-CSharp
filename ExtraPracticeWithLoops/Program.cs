using System;
using System.Collections.Generic;

namespace ExtraPracticeWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray;
            int[] myArray2;
            try
            {
                //Program 1
                int myArrCount = -1, myArrValue = -1, minValue = int.MaxValue, maxValue = int.MinValue;
                do
                {

                    Console.WriteLine("<------------- Part 1: Minimum and Maximum values ------------------>");
                    Console.Write("Please enter how many integers you want in your array: ");
                    while (!Int32.TryParse(Console.ReadLine(), out myArrCount))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Not a number!");
                        Console.Write("Please enter how many integers you want in your array: ");
                    }
                   if(myArrCount==0) { maxValue = 0;minValue = 0; }

                    Console.WriteLine("");
                } while (myArrCount < 0);

                myArray =new int[myArrCount];


                for (int num = 0; num < myArrCount; num++)
                {
                    do
                    {
                        Console.Write("Please enter the value for element number " + (num + 1)+": ");
                    } while (!Int32.TryParse(Console.ReadLine(), out myArrValue));
                    myArray[num] = myArrValue;
                    if (myArrValue > maxValue) { maxValue = myArrValue; }
                    if (myArrValue < minValue) { minValue = myArrValue; }
                }
               
                Console.WriteLine("Your minimum number was "+minValue);
                Console.WriteLine("Your maximum number was " + maxValue);
                Console.WriteLine("");


                //Program 2
                myArrCount = -1; myArrValue = -1;
                do
                {

                    Console.WriteLine("<------------- Part 2: Reverse Array ------------------>");
                    Console.Write("Please enter how many integers you want in your array: ");
                    while (!Int32.TryParse(Console.ReadLine(), out myArrCount))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Not a number!");
                        Console.Write("Please enter how many integers you want in your array: ");
                    }

                    Console.WriteLine("");
                } while (myArrCount < 0);


                myArray2 = new int[myArrCount];

                for (int num = 0; num < myArrCount; num++)
                {
                    do
                    {
                        Console.Write("Please enter the value for element number " + (num + 1) + ": ");
                    } while (!Int32.TryParse(Console.ReadLine(), out myArrValue));
                    myArray2[num] = myArrValue;
                }

                Console.WriteLine("Your array backwards is: ");

                for(int num=(myArray2.Length-1); num>=0; num--)
                {
                    if(num!=0)
                    {
                        Console.Write(myArray[num] + " , ");
                    }
                    else
                    {
                        Console.Write(myArray[num]);
                    }
                }
            }
            catch (Exception e) { Console.WriteLine("Exception: "+e.Message); Console.WriteLine("Source: " + e.Source); }
        }
    }
}
