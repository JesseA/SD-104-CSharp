using System;

namespace Lab3_BMI_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double dHeight, dWeight, dBMI;
            while (true) {
                try{
                    Console.WriteLine("BMI Calculator");
                    Console.WriteLine("");

                    Console.Write("Please Enter Your Height in Inches: ");
                    dHeight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please Enter Your Weight in Pounds: ");
                    dWeight = Convert.ToDouble(Console.ReadLine());

                    dBMI = ((dWeight * 703) / (dHeight * dHeight));

                    Console.WriteLine("Your BMI is " + dBMI);

                    if(dBMI<18.5)
                    {
                        Console.WriteLine("Your BMI is under 18.5 - Underweight!");
                    }
                    else if(dBMI<=24.9)
                    {

                        Console.WriteLine("Your BMI is between 18.5 and 24.9 - Normal Weight");
                    }
                    else if (dBMI <= 29.9)
                    {

                        Console.WriteLine("Your BMI is between 24.5 and 29.9 - Overweight!");
                    }
                    else
                    {
                        Console.WriteLine("Your BMI is over 29.9 - Obese!!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                catch (Exception e)
                { Console.WriteLine("Invalid Input..."); Console.WriteLine(""); Console.WriteLine(""); continue; }
            }
        }
    }
}
