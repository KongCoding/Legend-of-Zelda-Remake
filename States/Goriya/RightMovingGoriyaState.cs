using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sprint2
{
    public class RightMovingGoriyaState : IEnemyState
    {
        private Goriya goriya;
        private ISprite goriyaSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public RightMovingGoriyaState(Goriya goriya)
        {
            this.goriya = goriya;
            initialPos = goriya.InitialPos;
            goriyaSprite = EnemySpriteFactory.Instance.CreateGoriyaWalkRightSprite();
            this.Width = goriyaSprite.Width;
            this.Height = goriyaSprite.Height;
        }

        public void MoveUp()
        {
            goriya.State = new UpMovingGoriyaState(goriya);
        }

        public void MoveDown()
        {
            goriya.State = new DownMovingGoriyaState(goriya);
        }

        public void MoveLeft()
        {
            goriya.State = new LeftMovingGoriyaState(goriya);
        }

        public void MoveRight()
        {

        }

        public void Bekilled()
        {
            goriya.State = new DeadGoriyaState(goriya);
        }

        public void Update()
        {
            posX = goriya.Position.X + 1;
            if (posX > initialPos.X + 40)
            {
                posX = initialPos.X + 40;
            }
            goriya.Position = new Vector2(posX, goriya.Position.Y);
            goriyaSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            goriyaSprite.Draw(spriteBatch, goriya.Position);
        }
    }
}
