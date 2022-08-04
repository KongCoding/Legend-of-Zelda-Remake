using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sprint2
{
    public class DownMovingTrapState : IEnemyState
    {
        private Trap trap;
        private ISprite trapSprite;
        private Vector2 initialPos;
        private float posY;
        public int Width { get; set; }
        public int Height { get; set; }

        public DownMovingTrapState(Trap trap)
        {
            this.trap = trap;
            initialPos = trap.InitialPos;
            trapSprite = EnemySpriteFactory.Instance.CreateTrapSprite();
            this.Width = trapSprite.Width;
            this.Height = trapSprite.Height;
        }

        public void MoveUp()
        {
            trap.State = new UpMovingTrapState(trap);
        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {
            trap.State = new LeftMovingTrapState(trap);
        }

        public void MoveRight()
        {
            trap.State = new RightMovingTrapState(trap);
        }

        public void Bekilled()
        {
            trap.State = new DeadTrapState(trap);
        }

        public void Update()
        {
            posY = trap.Position.Y + 1;
            if (initialPos.Y + 40 < posY)
            {
                posY = initialPos.Y + 40;
            }

            trap.Position = new Vector2(trap.Position.X, posY);
            trapSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            trapSprite.Draw(spriteBatch, trap.Position);
        }
    }
}
