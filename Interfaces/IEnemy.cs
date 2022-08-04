using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Collision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IEnemy
    {

        void Bekilled();
        
        void MoveDown();

        void MoveUp();

        void MoveLeft();
        void CollidedWithLink(IPlayer link, Collision.Direction direction);
        void MoveRight();
        void Update();

        Rectangle GetRectangle();
        void Draw(SpriteBatch spriteBatch);
    }
}
