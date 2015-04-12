using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhileLoops
{
    /// <summary>
    /// Demonstrates while loops for input validation
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates while loops for input validation
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // print menu
            Console.WriteLine("J - Jump");
            Console.WriteLine("C - Crouch");
            Console.WriteLine("Q - Quit");
            Console.WriteLine();

            // prompt for and get menu choice
            Console.Write("Enter choice: ");
            char choice = char.Parse(Console.ReadLine().ToUpper());

            // validate input
            while (choice != 'J' &&
                choice != 'C' &&
                choice != 'Q')
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice");
                Console.WriteLine();

                Console.WriteLine("J - Jump");
                Console.WriteLine("C - Crouch");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();

                // prompt for and get menu choice
                Console.Write("Enter choice: ");
                choice = char.Parse(Console.ReadLine().ToUpper());
            }

            Console.WriteLine();
        }
    }
}
