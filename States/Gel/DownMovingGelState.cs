using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class DownMovingGelState : IEnemyState
    {
        private Gel gel;
        private ISprite gelSprite;
        private Vector2 initialPos;
        private float posY;
        public int Width { get; set; }
        public int Height { get; set; }

        public DownMovingGelState(Gel gel)
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

        }

        public void MoveLeft()
        {
            gel.State = new LeftMovingGelState(gel);
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
            posY = gel.Position.Y + 1;
            if (initialPos.Y + 40 < posY)
            {
                posY = initialPos.Y + 40;
            }

            gel.Position = new Vector2(gel.Position.X, posY);
            gelSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            gelSprite.Draw(spriteBatch, gel.Position);
        }
    }
}
