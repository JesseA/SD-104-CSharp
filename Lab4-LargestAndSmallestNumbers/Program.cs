using System;

namespace Lab4_LargestAndSmallestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int nLargest = 0, nSmallest = 0, nCurrent=0;
            //first integer
            while (true)
            {
                Console.WriteLine("Please enter the first integer: ");
                if (Int32.TryParse(Console.ReadLine(), out int nInt))
                {
                    nLargest = nSmallest = nCurrent = nInt;
                    break;
                }
                else
                {
                    Console.WriteLine("Please input an integer...");
                    continue;
                }
            }
            //next integer or quit
            while (true)
            {
                Console.WriteLine("Please enter another integer or 'Q' to Quit: ");
                String sInput = Console.ReadLine();
                if(sInput.ToUpper()=="Q")
                {
                    Console.WriteLine("The largest value you entered was " + nLargest);
                    Console.WriteLine("The smallest value you entered was " + nSmallest);
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                else
                {
                    if (Int32.TryParse(sInput, out int nInt))
                    {
                        nCurrent = nInt;
                        if (nCurrent > nLargest)
                        {
                            nLargest = nCurrent;
                        }
                        else if(nCurrent<nSmallest)
                        {
                            nSmallest = nCurrent;
                        }
                }
                    else
                    {
                        Console.WriteLine("Please input an integer...");
                        Console.WriteLine("");
                        continue;
                    }
                }
            }
        }
    }
}
