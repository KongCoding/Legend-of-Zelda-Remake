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
    public interface IDoor
    {
        DoorState DoorState { get; set; }
        void Up();
        void Down();
        void Left();
        void Right();
        void Open();
        void CollidedWithLink(IPlayer link, Collision.Direction direction);
        void Locked();
        void Closed();
        void InitializeState(int direction, int doorState);
        Rectangle GetRectangle();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
