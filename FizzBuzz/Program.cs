using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++){Console.WriteLine((i%3==0&&i%5==0)?"FizzBuzz":(i%3==0)?"Fizz":(i%5==0)?"Buzz":i.ToString());}
            Console.ReadLine();
        }
    }
}
