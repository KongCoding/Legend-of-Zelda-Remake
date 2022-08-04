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
    class LinkUpIdleState : ILinkState
    {
        private ISprite linkSprite;
        private Link link;
        private ILevel level;
        public int Width { get; set; }
        public int Height { get; set; }

        public LinkUpIdleState(Link link, ILevel level)
        {
            this.link = link;
            linkSprite = LinkSpriteFactory.Instance.CreateLinkIdleUpSprite();
            this.level = level;
            this.Width = linkSprite.Width;
            this.Height = linkSprite.Height;
            this.link.Direction = Direction.UP;
            this.link.IsAttacking = false;
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
            level.Projectiles.Add(new Bomb((int)link.Position.X, ((int)link.Position.Y - linkSprite.Height)));
        }

        public void Attack()
        {
            link.State = new LinkUpAttackState(link, level);
        }

        public void Run()
        {
            link.State = new LinkUpRunState(link, level);
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
            //Do nothing: Link is already in this State.
        }

        public void Update()
        {
            linkSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            linkSprite.Draw(spriteBatch, link.Position);
        }
    }
}
