﻿using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //       -Make new list of strings named 'deck'
            var deck = new List<string>() { "Ace of hearts", "2 of hearts", "3 of hearts", "4 of hearts", "5 of hearts", "6 of hearts", "7 of hearts", "8 of hearts", "9 of hearts", "10 of hearts", "Jack of hearts", "Queen of hearts", "King of hearts", "Ace of diamonds", "2 of diamonds", "3 of diamonds", "4 of diamonds", "5 of diamonds", "6 of diamonds", "7 of diamonds", "8 of diamonds", "9 of diamonds", "10 of diamonds", "Jack of diamonds", "Queen of diamonds", "King of diamonds", "Ace of spades", "2 of spades", "3 of spades", "4 of spades", "5 of spades", "6 of spades", "7 of spades", "8 of spades", "9 of spades", "10 of spades", "Jack of spades", "Queen of spades", "King of spades", "Ace of clubs", "2 of clubs", "3 of clubs", "4 of clubs", "5 of clubs", "6 of clubs", "7 of clubs", "8 of clubs", "9 of clubs", "10 of clubs", "Jack of clubs", "Queen of clubs", "King of clubs" };

            var deckLength = deck.Count;


            for (var rightIndex = deckLength - 1; rightIndex >= 1; rightIndex--)
            {
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);

                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
            }
            var firstCard = deck[0];
            Console.WriteLine(firstCard);
            var secondCard = deck[1];
            Console.WriteLine(secondCard);



        }
    }
}


