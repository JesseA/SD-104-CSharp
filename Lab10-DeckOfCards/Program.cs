using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab10_DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            FiveCardDraw fcd = new FiveCardDraw();
            fcd.PlayRound();
            Console.ReadLine();
        }
            
        class DeckOfCards
        {
            public List<Card> Deck { get; set; }
            private const int NUMBER_OF_CARDS = 52;

            public DeckOfCards()
            {
                string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J","Q","K" };
                char[] suits = { '♠', '♣', '♥', '♦' };
                int[] values = { 14,2,3,4,5,6,7,8,9,10,11,12,13};

                Deck = new List<Card>();

                for (int count = 0; count < NUMBER_OF_CARDS; count++)
                {
                    Deck.Add(new Card(faces[count%13],suits[count/13],values[count%13]));
                }
            }

            public void Shuffle()
            {
                Random rand = new Random();
                int nRand;
                Card temp;

                for (int i = 0; i <Deck.Count; i++)
                {
                    nRand = rand.Next(1, Deck.Count);
                    temp = Deck[i];
                    Deck[i] = Deck[nRand];
                    Deck[nRand] = temp;

                }

            }

            public Card Deal()
            {
                Card temp = Deck[0];
                Deck.RemoveAt(0);
                return temp;
            }
        }

        class Card
        {
            string rank;
            char suit;
            int val;

            public string Rank { get => rank; set => rank = value; }
            public char Suit { get => suit; set => suit = value; }
            public int Val { get => val; set => val = value; }

            public override string ToString()
            {
                return string.Format("{0,2} {1}",Rank, Suit);
            }


            public Card(string rank, char suit, int val)
            {
                this.rank = rank;
                this.suit = suit;
                this.val = val;
            }
        }

        class FiveCardDraw
        {
            public List<Card> PlayersHand { get; set; }
            public DeckOfCards deckOfCards { get; set; }

            private bool[] Discard;

            public FiveCardDraw()
            {
                deckOfCards = new DeckOfCards();
                deckOfCards.Shuffle();
                PlayersHand = new List<Card>();
            }

            public void PlayRound()
            {
                Discard = new bool [5] { false, false, false, false, false };
                string userChoice;
                int discardMe = 0;

                for (int i = 0; i < 5; i++)
                {
                    PlayersHand.Add(deckOfCards.Deal());
                }
                do
                {
                    ShowPlayersHand();

                    Console.WriteLine();
                    Console.WriteLine("Type the number of the card in your hand and hit 'Enter' to toggle to keep/discard. Type 'D' to finalize discard choice.");
                    userChoice = Console.ReadLine().Trim().ToUpper();

                    while(userChoice!="D"&& !int.TryParse(userChoice,out discardMe))
                    {
                        Console.Write("Invalid choice. Please try again: ");
                        userChoice = Console.ReadLine();
                    }

                    if (userChoice!="D"&& discardMe>0 && discardMe<6)
                    {
                        Discard[discardMe - 1] = Discard[discardMe - 1] == true ? false : true;
                    }

                    Console.WriteLine();
                } while (userChoice != "D");
                FinalizeDiscard();
                Console.WriteLine();
                Console.WriteLine("Your new hand after discarding is: ");
                ShowPlayersHand();
            }

            public void FinalizeDiscard()
            {
                for (int i = 0; i < PlayersHand.Count; i++)
                {
                    if(Discard[i])
                    {
                        deckOfCards.Deck.Add(PlayersHand[i]);
                        PlayersHand[i] = deckOfCards.Deal();
                    }
                }

                Discard= new bool[5] { false, false, false, false, false };
            }
            public void ShowPlayersHand()
            {
                for (int i = 0; i < PlayersHand.Count; i++)
                {
                    Console.Write("Card #"+(i+1)+": "+PlayersHand[i]);
                    if (Discard[i] == true) { Console.WriteLine(" <---Discard"); }
                    else { Console.WriteLine(""); }
                }
            }
        }
    }
}
