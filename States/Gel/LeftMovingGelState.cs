using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class LeftMovingGelState : IEnemyState
    {
        private Gel gel;
        private ISprite gelSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public LeftMovingGelState(Gel gel)
        {
            this.gel = gel;
            initialPos = gel.InitialPos;
            gelSprite = EnemySpriteFactory.Instance.CreateGelWalkSprite();
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

        }

        public void MoveRight()
        {
            gel.State = new RightMovingGelState(gel);
        }

        public void Bekilled()
        {
            gel.State = new DeadGelState(gel);
        }

        public void Update()
        {
            posX = gel.Position.X - 1;
            if (posX < initialPos.X - 40)
            {
                posX = initialPos.X - 40;
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
