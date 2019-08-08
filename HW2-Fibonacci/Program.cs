using System;

namespace HW2_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = 0;
            Console.WriteLine("Fibonacci Sequence");
            Console.Write("Please input an integer to calculate the Fibonacci Sequence: ");
            while (!Int32.TryParse(Console.ReadLine(),out nInput))
            {
                Console.Write("Please input an integer to calculate the Fibonacci Sequence: ");
            }
            Fibonacci myFib = new Fibonacci(nInput);
        }
    }
    class Fibonacci
    {
        public Fibonacci(int myFib)
        {
           FibCalc(0, 1, 1, myFib);

        }
        private static void FibCalc(int a,int b,int count,int length)
        {
            if (count <= length)
            {
                Console.Write("" + a + " ");
                FibCalc(b, a + b, count + 1, length);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("The "+length+"th Fibonacci number is "+FibNthFib(length)); 
            }
        }
        private static int FibNthFib(int myFib)
        {
            int num = myFib - 1;
            int[] Fib = new int[num + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[num];
        }
    }
}
