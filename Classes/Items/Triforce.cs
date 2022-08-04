using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    class Triforce : IItem
    {
        private Vector2 position;
        private ISprite triforceSprite;
        public bool Picked { get; set; }

        public Triforce(int x, int y)
        {
            position.X = x;
            position.Y = y;
            triforceSprite = ItemSpriteFactory.Instance.CreateTriforceSprite();
            this.Picked = false;
        }

        public void IsPicked()
        {
            this.Picked = true;
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, triforceSprite.Width, triforceSprite.Height);
        }
        public void CollidedWithLink(IPlayer link)
        {
            // or change state?
            link.PickUpItem();
        }
        public void Update()
        {
            triforceSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            triforceSprite.Draw(spriteBatch, position);
        }
    }
}
