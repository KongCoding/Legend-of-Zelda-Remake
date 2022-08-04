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
    class LinkLeftRunState : ILinkState
    {
        private ISprite linkSprite;
        private Link link;
        private float posX;
        private ILevel level;
        public int Width { get; set; }
        public int Height { get; set; }

        public LinkLeftRunState(Link link, ILevel level)
        {
            this.link = link;
            linkSprite = LinkSpriteFactory.Instance.CreateLinkWalkLeftSprite();
            this.level = level;
            this.Width = linkSprite.Width;
            this.Height = linkSprite.Height;
            this.link.Direction = Direction.LEFT;
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
            //Do nothing. Link cannot use item in this state.
        }

        public void Attack()
        {
            link.State = new LinkLeftAttackState(link, level);
        }

        public void Run()
        {
            
            //Do nothing: Link is already in this State.
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
            posX = link.Position.X - 1;
            link.Position = new Vector2(posX, link.Position.Y);
            linkSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            linkSprite.Draw(spriteBatch, link.Position);
        }
    }
}
