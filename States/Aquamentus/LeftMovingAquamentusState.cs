using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sprint2
{
    public class LeftMovingAquamentusState : IEnemyState
    {
        private Aquamentus aquamentus;
        private ISprite aquamentusSprite;
        private Vector2 initialPos;
        private float posX;
        public int Width { get; set; }
        public int Height { get; set; }

        public LeftMovingAquamentusState(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            initialPos = aquamentus.InitialPos;
            aquamentusSprite = EnemySpriteFactory.Instance.CreateAquamentusWalkLeftSprite();
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

        }

        public void MoveRight()
        {
            aquamentus.State = new RightMovingAquamentusState(aquamentus);
        }

        public void Bekilled()
        {
            aquamentus.State = new DeadAquamentusState(aquamentus);
        }

        public void Update()
        {
            posX = aquamentus.Position.X - 1;
            if (posX < initialPos.X - 40)
            {
                posX = initialPos.X - 40;
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