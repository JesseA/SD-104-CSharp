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
            string[] myArray3;
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
                   if (myArrCount <= 0) { Console.WriteLine("Please enter a posistive array length!"); }
                    Console.WriteLine("");
                } while (myArrCount <= 0);

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

                    if (myArrCount <= 0) { Console.WriteLine("Please enter a posistive array length!"); }
                    Console.WriteLine("");
                } while (myArrCount <= 0);


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
                Console.Write("[ ");

                for(int num=(myArray2.Length-1); num>=0; num--)
                {
                    if(num!=0)
                    {
                        Console.Write(myArray2[num] + " , ");
                    }
                    else
                    {
                        Console.Write(myArray2[num]);
                    }
                }

                Console.WriteLine(" ]");
                Console.WriteLine("");

                //Program 3
                myArrCount = -1; myArrValue = -1; bool isPalindrome = true; string userInput; 
                do
                {

                    Console.WriteLine("<------------- Part 3: Palindrome Validator ------------------>");
                    Console.Write("Please enter a word to test if it is a Palindrome: ");
                    userInput = Console.ReadLine();
                    //Console.WriteLine(userInput);
                    myArrCount = userInput.Length;
                    //Console.WriteLine(myArrCount);
                    Console.WriteLine("");
                } while (myArrCount<0);

                //building array
                myArray3 = new string[myArrCount];
                int charCounter = 0;

                foreach(string myStr in myArray3)
                {
                    myArray3[charCounter] = userInput.Substring(charCounter, 1);
                    charCounter++;
                }
                
                //checking if Palindrome
                for(int i=0; i<Math.Floor((Double)myArrCount/2); i++)
                {
                    if(myArray3[i]!=myArray3[myArrCount-i-1])
                    {
                        isPalindrome = false;
                    }
                }

                //output Palindrome truth value
                if(isPalindrome)
                {
                    Console.WriteLine("Your word \"" + userInput + "\" is a Palindrome!");
                }
                else
                {
                    Console.WriteLine("Your word \"" + userInput + "\" is not a Palindrome!");
                }

                Console.ReadLine();
                //End of Program logic
            }
            catch (Exception e) { Console.WriteLine("Exception: "+e.Message); Console.WriteLine("Source: " + e.Source); }
      
        }
    }
}
