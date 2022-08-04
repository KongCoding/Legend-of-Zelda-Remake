using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    class Fairy : IItem
    {
        private Vector2 position;
        private ISprite fairySprite;
        public bool Picked { get; set; }

        public Fairy(int x, int y)
        {
            position.X = x;
            position.Y = y;
            fairySprite = ItemSpriteFactory.Instance.CreateFairySprite();
            this.Picked = false;
        }

        public void IsPicked()
        {
            this.Picked = true;
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, fairySprite.Width, fairySprite.Height);
        }
        public void CollidedWithLink(IPlayer link)
        {
            // or change state?
            link.PickUpItem();
        }
        public void Update()
        {
            fairySprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            fairySprite.Draw(spriteBatch, position);
        }
    }
}
