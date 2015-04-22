using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DieExample
{
    /// <summary>
    /// Demonstrates implementation of a Die class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the Die class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // test standard die
            Die standardDie = new Die();
            Console.WriteLine("STANDARD DIE");
            Console.WriteLine("Number of sides: " + standardDie.NumSides);
            Console.WriteLine("Top side: " + standardDie.TopSide);
            Console.WriteLine();

            // test D20 die
            Die d20Die = new Die(20);
            Console.WriteLine("D20 DIE");
            Console.WriteLine("Number of sides: " + d20Die.NumSides);
            Console.WriteLine("Top side: " + d20Die.TopSide);

            Console.WriteLine();
        }
    }
}
