using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // test standard die
            Die standardDie = new Die();
            Console.WriteLine("Standard Die");
            Console.WriteLine("Number of sides: " + standardDie.NumSides);
            Console.WriteLine("Top side: " + standardDie.TopSide);
            Console.WriteLine();

            // Roll and print the results
            Console.WriteLine("Rolling...");
            standardDie.Roll();
            Console.WriteLine("Top side: " + standardDie.TopSide);
            Console.WriteLine();

            // Test D20
            Die d20Die = new Die(20);
            Console.WriteLine("D20 Die");
            Console.WriteLine("Number of sides: " + d20Die.NumSides);
            Console.WriteLine("Top side: " + d20Die.TopSide);
            Console.WriteLine();

            // Roll and print the results
            Console.WriteLine("Rolling...");
            d20Die.Roll();
            Console.WriteLine("Top side: " + d20Die.TopSide);
            Console.WriteLine();
        }
    }
}
