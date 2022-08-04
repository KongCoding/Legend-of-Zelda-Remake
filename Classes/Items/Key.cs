using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    class Key : IItem
    {
        private Vector2 position;
        private ISprite keySprite;
        public bool Picked { get; set; }

        public Key(int x, int y)
        {
            position.X = x;
            position.Y = y;
            keySprite = ItemSpriteFactory.Instance.CreateKeySprite();
            this.Picked = false;
        }

        public void IsPicked()
        {
            this.Picked = true;
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, keySprite.Width, keySprite.Height);
        }
        public void CollidedWithLink(IPlayer link)
        {
            // or change state?
            link.PickUpItem();
        }
        public void Update()
        {
            keySprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            keySprite.Draw(spriteBatch, position);
        }
    }
}
