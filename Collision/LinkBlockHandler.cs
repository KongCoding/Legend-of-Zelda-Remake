using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Collision;
namespace Sprint2.Collision
{
    class LinkBlockHandler
    {
        public static void HandleCollision(IPlayer link, IBlock block, Direction direction)
        {
            block.CollidedWithLink(link, direction);
        }
        public static void UpateLocation(IPlayer link, IBlock block, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    link.Location = new Vector2(link.Location.X, block.Location.Y - link.GetRectangle().Height);
                    break;

                case Direction.LEFT:
                    link.Location = new Vector2(block.Location.X - link.GetRectangle().Width, link.Location.Y);
                    break;

                case Direction.RIGHT:
                    link.Location = new Vector2(block.Location.X + block.GetRectangle().Width, link.Location.Y);
                    break;

                case Direction.DOWN:
                    link.Location = new Vector2(link.Location.X, block.Location.Y + block.GetRectangle().Height);
                    break;
            }

        }
    }
}
