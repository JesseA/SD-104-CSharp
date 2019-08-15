using System;

namespace Lab3A_BMI_Calc_Input_Valid
{
    class Program
    {
        static void Main(string[] args)
        {
            double dHeight=-1, dWeight=-1, dBMI=0;
            
                    Console.WriteLine("BMI Calculator");
                    Console.WriteLine("");

                    Console.Write("Please Enter Your Height in Inches: ");
            while (dHeight < 0)
            {
                while (!double.TryParse(Console.ReadLine(), out dHeight))
                {
                    Console.WriteLine("Invalid input. Height must be a posistive, rational number.");
                    Console.WriteLine("");
                    Console.Write("Please Enter Your Height in Inches: ");
                }
                if(dHeight<0)
                {
                    Console.WriteLine("Invalid input. Height must be a posistive, rational number.");
                    Console.WriteLine("");
                    Console.Write("Please Enter Your Height in Inches: ");
                }

            }
                    Console.Write("Please Enter Your Weight in Pounds: ");
            while (dWeight < 0)
            {
                while (!double.TryParse(Console.ReadLine(), out dWeight))
                {
                    Console.WriteLine("Invalid input. Weight must be a posistive, rational number.");
                    Console.WriteLine("");
                    Console.Write("Please Enter Your Weight in Pounds: ");
                }
                if(dWeight<0)
                {
                    Console.WriteLine("Invalid input. Weight must be a posistive, rational number.");
                    Console.WriteLine("");
                    Console.Write("Please Enter Your Weight in Pounds: ");
                }
            }
                    dBMI = ((dWeight * 703) / (dHeight * dHeight));

                    Console.WriteLine("Your BMI is " + dBMI);

                    if (dBMI < 18.5)
                    {
                        Console.WriteLine("Your BMI is under 18.5 - Underweight!");
                    }
                    else if (dBMI <= 24.9)
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
                 Console.ReadLine();
                
           
        }
    }
}
