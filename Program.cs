using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Algorithm B)
            //       -make a list of the 4 suits and call this list 'suits'
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };

            //       -make a list of the 13 ranks and call this list 'ranks'
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            //       -Make new list of strings named 'deck'
            var deck = new List<string>();

            //       -Make a loop that goes though the list of 'suits'
            foreach (var suit in suits)
            {

                //       -make a loop that goes through the list 'ranks'
                foreach (var rank in ranks)
                {
                    //         -for each rank, make a new string of the form $"{rank} of {suits}"
                    var card = $"{rank} of ${suit}";

                    //         -add that newly formed string to the end of the deck list
                    deck.Add(card);
                    //       -same as algorithm A

                    // SHUFFLING CARDS

                    // numberOfCards = length of our deck
                    var numberOfCards = deck.Count;

                    // for rightIndex from numberOfCards - 1 down to 1 do:
                    var rightIndex = numberOfCards - 1;

                    //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
                    var randomNumberGenerator = new Random();
                    var leftIndex = randomNumberGenerator.Next(rightIndex);
                    //   Now swap the values at rightIndex and leftIndex by doing this:


                    //     leftCard = the value from deck[leftIndex]
                    var leftCard = deck[leftIndex];
                    //     rightCard = the value from deck[rightIndex]
                    var rightCard = deck[rightIndex];

                    //     deck[rightIndex] = leftCard
                    deck[rightIndex] = leftCard;
                    //     deck[leftIndex] = rightCard
                    deck[leftIndex] = rightCard;



                }
            }
        }
    }
}














