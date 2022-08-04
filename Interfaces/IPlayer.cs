using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IPlayer
    {
        Direction Direction { get; set; }
        Boolean IsAttacking { get; set; }

        void TakeDamage();
        void Die();
        void FaceUp();
        void FaceDown();
        void FaceLeft();
        void FaceRight();
        void Run();
        void Attack();
        void PickUpItem();
        Rectangle GetRectangle();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
