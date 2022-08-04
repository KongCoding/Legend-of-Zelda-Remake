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
    class LinkLeftAttackState : ILinkState
    {
        private ISprite linkSprite;
        private Link link;
        private ILevel level;
        private int timer = 60;
        public int Width { get; set; }
        public int Height { get; set; }

        public LinkLeftAttackState(Link link, ILevel level)
        {
            this.link = link;
            linkSprite = LinkSpriteFactory.Instance.CreateLinkAttackLeftSprite();
            this.level = level;
            this.Width = linkSprite.Width;
            this.Height = linkSprite.Height;
            this.link.Direction = Direction.LEFT;
            this.link.IsAttacking = true;
        }

        public void TakeDamage()
        {
            level.Link = new DamagedLink(link, level);
        }

        public void PickUpItem()
        {
            link.State = new LinkPickUpState(link, level);
        }

        public void UseBomb()
        {
            //Do nothing. Link cannot use item in this state.
        }

        public void Attack()
        {
            if (timer <= 50)
            {
                link.State = new LinkLeftAttackState(link, level);
            }
        }

        public void Run()
        {
            link.State = new LinkLeftRunState(link, level);
        }

        public void Die()
        {
            link.State = new LinkDeadState(link, level);
        }

        public void FaceDown()
        {
            link.State = new LinkDownIdleState(link, level);
        }

        public void FaceLeft()
        {
            link.State = new LinkLeftIdleState(link, level);
        }

        public void FaceRight()
        {
            link.State = new LinkRightIdleState(link, level);
        }

        public void FaceUp()
        {
            link.State = new LinkUpIdleState(link, level);
        }

        public void Update()
        {
            timer--;
            if (timer == 0)
            {
                link.State = new LinkLeftIdleState(link, level);
            }
            linkSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            linkSprite.Draw(spriteBatch, link.Position);
        }
    }
}
