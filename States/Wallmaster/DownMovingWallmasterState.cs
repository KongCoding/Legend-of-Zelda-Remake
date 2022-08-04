using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sprint2
{
    public class DownMovingWallmasterState : IEnemyState
    {
        private Wallmaster wallmaster;
        private ISprite wallmasterSprite;
        private Vector2 initialPos;
        private float posY;
        public int Width { get; set; }
        public int Height { get; set; }

        public DownMovingWallmasterState(Wallmaster wallmaster)
        {
            this.wallmaster = wallmaster;
            initialPos = wallmaster.InitialPos;
            wallmasterSprite = EnemySpriteFactory.Instance.CreateWallmasterWalkDownRightSprite();
            this.Width = wallmasterSprite.Width;
            this.Height = wallmasterSprite.Height;
        }

        public void MoveUp()
        {
            wallmaster.State = new UpMovingWallmasterState(wallmaster);
        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {
            wallmaster.State = new LeftMovingWallmasterState(wallmaster);
        }

        public void MoveRight()
        {
            wallmaster.State = new RightMovingWallmasterState(wallmaster);
        }

        public void Bekilled()
        {
            wallmaster.State = new DeadWallmasterState(wallmaster);
        }

        public void Update()
        {
            posY = wallmaster.Position.Y + 1;
            if (initialPos.Y + 40 < posY)
            {
                posY = initialPos.Y + 40;
            }

            wallmaster.Position = new Vector2(wallmaster.Position.X, posY);
            wallmasterSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            wallmasterSprite.Draw(spriteBatch, wallmaster.Position);
        }
    }
}
