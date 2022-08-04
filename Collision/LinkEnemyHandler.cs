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
    class LinkEnemyHandler
    {
        public static void HandleCollision(IPlayer link, IEnemy enemy, Direction direction)
        {
            
                enemy.CollidedWithLink(link, direction);
            
        }
    }
}
