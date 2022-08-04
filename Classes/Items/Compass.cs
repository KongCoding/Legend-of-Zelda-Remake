using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    class Compass : IItem
    {
        private Vector2 position;
        private ISprite compassSprite;
        public bool Picked { get; set; }

        public Compass(int x, int y)
        {
            position.X = x;
            position.Y = y;
            compassSprite = ItemSpriteFactory.Instance.CreateCompassSprite();
            this.Picked = false;
        }

        public void IsPicked()
        {
            this.Picked = true;
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, compassSprite.Width, compassSprite.Height);
        }
        public void CollidedWithLink(IPlayer link)
        {
            // or change state?
            link.PickUpItem();
        }
        public void Update()
        {
            compassSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            compassSprite.Draw(spriteBatch, position);
        }
    }
}
