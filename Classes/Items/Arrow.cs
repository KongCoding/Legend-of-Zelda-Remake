using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    class Arrow : IItem
    {
        private Vector2 position;
        private ISprite arrowSprite;
        public bool Picked { get; set; }

        public Arrow(int x, int y)
        {
            position.X = x;
            position.Y = y;
            arrowSprite = ItemSpriteFactory.Instance.CreateArrowSprite();
            this.Picked = false;
        }

        public void IsPicked()
        {
            this.Picked = true;
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, arrowSprite.Width, arrowSprite.Height);
        }

        public void Update()
        {
            arrowSprite.Update();
        }
        public void CollidedWithLink(IPlayer link)
        {
            // or change state?
            link.PickUpItem();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            arrowSprite.Draw(spriteBatch, position);
        }
    }
}
