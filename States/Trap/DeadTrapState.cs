﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class DeadTrapState : IEnemyState
    {
        private Trap trap;
        private ISprite trapSprite;
        public int Width { get; set; }
        public int Height { get; set; }

        public DeadTrapState(Trap trap)
        {
            this.trap = trap;
            trapSprite = EnemySpriteFactory.Instance.CreateEnemyCloudSprite();
            this.Width = trapSprite.Width;
            this.Height = trapSprite.Height;
        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {
           
        }

        public void MoveRight()
        {
            
        }

        public void Bekilled()
        {
            
        }

        public void Update()
        {
            trapSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            trapSprite.Draw(spriteBatch, trap.Position);
        }
    }
}
