﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class DeadGelState : IEnemyState
    {
        private Gel gel;
        private ISprite gelSprite;
        public int Width { get; set; }
        public int Height { get; set; }

        public DeadGelState(Gel gel)
        {
            this.gel = gel;
            gelSprite = EnemySpriteFactory.Instance.CreateEnemyCloudSprite();
            this.Width = gelSprite.Width;
            this.Height = gelSprite.Height;
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
            gelSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            gelSprite.Draw(spriteBatch, gel.Position);
        }
    }
}
