using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class DeadKeeseState : IEnemyState
    {
        private Keese keese;
        private ISprite keeseSprite;
        public int Width { get; set; }
        public int Height { get; set; }

        public DeadKeeseState(Keese keese)
        {
            this.keese = keese;
            keeseSprite = EnemySpriteFactory.Instance.CreateEnemyCloudSprite();
            this.Width = keeseSprite.Width;
            this.Height = keeseSprite.Height;
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
            keeseSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            keeseSprite.Draw(spriteBatch, keese.Position);
        }
    }
}
