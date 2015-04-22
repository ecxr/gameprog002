using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DieExample
{
    /// <summary>
    /// A die
    /// </summary>
    class Die
    {
        #region Fields

        int numSides;
        int topSide;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of sides
        /// </summary>
        public int NumSides
        {
            get { return numSides; }
        }

        /// <summary>
        /// Gets the top side
        /// </summary>
        public int TopSide
        {
            get { return topSide; }
        }

        #endregion
    }
}
