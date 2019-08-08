using System;

namespace HW2_ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            double dNum1, dNum2, dNum3;
                try
                {
                    Console.WriteLine("Part 1: Enter two numbers");
                    Console.Write("Please enter the first number: ");
                    dNum1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    dNum2 = Convert.ToDouble(Console.ReadLine());

                if(dNum1>=dNum2)
                {
                        Console.WriteLine("The first number is the largest number: " + dNum1);
                }
                else
                    {
                        Console.WriteLine("The second number is the largest number: " + dNum2);
                    }
                    Console.WriteLine("");




                    Console.WriteLine("Part 2: Enter three numbers");
                    Console.Write("Please enter the first number: ");
                    dNum1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    dNum2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the third number: ");
                    dNum3 = Convert.ToDouble(Console.ReadLine());

                if(dNum1>=dNum2&&dNum1>=dNum3)
                    {
                        if(dNum2>=dNum3)
                        {
                            Console.WriteLine("The first number is the largest number: " + dNum1);
                            Console.WriteLine("The third number is the smallest number: " + dNum3);
                        }
                        else
                        {

                            Console.WriteLine("The first number is the largest number: " + dNum1);
                            Console.WriteLine("The second number is the smallest number: " + dNum2);
                        }
                    }
                else if (dNum2 >= dNum3)
                    {
                        if (dNum1 >= dNum3)
                        {
                            Console.WriteLine("The second number is the largest number: " + dNum2);
                            Console.WriteLine("The third number is the smallest number: " + dNum3);
                        }
                        else
                        {
                            Console.WriteLine("The second number is the largest number: " + dNum2);
                            Console.WriteLine("The first number is the smallest number: " + dNum1);
                        }
                    }
                else
                    {
                        if (dNum1 >= dNum2)
                        {
                            Console.WriteLine("The third number is the largest number: " + dNum3);
                            Console.WriteLine("The second number is the smallest number: " + dNum2);
                        }
                        else
                        {
                            Console.WriteLine("The third number is the largest number: " + dNum3);
                            Console.WriteLine("The first number is the smallest number: " + dNum1);
                        }
                    }


                    Console.WriteLine("");

                } catch (Exception) {Console.WriteLine("Invalid Input. Restarting..."); Console.WriteLine(""); continue; }
        }
        }
    }
}
