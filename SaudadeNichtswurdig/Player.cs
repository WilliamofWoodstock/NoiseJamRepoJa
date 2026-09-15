using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace SaudadeNichtswurdig
{
    enum PlayerStates
    {
        FaceLeft,
        FaceRight
    }

    internal class Player : GameObject
    {
        int widthOfSingleSprite;
        public Player(Texture2D texture, int x, int y, int width, int height) : base(texture)
        {
            Box = new Rectangle(x, y, width, height);
        }
        public override void Update(GameTime gameTime)
        {
            KeyboardState input = Keyboard.GetState(); 
        }
    }
}
