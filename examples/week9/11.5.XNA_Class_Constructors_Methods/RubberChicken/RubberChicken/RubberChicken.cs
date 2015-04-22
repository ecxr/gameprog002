using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RubberChicken
{
    /// <summary>
    /// A rubber chicken
    /// </summary>
    class RubberChicken
    {
        #region Fields

        bool active = true;
        int damage;

        // drawing and moving support
        Texture2D sprite;
        Rectangle drawRectangle;
        Vector2 velocity;

        #endregion

        #region Properties

        /// <summary>
        /// Gets and sets whether the rubber chicken is active
        /// </summary>
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        /// <summary>
        /// Gets the collision rectangle for the rubber chicken
        /// </summary>
        public Rectangle CollisionRectangle
        {
            get { return drawRectangle; }
        }

        /// <summary>
        /// Gets the damage the rubber chicken inflicts
        /// </summary>
        public int Damage
        {
            get { return damage; }
        }

        #endregion
    }
}
