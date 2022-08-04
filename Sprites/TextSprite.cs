using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class TextSprite
    {
        private SpriteFont text;

        public TextSprite(SpriteFont font)
        {
            text = font;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(text, "Press Arrow Keys or WASD to Change Link's Facing Direction and Press Again to Move Link\nPress Z or N to Attack using Sword\nPress Number Key 1 to Use Bomb\nPrese Number Key 2 to Use Boomerang\nPress E to Be Damaged\nPress TY to Move Aquamentus Left and Right\nPress UIOP to Move Goriya\nPress GHJK to Move Wallmaster\nPress L to Move Keese Up\nPress R to Reset the Game\nPress Q to Quit the Game\nPress M to Use the Map and Click to Swicth to other Room", location, Color.White);
            spriteBatch.End();
        }
    }
}
