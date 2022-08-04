using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2.Collision;

namespace Sprint2
{
    public enum Direction
    {
        UP, DOWN, LEFT, RIGHT
    }
    public class Link: IPlayer
    {
        private int xPosition;
        private int yPosition;


        public ILinkState State { get; set; }
        public Vector2 Position { get; set; }

        public Direction Direction { get; set; }
        public Boolean IsAttacking { get; set; }

        private ILevel level;

        

        public Link(int x, int y, ILevel level)
        {
            this.level = level;
            Position = new Vector2(x, y);
            State = new LinkDownIdleState(this,level);
            Direction = Direction.DOWN;
            xPosition = x;
            yPosition = y;
        }

        public void TakeDamage()
        {
            State.TakeDamage();
        }
        public void Die()
        {
            State.Die();
        }

        public void FaceUp()
        {
            State.FaceUp();
        }

        public void FaceDown()
        {
            State.FaceDown();
        }
        public void FaceLeft()
        {
            State.FaceLeft();
        }

        public void FaceRight()
        {
            State.FaceRight();
        }

        public void Run()
        {
            State.Run();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void PickUpItem()
        {
            State.PickUpItem();
        }


        public Rectangle GetRectangle()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, State.Width, State.Height);
        }

        public void Update()
        {
            State.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
        }
    }
}
