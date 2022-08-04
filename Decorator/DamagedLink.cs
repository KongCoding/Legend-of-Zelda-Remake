using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class DamagedLink : IPlayer
    {
        private ILevel level;
        private IPlayer decoratedLink;
        private int timer = 30;
        public Direction Direction { get; set; }
        public bool IsAttacking { get; set; }

        public DamagedLink(IPlayer link, ILevel level) 
        {
            this.decoratedLink = link;
            this.level = level;
        }

        public void Attack()
        {
            decoratedLink.Attack();
        }

        public void Die()
        {
            decoratedLink.Die();
        }

        public void FaceDown()
        {
            decoratedLink.FaceDown();
        }

        public void FaceLeft()
        {
            decoratedLink.FaceLeft();
        }

        public void FaceRight()
        {
            decoratedLink.FaceRight();
        }

        public void FaceUp()
        {
            decoratedLink.FaceUp();
        }

        public void PickUpItem()
        {
            decoratedLink.PickUpItem();
        }

        public void Run()
        {
            decoratedLink.Run();
        }

        public void TakeDamage()
        {
            //Does not take damage in current state.
        }

        public void Update()
        {
            timer--;
            if(timer == 0)
            {
                RemoveDecorator();
            }
            decoratedLink.Update();
        }

        private void RemoveDecorator()
        {
            level.Link = decoratedLink;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (timer %10 <7)
            {
                decoratedLink.Draw(spriteBatch);
            }
        }

        public Rectangle GetRectangle()
        {
            return decoratedLink.GetRectangle();
        }
    }
}
