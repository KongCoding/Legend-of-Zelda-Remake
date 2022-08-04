using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class LeftMovingKeeseState : IEnemyState
    {
        private Keese keese;
        private ISprite keeseSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public LeftMovingKeeseState(Keese keese)
        {
            this.keese = keese;
            initialPos = keese.InitialPos;
            keeseSprite = EnemySpriteFactory.Instance.CreateKeeseWalkSprite();
            this.Width = keeseSprite.Width;
            this.Height = keeseSprite.Height;
        }

        public void MoveUp()
        {
            keese.State = new UpMovingKeeseState(keese);
        }

        public void MoveDown()
        {
            keese.State = new DownMovingKeeseState(keese);
        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {
            keese.State = new RightMovingKeeseState(keese);
        }

        public void Bekilled()
        {
            keese.State = new DeadKeeseState(keese);
        }

        public void Update()
        {
            posX = keese.Position.X - 1;
            if (posX < initialPos.X - 40)
            {
                posX = initialPos.X - 40;
            }
            keese.Position = new Vector2(posX, keese.Position.Y);
            keeseSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            keeseSprite.Draw(spriteBatch, keese.Position);
        }
    }
}
