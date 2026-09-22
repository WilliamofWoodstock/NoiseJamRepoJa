using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SaudadeNichtswurdig
{
    internal class UI : GameObject
    {
        private bool button;
        public bool IsButton { get => button; }
        public UI(Texture2D texture, int x, int y, int width, int height, bool button) : base(texture, x, y, width, height)
        {
            this.button = button;
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
