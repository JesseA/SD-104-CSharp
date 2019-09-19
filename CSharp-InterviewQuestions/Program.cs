using System;

namespace CSharp_InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start of Part 1
            int userNum = -1;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~ Part 1. Multiplication Table ~~~~~~~~~~~~~~~~~~~~~~~~~");
            while(true){ 
                try
                {
                    do
                    {
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Please enter a integer between 2 and 20: ");
                        } while (!int.TryParse(Console.ReadLine(), out userNum));
                    } while (userNum > 20 || userNum < 2);
                    Console.WriteLine("");
                    userNum++;
                    int[,] matrix = new int[userNum,userNum];
                    string outputString = "";

                    for (int i = 0; i < userNum; i++)
                    {
                        outputString += "[ ";
                        for (int j = 0; j < userNum; j++)
                        {
                            matrix[i, j] = i * j;
                            outputString += (matrix[i, j]) + " ";
                        }
                        outputString += "]\n";

                    }
                    Console.WriteLine(outputString);
                    break;
                } catch (Exception) { continue; }
            }
            Console.WriteLine("");
            //End of Part 1





            //Start of Part 2
            string userWord = "";
            bool test1 = false, test2 = false, test3 = false,testVow=false,testCon=false,hasNum=false,firstLetterCapital=false,restNonCapital=true;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~ Part 2. Spell-Checker ~~~~~~~~~~~~~~~~~~~~~~~~~");

            while (true)
            {
                try
                {
                    Console.Write("Please enter a word to spell-check: ");
                    userWord = Console.ReadLine();

                    //test condition 1
                    //test for 'A', 'a', or 'I'
                    test1 = (userWord == "I" || userWord == "A" || userWord=="a");
                    //check for vowels
                    char[] Vowels = { 'a', 'e','i','o','u','y', 'A', 'E', 'I', 'O', 'U', 'Y' };
                    foreach (char cha in Vowels)
                    {
                        if (userWord.Contains(cha))
                        {
                            testVow = true;
                            //breaks loop if at least one vowel found
                            break;
                        }

                    }
                    //check for consonants
                    char[] Consonants = { 'q','w','r','t','p','Q','W','R','T','P','s','d','f','g','h','j','k','l','S','D','F','G','H','J','K','L','z','x','c','v','b','n','Z','X','C','V','B','N','M','m' };
                    foreach (char cha in Consonants)
                    {
                        if(userWord.Contains(cha))
                        {
                            testCon = true;
                            //breaks loop if at least one consonant found
                            break;
                        }
                    }
                    //if word isn't 'A' or 'I', set condition based on if the word has vowels and consonants
                    if(!test1) { test1 = testVow && testCon; }
                    //if test1 fails, don't test other conditions; break out of outer loop
                    if(!test1) { break; }


                    //test condition 2
                    //test if word contains any numbers
                    char[] Nums = {'0','1','2','3','4','5','6','7','8','9'};
                    foreach (char cha in Nums)
                    {
                        if(userWord.Contains(cha))
                        {
                            hasNum = true;
                            //breaks loop if at least one number found
                            break;
                        }
                    }
                    //test2 passes if no numbers found
                    test2 = !hasNum;
                    //skip testing next conditions if test2 fails by breaking out of outer loop
                    if (!test2) { break; }


                    //test condition 3
                    //test if first letter is uppercase and all other letters are lowercase
                    //gets first letter of word and rest of word
                    string firstLetter = userWord.Substring(0, 1);
                    char[] restOfWord = userWord.Substring(1).ToCharArray();
                    //checks if first letter is capital
                    if(firstLetter==firstLetter.ToUpper()) { firstLetterCapital = true; }
                    //checks if any letter is capital in rest of word
                    foreach (char cha in restOfWord)
                    {
                        string charstring = "" + cha;
                        if(charstring==charstring.ToUpper())
                        {
                            restNonCapital = false;
                            
                            break;
                        }
                    }
                    test3 = firstLetterCapital && restNonCapital;
                    Console.WriteLine();

                }
                catch (Exception) { continue; }
                break;
            }
            if (test1 && test2 & test3)
            {
                Console.WriteLine("The word \"" + userWord + "\" is spelled correctly!");
            }
            else
            {
                Console.WriteLine("The word \"" + userWord + "\" is not spelled correctly.");
            }
            //End of Part 2




            //Part 3. Phone Number to Words
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~ Part 3. Phone Number to Words ~~~~~~~~~~~~~~~~~~~~~~~~~");
            string phonePhrase = "";
            while (true)
            {
                try
                {
                    while((phonePhrase.Length!=7)||(phonePhrase.Length!=10))
                    {
                        Console.Write("Please enter a phrase 7 or 10 characters in length: ");
                        phonePhrase=Console.ReadLine();

                    }

                    

                    break;
                }
                catch (Exception)
                {continue;}

            }


            //End of Program
            Console.ReadLine();
        }
    }
}
