using System;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            deck.PrintDeck();
            Ninja william = new Ninja("William");
            Ninja josh = new Ninja("Josh");
            william.Draw(deck,7);
            william.PrintHand();
            josh.Draw(deck,7);
            josh.PrintHand();
            deck.PrintDeck();
            william.Discard(0);
            josh.Discard(4);
            william.PrintHand();
            josh.PrintHand();
        }
    }
}
