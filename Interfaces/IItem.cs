using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IItem
    {
        bool Picked { get; set; }

        void IsPicked();
        Rectangle GetRectangle();
        void Update();
        void Draw(SpriteBatch spriteBatch);
        void CollidedWithLink(IPlayer link);
    }
}
