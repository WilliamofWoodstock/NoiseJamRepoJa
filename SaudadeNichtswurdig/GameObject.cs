using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudadeNichtswurdig
{
    /// <summary>
    /// Basic common infrastructure shared by all game objects
    /// </summary>
    internal abstract class GameObject
    {
        protected Texture2D texture;
        private Rectangle box;
        /// <summary>
        /// The rectangle that contains the object's sprite
        /// </summary>
        public Rectangle Box { get => box; set => box = value; }

        /// <summary>
        /// The object's x position (based on their top left corner)
        /// </summary>
        public int X { get => box.X; set => box.X = value; }

        /// <summary>
        /// Creates a GameObject with the most basic information filled out
        /// </summary>
        /// <param name="texture">Texture being used to represent the GameObject</param>
        public GameObject(Texture2D texture)
        {
            this.texture = texture;
        }
        /// <summary>
        /// Creates a GameObject with the most basic information filled out
        /// </summary>
        /// <param name="texture">Texture being used to represent the GameObject</param>
        /// <param name="box">Rectangle that will house their primary texture</param>
        public GameObject(Texture2D texture, Rectangle box)
        {
            this.texture = texture; this.box = box;
        }
        /// <summary>
        /// Creates a GameObject with the most basic information filled out
        /// </summary>
        /// <param name="texture">Texture being used to represent the GameObject</param>
        /// <param name="x">Starting x position of object (top left corner of sprite)</param>
        /// <param name="y">Starting y position of object (top left corner of sprite)</param>
        /// <param name="width">In-game width of sprite</param>
        /// <param name="height">In-game Height of sprite</param>
        public GameObject(Texture2D texture, int x, int y, int width, int height)
        {
            this.texture = texture; box = new Rectangle(x, y, width, height);
        }

        public abstract void Update(GameTime gameTime);
    }
}
