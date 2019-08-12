using System;

namespace Lab7_ParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith", "Lupe Hurtado" };
            String[] Phone = {"555-1334","555-3882","555-8211","555-1617","555-2803","555-8888" };
            String strSearch;


            Console.WriteLine("Phone Book");
            Console.WriteLine("");
            //prompt user
            Console.Write("Please type a name to search the phone book: ");
            strSearch = Console.ReadLine();

            for(int n=0; n<Names.Length;n++)
            {
                if(Names[n].IndexOf(strSearch) > -1)
                {
                    Console.WriteLine(Names[n] + " -> " + Phone[n]);
                }
            }
            Console.ReadLine();

        }
    }
}
