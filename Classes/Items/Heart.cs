using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    class Heart : IItem
    {
        private Vector2 position;
        private ISprite heartSprite;
        public bool Picked { get; set; }

        public Heart(int x, int y)
        {
            position.X = x;
            position.Y = y;
            heartSprite = ItemSpriteFactory.Instance.CreateHeartSprite();
            this.Picked = false;
        }

        public void IsPicked()
        {
            this.Picked = true;
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, heartSprite.Width, heartSprite.Height);
        }
        public void CollidedWithLink(IPlayer link)
        {
            // or change state?
            link.PickUpItem();
        }
        public void Update()
        {
            heartSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            heartSprite.Draw(spriteBatch, position);
        }
    }
}
