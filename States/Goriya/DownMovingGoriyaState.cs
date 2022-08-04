using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sprint2
{
    public class DownMovingGoriyaState : IEnemyState
    {
        private Goriya goriya;
        private ISprite goriyaSprite;
        private Vector2 initialPos;
        private float posY;
        public int Width { get; set; }
        public int Height { get; set; }

        public DownMovingGoriyaState(Goriya goriya)
        {
            this.goriya = goriya;
            initialPos = goriya.InitialPos;
            goriyaSprite = EnemySpriteFactory.Instance.CreateGoriyaWalkDownSprite();
            this.Width = goriyaSprite.Width;
            this.Height = goriyaSprite.Height;
        }

        public void MoveUp()
        {
            goriya.State = new UpMovingGoriyaState(goriya);
        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {
            goriya.State = new LeftMovingGoriyaState(goriya);
        }

        public void MoveRight()
        {
            goriya.State = new RightMovingGoriyaState(goriya);
        }

        public void Bekilled()
        {
            goriya.State = new DeadGoriyaState(goriya);
        }

        public void Update()
        {
            posY = goriya.Position.Y + 1;
            if (initialPos.Y + 40 < posY)
            {
                posY = initialPos.Y + 40;
            }

            goriya.Position = new Vector2(goriya.Position.X, posY);
            goriyaSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            goriyaSprite.Draw(spriteBatch, goriya.Position);
        }
    }
}
