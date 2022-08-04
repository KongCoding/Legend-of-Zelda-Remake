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
    public class LinkItemHandler
    {
        public static void HandleCollision(IPlayer link, IItem item)
        {
            
                item.CollidedWithLink(link);

        }
    }
}
