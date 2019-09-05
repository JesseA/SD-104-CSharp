using System;
using System.Globalization;

namespace MidTermQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string thisMeal, mealString;
            int mealHour = -1;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            Console.Write("Please enter a meal: ");
            thisMeal = Console.ReadLine().Trim().ToLower();

            mealHour = TimeOfMeal(thisMeal);

            switch (mealHour)
            {
                case 6: mealString=" is eaten at 6 A.M."; break;
                case 9: mealString = " is eaten at 9 A.M."; break;
                case 12: mealString = " is eaten at Noon."; break;
                case 18: mealString = " is eaten at 6 P.M."; break;
                default: mealString = " is eaten at Midnight."; break;
            }

            Console.WriteLine("");

            thisMeal = textInfo.ToTitleCase(thisMeal);
            Console.WriteLine(thisMeal+mealString);
            Console.ReadLine();
        }

        public static int TimeOfMeal(string meal)
        {
            int hour=-1;

            switch(meal)
            {
                case "breakfast": hour = 6; break;
                case "brunch": hour = 9; break;
                case "lunch": hour = 12; break;
                case "dinner": hour = 18; break;
                default: hour = 0; break;
            }

            return hour;
        }
    }
}
