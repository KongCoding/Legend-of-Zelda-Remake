using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class UpMovingStalfosState : IEnemyState
    {
        private Stalfos stalfos;
        private ISprite stalfosSprite;
        private Vector2 initialPos;
        private float posY;
        public int Width { get; set; }
        public int Height { get; set; }

        public UpMovingStalfosState(Stalfos stalfos)
        {
            this.stalfos = stalfos;
            initialPos = stalfos.InitialPos;
            stalfosSprite = EnemySpriteFactory.Instance.CreateStalfosWalkSprite();
            this.Width = stalfosSprite.Width;
            this.Height = stalfosSprite.Height;
        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {
            stalfos.State = new DownMovingStalfosState(stalfos);
        }

        public void MoveLeft()
        {
            stalfos.State = new LeftMovingStalfosState(stalfos);
        }

        public void MoveRight()
        {
            stalfos.State = new RightMovingStalfosState(stalfos);
        }

        public void Bekilled()
        {
            stalfos.State = new DeadStalfosState(stalfos);
        }

        public void Update()
        {
            posY = stalfos.Position.Y - 1;
            if (initialPos.Y - 40 > posY)
            {
                posY = initialPos.Y - 40;
            }

            stalfos.Position = new Vector2(stalfos.Position.X, posY);
            stalfosSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            stalfosSprite.Draw(spriteBatch, stalfos.Position);
        }
    }
}
