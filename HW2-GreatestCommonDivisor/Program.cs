using System;

namespace HW2_GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNum1=0, nNum2=0, nRem=-1, nMax = -1, nMin = -1;
            Console.WriteLine("Greatest Common Divisor");
            Console.Write("Please enter the first number: ");
            while(!Int32.TryParse(Console.ReadLine(),out nNum1))
            {
                Console.Write("Please enter the first number: ");
            }
            Console.Write("Please enter the second number: ");
            while (!Int32.TryParse(Console.ReadLine(), out nNum2))
            {
                Console.Write("Please enter the second number: ");
            }

            nMax = Math.Max(nNum1, nNum2);
            nMin = Math.Min(nNum1, nNum2);

            while (true)
            {
                nRem = nMax % nMin;
                if (nRem == 0) { Console.WriteLine("The GCD of "+nNum1+" and "+nNum2+" is: "+nMin); break; }
                else { nMax = nMin; nMin = nRem; continue; }
            }
        }
    }
}
