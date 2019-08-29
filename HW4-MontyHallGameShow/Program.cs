using System;
using System.Threading;

namespace HW4_MontyHallGameShow
{
    class Program
    {
        static void Main(string[] args)
        {
            double door1 = 0, door2 = 0, door3 = 0, correct = 0, correctwithswitch=0, numswitches=0;
            


            MontyHallGame myMonty;

            for (int i = 0; i < 10000; i++)
            {
                myMonty = new MontyHallGame();
                myMonty.PlayerSwitchesDoor = (i % 2 == 1);
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

                myMonty.RevealWrongDoor();

                if (myMonty.PlayerSwitchesDoor)
                {
                    numswitches++;
                    if (myMonty.HiddenDoors[0] == true)
                    {
                        if (myMonty.PlayersChoice[0] == true)
                        {
                            correctwithswitch++;
                        }
                    }
                    else if (myMonty.HiddenDoors[1] == true)
                    {
                        if (myMonty.PlayersChoice[1] == true)
                        {
                            correctwithswitch++;
                        }
                    }
                    else if (myMonty.HiddenDoors[2] == true)
                    {
                        if (myMonty.PlayersChoice[2] == true)
                        {
                            correctwithswitch++;
                        }
                    }
                }
            }
            Console.WriteLine("Door #1: " + door1 + " Door #2: " + door2 + " Door #3: " + door3);
            Console.WriteLine("The player guessed correctly " + correct + " times and incorrectly " + (10000 - correct) + " times.");
            Console.WriteLine("The player swapped doors "+ numswitches + " times.");
            Console.WriteLine("The player guessed correctly after swapping " + correctwithswitch + " times and incorrectly " + (numswitches - correctwithswitch) + " times.");
            double originalratio = correct / 100;
            double switchratio = correctwithswitch / 50;
            Console.WriteLine("Original success rate "+originalratio+"%, correct rate after switch "+switchratio+"%");

            Console.ReadLine();


        }

    }

    class MontyHallGame
    {
        private bool[] hiddenDoors;
        private bool[] playersChoice;
        private Random rand;
        public bool PlayerSwitchesDoor { get; set; }

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

        public void RevealWrongDoor()
        {

            Thread.Sleep(new TimeSpan(2000));
            rand = new Random();
            int nrand = rand.Next(0, 2);
            int rightdoor;
            //int revealeddoor;
           if(HiddenDoors[0]==true)
            { rightdoor = 1; }
           else if(HiddenDoors[1]==true)
            { rightdoor = 2; }
           else
            { rightdoor = 3; }

            switch (rightdoor)
            {
                case 1:
                    //right door 1
                    if (PlayersChoice[0] == true)
                    {   //right door 1, player door 1
                        if (PlayerSwitchesDoor && nrand == 0)
                        {
                            //revealed door 2
                            PlayersChoice = new bool[3] { false, false, true };
                        }
                        else if (PlayerSwitchesDoor && nrand == 1)
                        {
                            //revealed door 3
                            PlayersChoice = new bool[3] { false, true, false };
                        }
                    }
                    else
                    {   //right door 1, player door 2 or 3
                        if (PlayerSwitchesDoor)
                        {
                            PlayersChoice = new bool[3] { true, false, false };
                        }
                    }
                    break;

                case 2:
                    //right door 2
                    if (PlayersChoice[1] == true)
                    {   //right door 2, player door 2
                        if (PlayerSwitchesDoor && nrand == 0)
                        {
                            //revealed door 3
                            PlayersChoice = new bool[3] { true, false, false };
                        }
                        else if (PlayerSwitchesDoor && nrand == 1)
                        {
                            //revealed door 1
                            PlayersChoice = new bool[3] { false, false,true };
                        }
                    }
                    else
                    {   //right door 2, player door 1 or 3
                        if (PlayerSwitchesDoor)
                        {
                            PlayersChoice = new bool[3] { false, true, false };
                        }
                    }
                    break;

                default:
                    //right door 3
                    if (PlayersChoice[2] == true)
                    {   //right door 3, player door 3
                        if (PlayerSwitchesDoor && nrand == 0)
                        {
                            //revealed door 1
                            PlayersChoice = new bool[3] { false,true, false };
                        }
                        else if (PlayerSwitchesDoor && nrand == 1)
                        {
                            //revealed door 2
                            PlayersChoice = new bool[3] { true,false,false };
                        }
                    }
                    else
                    {   //right door 3, player door 1 or 2
                        if (PlayerSwitchesDoor)
                        {
                            PlayersChoice = new bool[3] { false, false,true };
                        }
                    }
                    break;
            }
        }
    }
}
