using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class RightMovingGelState : IEnemyState
    {
        private Gel gel;
        private ISprite gelSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public RightMovingGelState(Gel gel)
        {
            this.gel = gel;
            gelSprite = EnemySpriteFactory.Instance.CreateGelWalkSprite();
            initialPos = gel.InitialPos;
            this.Width = gelSprite.Width;
            this.Height = gelSprite.Height;
        }

        public void MoveUp()
        {
            gel.State = new UpMovingGelState(gel);
        }

        public void MoveDown()
        {
            gel.State = new DownMovingGelState(gel);
        }

        public void MoveLeft()
        {
            gel.State = new LeftMovingGelState(gel);
        }

        public void MoveRight()
        {

        }

        public void Bekilled()
        {
            gel.State = new DeadGelState(gel);
        }

        public void Update()
        {
            posX = gel.Position.X + 1;
            if (posX > initialPos.X + 40)
            {
                posX = initialPos.X + 40;
            }
            gel.Position = new Vector2(posX, gel.Position.Y);
            gelSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            gelSprite.Draw(spriteBatch, gel.Position);
        }
    }
}

