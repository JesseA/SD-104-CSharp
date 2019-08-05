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

                        }
                    }
                } catch (Exception) { continue; }
        }
        }
    }
}
