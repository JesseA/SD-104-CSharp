using System;

namespace CSharp_CodeIWroteWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating variables
            int testVar01 = -1, testVar02 = -2, testVar03 = -3, testVar04 = -4;

            //changing variables using if statement
            if (testVar01 < 0 || testVar02 < 0 || testVar03 < 0 || testVar04 < 0)
            {
                testVar01 = Math.Abs(testVar01);
                testVar02 = Math.Abs(testVar02);
                testVar03 = Math.Abs(testVar03);
                testVar04 = Math.Abs(testVar04);
            }

            //controling program path with switch statement
            switch (testVar01)
            {
                case -1: Console.WriteLine("The value of 'testVar01' is -1"); break;
                case 0: Console.WriteLine("The value of 'testVar01' is 0"); break;
                default: Console.WriteLine("The value of 'testVar01' is " + testVar01); break;
            }
            Console.WriteLine();

            //using a for loop to print the numbers 1 - 100; also, creating an int array and filling in values
            Console.Write("[ ");
            int myArrayCount = testVar01 + testVar02 + testVar03 + testVar04;
            int[] iArray01 = new int[myArrayCount];
            for (int i = 1; i <= 100; i++)
            {
                if (i < 100)
                { Console.Write(i + ", "); }
                else
                { Console.Write(i + " "); }

                if (i <= myArrayCount)
                { iArray01[i - 1] = (int)Math.Pow(2, i); }
            }

            Console.WriteLine("]");

            Console.WriteLine();

            //printing out the int array created above
            Console.Write("[ ");
            foreach (int n in iArray01)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("]");
            Console.ReadLine();


        }
    }
}
