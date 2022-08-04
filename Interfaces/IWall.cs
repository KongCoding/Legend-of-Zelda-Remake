using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Collision;

namespace Sprint2
{
    public interface IWall
    {
        Rectangle GetRectangle();
        void Update();
        void Draw(SpriteBatch spriteBatch);
        void CollidedWithLink(IPlayer link, Collision.Direction direction);
    }
}