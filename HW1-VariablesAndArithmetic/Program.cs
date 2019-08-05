using System;

namespace HW1_VariablesAndArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numberOne, numberTwo, dSum, dDiff, dProd, dQuot;
            while(true)
            {
                try
                {
                    Console.Write("Please enter the first number: ");
                    numberOne = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    numberTwo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    dSum = numberOne + numberTwo;
                    dProd = numberOne * numberTwo;
                    dDiff = numberOne - numberTwo;
                    dQuot = numberOne / numberTwo;

                    Console.WriteLine("The Sum of the numbers " + numberOne + " and " + numberTwo + " is " + dSum);
                    Console.WriteLine("The Product of the numbers " + numberOne + " and " + numberTwo + " is " + dProd);
                    Console.WriteLine("The Difference of the numbers " + numberOne + " and " + numberTwo + " is " + dDiff);
                    Console.WriteLine("The Quotient of the numbers " + numberOne + " and " + numberTwo + " is " + dQuot);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }catch(Exception e) { System.Environment.Exit(-1); }
            }
        }
    }
}