using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sprint2
{
    public class RightMovingAquamentusState : IEnemyState
    {
        private Aquamentus aquamentus;
        private ISprite aquamentusSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public RightMovingAquamentusState(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            initialPos = aquamentus.InitialPos;
            aquamentusSprite = EnemySpriteFactory.Instance.CreateAquamentusWalkRightSprite();
            this.Width = aquamentusSprite.Width;
            this.Height = aquamentusSprite.Height;
        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {
            aquamentus.State = new LeftMovingAquamentusState(aquamentus);
        }

        public void MoveRight()
        {

        }

        public void Bekilled()
        {
            aquamentus.State = new DeadAquamentusState(aquamentus);
        }

        public void Update()
        {
            posX = aquamentus.Position.X + 1;
            if (posX > initialPos.X + 40)
            {
                posX = initialPos.X + 40;
            }
            aquamentus.Position = new Vector2(posX, aquamentus.Position.Y);
            aquamentusSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            aquamentusSprite.Draw(spriteBatch, aquamentus.Position);
        }
    }
}
