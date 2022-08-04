using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Gel : IEnemy
    {
        public IEnemyState State { get; set; }
        public Vector2 InitialPos { get; set; }
        public Vector2 Position { get; set; }
        public Direction Direction { get; set; }
        private Rectangle Rectangle => new Rectangle((int)Position.X, (int)Position.Y, State.Width, State.Height);
        public Gel(int x, int y)
        {
            InitialPos = new Vector2(x, y);
            Position = new Vector2(x, y);
            State = new LeftMovingGelState(this);
            Direction = Direction.LEFT;
        }

        public void Bekilled()
        {
            State.Bekilled();
        }

        public void MoveUp()
        {
            State.MoveUp();
        }

        public void MoveDown()
        {
            State.MoveDown();
        }

        public void MoveLeft()
        {
            State.MoveLeft();
        }

        public void MoveRight()
        {
            State.MoveRight();
        }
        public void SwitchDirection()
        {
            if (this.Direction == Direction.LEFT)
            {
                Direction = Direction.RIGHT;
                State.MoveRight();
            }
            else if (this.Direction == Direction.RIGHT)
            {
                Direction = Direction.LEFT;
                State.MoveLeft();
            }
            else if (this.Direction == Direction.UP)
            {
                Direction = Direction.DOWN;
                State.MoveDown();
            }
            else
            {
                Direction = Direction.UP;
                State.MoveUp();
            }
        }
        public void CollidedWithLink(IPlayer link, Collision.Direction direction)
        {

            if (link.IsAttacking && direction.Equals(link.Direction))
            {
                Bekilled();
            }
            else
            {
                // or change state?
                link.TakeDamage();
            }
        }

        public void Update() { 

            State.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
        }

        public Rectangle GetRectangle()
        {
            return Rectangle;
        }
    }
}
