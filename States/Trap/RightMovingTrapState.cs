using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sprint2
{
    public class RightMovingTrapState : IEnemyState
    {
        private Trap trap;
        private ISprite trapSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public RightMovingTrapState(Trap trap)
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
            trap.State = new DownMovingTrapState(trap);
        }

        public void MoveLeft()
        {
            trap.State = new LeftMovingTrapState(trap);
        }

        public void MoveRight()
        {

        }

        public void Bekilled()
        {
            trap.State = new DeadTrapState(trap);
        }

        public void Update()
        {
            posX = trap.Position.X + 1;
            if (posX > initialPos.X + 40)
            {
                posX = initialPos.X + 40;
            }
            trap.Position = new Vector2(posX, trap.Position.Y);
            trapSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            trapSprite.Draw(spriteBatch, trap.Position);
        }
    }
}
