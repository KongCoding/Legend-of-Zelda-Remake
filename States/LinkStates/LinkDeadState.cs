﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class LinkDeadState : ILinkState
    {
        private ISprite linkSprite;
        private Link link;
        private ILevel level;
        public int Width { get; set; }
        public int Height { get; set; }

        public LinkDeadState(Link link, ILevel level)
        {
            this.link = link;
            linkSprite = EnemySpriteFactory.Instance.CreateEnemyCloudSprite();
            this.link.Direction = Direction.DOWN;
            this.level = level;
            this.Width = linkSprite.Width;
            this.Height = linkSprite.Height;
            this.link.IsAttacking = false;
        }

        public void TakeDamage()
        {
            //Do nothing: Link is dead.
        }

        public void Attack()
        {
            //Do nothing: Link is dead.
        }

        public void Die()
        {
            //Do nothing: Link is already in this state.
        }

        public void FaceDown()
        {
            //Do nothing: Link is dead.
        }

        public void FaceLeft()
        {
            //Do nothing: Link is dead.
        }

        public void FaceRight()
        {
            //Do nothing: Link is dead.
        }

        public void FaceUp()
        {
            //Do nothing: Link is dead.
        }

        public void Run()
        {
            //Do nothing: Link is dead.
        }

        public void PickUpItem()
        {
            //Do nothing: Link is dead.
        }

        public void UseBomb()
        {
            //Do nothing: Link is dead.
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
