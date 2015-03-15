using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchStatements
{
    /// <summary>
    /// Demonstrates the switch statement
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates the switch statement
        /// </summary>
        static void TestSwitch()
        {
            // ask for and get user answer
            Console.Write("Pick up the shiny thing? (y, n): ");
            char answer = char.ToLower(Console.ReadLine()[0]);

            // print appropriate message
            switch (answer)
            {
                case 'y':
                    Console.WriteLine("You have the shiny object");
                    break;

                case 'n':
                    Console.WriteLine("You don't have the shiny object");
                    break;
                
                default:
                    Console.WriteLine("Please choose a valid response");
                    break;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates the if statement
        /// </summary>
        static void TestIf()
        {
            // ask for and get user answer
            Console.Write("Pick up the shiny thing? (y, n): ");
            char answer = char.ToLower(Console.ReadLine()[0]);

            // print appropriate message
            if (answer == 'y')
            {
                Console.WriteLine("You have the shiny object");
            }
            else if (answer == 'n')
            {
                Console.WriteLine("You don't have the shiny object");
            }
            else
            {
                Console.WriteLine("Please choose a valid response");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates the if and switch statements
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            TestIf();
            TestSwitch();
        }
    }
}
