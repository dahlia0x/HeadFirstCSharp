using System;
using System.Collections.Generic;
using Cards;

namespace SortCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Card> cards = new List<Card>();

            for (int i = 0; i < 6; i++)
            {
                cards.Add(new Card(random.Next(4), random.Next(1, 14)));
            }

            PrintCardNames(cards);

            Console.WriteLine("\nThose same cards, sorted: \n");

            cards.Sort(new CardComparer_byValue());
            PrintCardNames(cards);

        }

        private static void PrintCardNames(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
