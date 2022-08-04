using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Water : IWater
    {
        private Vector2 position;
        private ISprite waterSprite;
        public Rectangle Rectangle => new Rectangle((int)position.X, (int)position.Y, Sprite.Width, Sprite.Height);
        private static ISprite Sprite = ArtifactSpriteFactory.Instance.CreateWaterSprite();
        public Water(int x, int y)
        {
            position.X = x;
            position.Y = y;
            waterSprite = ArtifactSpriteFactory.Instance.CreateWaterSprite();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            waterSprite.Draw(spriteBatch, position);
        }

        public Rectangle GetRectangle()
        {
            return Rectangle;
        }

        public void Update()
        {
            waterSprite.Update();
        }

    }
}
