using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingDeckClass
{
    /// <summary>
    /// Demonstrates using the Deck class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using the Deck class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            // print deck empty information
            Console.WriteLine("Empty: " + deck.Empty);

            //deck.Print();

            // tell the deck to shuffle itself
            //deck.Shuffle();

            // cut the deck
            //deck.Cut(26);

            // take top card and print info
            deck.TakeTopCard();
            //Card card = deck.TakeTopCard();
            //Console.WriteLine(card.Rank + " of " + card.Suit);

            //Console.WriteLine();
            //deck.Print();



            Console.WriteLine();
        }
    }
}
