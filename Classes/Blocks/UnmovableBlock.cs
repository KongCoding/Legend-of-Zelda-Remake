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
    public class UnmovableBlock : IWall
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public UnmovableBlock(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(x, y, width, height);
        }
        public void CollidedWithLink(IPlayer link, Collision.Direction direction)
        {
            LinkWallHandler.UpateLocation(link, this, direction);
        }
        public void Update()
        {
            
        }
    }
}
