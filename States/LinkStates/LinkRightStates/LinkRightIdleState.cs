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
    class LinkRightIdleState : ILinkState
    {
        private ISprite linkSprite;
        private Link link;
        private ILevel level;
        public int Width { get; set; }
        public int Height { get; set; }

        public LinkRightIdleState(Link link, ILevel level)
        {
            this.link = link;
            linkSprite = LinkSpriteFactory.Instance.CreateLinkIdleRightSprite();
            this.level = level;
            this.Width = linkSprite.Width;
            this.Height = linkSprite.Height;
            this.link.Direction = Direction.RIGHT;
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
            level.Projectiles.Add(new Bomb((int)link.Position.X + 8, (int)link.Position.Y));
        }

        public void Attack()
        {
            link.State = new LinkRightAttackState(link, level);
        }

        public void Run()
        {
            link.State = new LinkRightRunState(link, level);
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
            //Do nothing: Link is already in this State.
        }

        public void FaceUp()
        {
            link.State = new LinkUpIdleState(link, level);
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
