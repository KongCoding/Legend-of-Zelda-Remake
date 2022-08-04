using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class DeadWallmasterState : IEnemyState
    {
        private Wallmaster wallmaster;
        private ISprite wallmasterSprite;
        public int Width { get; set; }
        public int Height { get; set; }

        public DeadWallmasterState(Wallmaster wallmaster)
        {
            this.wallmaster = wallmaster;
            wallmasterSprite = EnemySpriteFactory.Instance.CreateEnemyCloudSprite();
            this.Width = wallmasterSprite.Width;
            this.Height = wallmasterSprite.Height;
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
            wallmasterSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            wallmasterSprite.Draw(spriteBatch, wallmaster.Position);
        }
    }
}
