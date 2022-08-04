using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class LeftMovingStalfosState : IEnemyState
    {
        private Stalfos stalfos;
        private ISprite stalfosSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public LeftMovingStalfosState(Stalfos stalfos)
        {
            this.stalfos = stalfos;
            initialPos = stalfos.InitialPos;
            stalfosSprite = EnemySpriteFactory.Instance.CreateStalfosWalkSprite();
            this.Width = stalfosSprite.Width;
            this.Height = stalfosSprite.Height;
        }

        public void MoveUp()
        {
            stalfos.State = new UpMovingStalfosState(stalfos);
        }

        public void MoveDown()
        {
            stalfos.State = new DownMovingStalfosState(stalfos);
        }

        public void MoveLeft()
        {

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
            posX = stalfos.Position.X - 1;
            if (posX < initialPos.X - 40)
            {
                posX = initialPos.X - 40;
            }
            stalfos.Position = new Vector2(posX, stalfos.Position.Y);
            stalfosSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            stalfosSprite.Draw(spriteBatch, stalfos.Position);
        }
    }
}
