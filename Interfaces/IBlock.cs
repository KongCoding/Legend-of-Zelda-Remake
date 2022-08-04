using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.Collision;

namespace Sprint2
{
    public interface IBlock
    {
        void CollidedWithLink(IPlayer link, Collision.Direction direction);
        IBlockState State { get; set; }
        Vector2 Position { get; set; }
        bool IsMovable { get; set; }
        void Move();
        Rectangle GetRectangle();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
