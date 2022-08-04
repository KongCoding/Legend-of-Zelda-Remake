using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class RightMovingWallmasterState : IEnemyState
    {
        private Wallmaster wallmaster;
        private ISprite wallmasterSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public RightMovingWallmasterState(Wallmaster wallmaster)
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
            wallmaster.State = new DownMovingWallmasterState(wallmaster);
        }

        public void MoveLeft()
        {
            wallmaster.State = new LeftMovingWallmasterState(wallmaster);
        }

        public void MoveRight()
        {

        }

        public void Bekilled()
        {
            wallmaster.State = new DeadWallmasterState(wallmaster);
        }

        public void Update()
        {
            posX = wallmaster.Position.X + 1;
            if (posX > initialPos.X + 40)
            {
                posX = initialPos.X + 40;
            }
            wallmaster.Position = new Vector2(posX, wallmaster.Position.Y);
            wallmasterSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            wallmasterSprite.Draw(spriteBatch, wallmaster.Position);
        }
    }
}
