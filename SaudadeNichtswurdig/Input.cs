using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SaudadeNichtswurdig
{
    internal static class Input
    {
        private static KeyboardState kbInput;
        private static KeyboardState previous;
        public static KeyboardState KeyboardInput { get => kbInput; }
        
        public static void Update(GameTime gameTime)
        {
            previous = kbInput;
            kbInput = Keyboard.GetState();
        }
    }
}
