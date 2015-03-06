using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle
{
    /// <summary>
    ///  A class that inputs an angle and speed of a projectile and calculates its trajectory
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method coontaining the program message loop
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const float G = 9.8F;       // Acceleration due to gravity

            float theta = 0.0F;         // Angle in degrees
            double thetaRad = 0.0F;     // Angle in radians
            float speed = 0.0F;         // Initial speed
            float vox = 0.0F;           // x velocity at start
            float voy = 0.0F;           // y velocity at start
            float t = 0.0F;             // Time until shell reaches its apex
            float height = 0.0F;        // Height of shell at apex
            float dx = 0.0F;            // Distance shell travels on the horiz. x-axis

            Console.WriteLine("This program calculates the maximum height and distance travelled by a shell.");
            Console.WriteLine();

            // Get the inital angle
            Console.Write("Firing angle: ");
            theta = float.Parse(Console.ReadLine());
            thetaRad = (Math.PI / 180) * theta;  // convert to radians

            // Get the initial velocity
            Console.Write("Firing speed: ");
            speed = float.Parse(Console.ReadLine());

            // Calculate height and distance
            vox = speed * (float)Math.Cos(thetaRad);    // x velocity
            voy = speed * (float)Math.Sin(thetaRad);    // y velocity
            t = voy / G;                                // time till apex
            height = voy * voy / (2 * G);               // height of shell at apex
            dx = voy * 2 * t;                           // horiz distance

            Console.WriteLine("Maximum shell height: " + height);
            Console.WriteLine("Horizontal distsance: " + dx);

            Console.WriteLine();
        }
    }
}
