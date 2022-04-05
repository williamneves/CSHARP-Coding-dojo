using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Ninja
    {
        public string name;
        public List<Card> hand;

        public Ninja(string name)
        {
            this.name = name;
            this.hand = new List<Card>();
        }

        public void Draw(Deck deck, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                this.hand.Add(deck.Deal());
            }
            Console.WriteLine($"\n{this.name} drew {times} cards\n");
            
        }

        public Card Discard(int index)
        {
            if (index < 0 || index > this.hand.Count)
            {
                return null;
            }
            else
            {
                Card temp = this.hand[index];
                Console.WriteLine($"\n{this.name} discard one cards\n");
                return temp;
            }
        }

        public void PrintHand()
        {
                Console.WriteLine($"\nPrinting Hand for {this.name}:\n----------------");
            foreach (var card in this.hand)
            {
                
                card.Print();
            }
                Console.WriteLine($"---------------");	
        }
    }
}