using System;
using System.Collections.Generic;
namespace Deck_of_Cards
{
    public class Card
    {
        public string name;
        public string suit;
        public int val;

        public Card(string name, string suit, int val)
        {
            this.name = name;
            this.suit = suit;
            this.val = val;
        }

        public void Print()
        {
            Console.WriteLine($"> {name} of {suit} | val: {val}");
            
        }
    }
}