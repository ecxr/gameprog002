using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToStrings
{
    /// <summary>
    /// Demonstrates string basics
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates how to find a substring and extract from a larger string
        /// </summary>
        static void ReadCSV() 
        {
            // read in csv string
            Console.Write("Enter name and percent (name,percent): ");
            string csvstring = Console.ReadLine();
            
            // find comma location
            int commaLocation = csvstring.IndexOf(',');

            // extract name and percent
            string name = csvstring.Substring(0, commaLocation);
            float percent = float.Parse(csvstring.Substring(commaLocation + 1));

            // print name and percent
            Console.WriteLine(name);
            Console.WriteLine(percent);

            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates string basics
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            ReadCSV();

            // prompt for and read in gamertag
            Console.Write("Enter gamertag: ");
            string gamertag = Console.ReadLine();

            // prompt for and read in level
            Console.Write("Enter level: ");
            int level = int.Parse(Console.ReadLine());

            // extract the first character of the gamertag
            char firstGamertagCharacter = gamertag[0];

            // print out values
            Console.WriteLine("Gamertag: " + gamertag);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("First gamertag character: " + firstGamertagCharacter);
            Console.WriteLine();
        }
    }
}
