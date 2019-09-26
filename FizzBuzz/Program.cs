using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++){Console.WriteLine((i%15==0)?"FizzBuzz":(i%3==0)?"Fizz":(i%5==0)?"Buzz":i.ToString());}

           /* for (int i = 1; i < 101; i++)
            {
               
                if(i%15==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/
            Console.ReadKey();
        }


    }
}

