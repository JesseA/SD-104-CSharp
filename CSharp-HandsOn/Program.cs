using System;

namespace CSharp_HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindMax
            int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
            int[] array2 = { -9, -7 , -11, -7, -88, -5, -10 };
            int[] array3 = { 9, -70 , -111, 700, 88, -50, 10 };
            int[] array4 = { -9, -700 , -11, 7, -88, -50000, -10 };


            Console.WriteLine("Part 1: FindMax ----------------------------------------");
            Console.WriteLine("Array 1 FindMax: "+FindMax(array1));
            Console.WriteLine("Array 2 FindMax: " + FindMax(array2));
            Console.WriteLine("Array 3 FindMax: " + FindMax(array3));
            Console.WriteLine("Array 4 FindMax: " + FindMax(array4));
            Console.WriteLine("");

            //Reverse Array
            string[] array5 = { "AAAAA", "BBBB", "CCC", "DD", "E" };
            string[] array6 = { "Texas", "New York", "Washington", "Nevada" };
            string[] array7 = { "Apple", "Banana", "Watermelon", "Squash" };
            string[] array8 = { "Comma", "Period", "Space", "Line Break" };
            string[] reverse5 = ReverseArray(array5);
            string[] reverse6 = ReverseArray(array6);
            string[] reverse7 = ReverseArray(array7);
            string[] reverse8 = ReverseArray(array8);

            Console.WriteLine("Part 2: ReverseArray ----------------------------------------");
            Console.WriteLine("Array 5 ReverseArray: ");
            Console.Write("[ ");
            foreach(string str in reverse5) { Console.Write(str + " "); }
            Console.WriteLine("] ");
            Console.WriteLine("Array 6 ReverseArray: ");
            Console.Write("[ ");
            foreach (string str in reverse6) { Console.Write(str + " "); }
            Console.WriteLine("] ");
            Console.WriteLine("Array 7 ReverseArray: ");
            Console.Write("[ ");
            foreach (string str in reverse7) { Console.Write(str + " "); }
            Console.WriteLine("] ");
            Console.WriteLine("Array 8 ReverseArray: ");
            Console.Write("[ ");
            foreach (string str in reverse8) { Console.Write(str + " "); }
            Console.WriteLine("] ");
            Console.WriteLine("");

            //Convert Temperature
            Console.WriteLine("Part 3: ConvertTemp ----------------------------------------");
            Console.WriteLine("Converting 32.1 C -> F: "+ConvertTemp("CtoF",32.1f)+" F");
            Console.WriteLine("Converting 500.89 C -> F: " + ConvertTemp("CtoF", 500.89f) + " F");
            Console.WriteLine("Converting -2 F -> C: " + ConvertTemp("FtoC", -2f) + " C");
            Console.WriteLine("Converting 55.5 F -> C: " + ConvertTemp("FtoC", 55.5f) + " C");
            Console.WriteLine("");

            //FindAverage
            Console.WriteLine("Part 4: FindAverage ----------------------------------------");
            Console.WriteLine("Array 1 FindAverage: " + FindAverage(array1));
            Console.WriteLine("Array 2 FindAverage: " + FindAverage(array2));
            Console.WriteLine("Array 3 FindAverage: " + FindAverage(array3));
            Console.WriteLine("Array 4 FindAverage: " + FindAverage(array4));
            Console.WriteLine("");

            //Program End
            Console.ReadLine();
        }

       static int FindMax(int[] myArray)
        {
            int myMax=Int32.MinValue;

            foreach (int val in myArray)
            {
                if (myMax < val) { myMax = val; }
            }

            return myMax;
        }

        static string[] ReverseArray(string[] myArray)
        {
            string[] reversedArray=new string[myArray.Length];
            int counter = (myArray.Length)-1;

            foreach (string str in myArray)
            {
                reversedArray[counter] = str;
                counter--;
            }

            return reversedArray;
        }

        static float ConvertTemp(string convertTo,float temp)
        {
            float temp2 = temp;

            if(convertTo=="CtoF")
            {
                temp2 = (temp*9/5)+32;
            }
            else if(convertTo=="FtoC")
            {
                temp2 = (temp - 32) * 5 / 9;
            }

            return temp2;
        }

        static int FindAverage(int[] myArray)
        {
            int avg = 0;

            foreach (int val in myArray)
            {
                avg += val;
            }
            avg /= myArray.Length;

            return avg;
        }
    }
}
