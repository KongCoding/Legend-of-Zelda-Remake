using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    class HeartContainer : IItem
    {
        private Vector2 position;
        private ISprite heartContainerSprite;
        public bool Picked { get; set; }

        public HeartContainer(int x, int y)
        {
            position.X = x;
            position.Y = y;
            heartContainerSprite = ItemSpriteFactory.Instance.CreateHeartContainerSprite();
            this.Picked = false;
        }

        public void IsPicked()
        {
            this.Picked = true;
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)position.X, (int)position.Y, heartContainerSprite.Width, heartContainerSprite.Height);
        }
        public void CollidedWithLink(IPlayer link)
        {
            // or change state?
            link.PickUpItem();
        }
        public void Update()
        {
            heartContainerSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            heartContainerSprite.Draw(spriteBatch, position);
        }
    }
}
