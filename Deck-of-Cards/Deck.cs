using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            this.cards = new List<Card>();
            DeckReset();
        }
        void DeckReset()
        {
            List<Card> initDeck = new List<Card>();
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            string[] names = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eigth", "Nine", "Ten", "Jack", "Queen", "King" };
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    initDeck.Add(new Card(names[j], suits[i], values[j]));
                }
            }
            this.cards = initDeck;
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < this.cards.Count; i++)
            {
                int randIndex = rand.Next(0, this.cards.Count);
                Card temp = this.cards[i];
                this.cards[i] = this.cards[randIndex];
                this.cards[randIndex] = temp;
            }
        }
        public Card Deal()
        {
            Card temp = this.cards[0];
            this.cards.RemoveAt(0);
            return temp;
        }

        public void PrintDeck()
        {   
            Console.WriteLine($"Printing Deck:\n----------------");
            
            foreach (var card in this.cards)
            {
                card.Print();
            }
            Console.WriteLine($"---------------");
            Console.WriteLine($"Total {this.cards.Count} cards");
            Console.WriteLine($"---------------\n");
        }
    }
}