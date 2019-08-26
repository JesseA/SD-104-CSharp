using System;
using System.Threading;

namespace HW4_MontyHallGameShow
{
    class Program
    {
        static void Main(string[] args)
        {
            long door1 = 0, door2 = 0, door3 = 0, correct = 0;
            


            MontyHallGame myMonty;

            for (int i = 0; i < 10000; i++)
            {
                myMonty = new MontyHallGame();
                Thread.Sleep(new TimeSpan(2000));

                if (myMonty.HiddenDoors[0]==true)
                {
                    door1++;
                    if (myMonty.PlayersChoice[0]==true)
                    {
                        correct++;
                    }
                }
                else if(myMonty.HiddenDoors[1] == true)
                {
                    door2++;
                    if (myMonty.PlayersChoice[1] == true)
                    {
                        correct++;
                    }
                }
                else if(myMonty.HiddenDoors[2] == true)
                { door3++;
                    if (myMonty.PlayersChoice[2] == true)
                    {
                        correct++;
                    }
                }
            }
            Console.WriteLine("Door #1: " + door1 + " Door #2: " + door2 + " Door #3: " + door3);
            Console.WriteLine("The player guessed correctly " + correct + " times and incorrectly " + (10000 - correct) + " times.");
        }

    }

    class MontyHallGame
    {
        private bool[] hiddenDoors;
        private bool[] playersChoice;
        private Random rand;

        public MontyHallGame()
        {
            rand = new Random();
            int nRand = rand.Next(0, 3);
            switch(nRand)
            {
                case 0:
                    HiddenDoors = new bool[3] { true, false, false }; break;
                case 1:
                    HiddenDoors = new bool[3] { false, true, false }; break;
                default:
                    HiddenDoors = new bool[3] { false, false, true }; break;
            }

            Thread.Sleep(new TimeSpan(2000));

            rand = new Random();
            nRand = rand.Next(0, 3);
            switch (nRand)
            {
                case 0:
                    PlayersChoice = new bool[3] { true, false, false }; break;
                case 1:
                    PlayersChoice = new bool[3] { false, true, false }; break;
                default:
                    PlayersChoice = new bool[3] { false, false, true }; break;
            }

        }

        public bool[] HiddenDoors { get => hiddenDoors; set => hiddenDoors = value; }
        public bool[] PlayersChoice { get => playersChoice; set => playersChoice = value; }
    }
}
