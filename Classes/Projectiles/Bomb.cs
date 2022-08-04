using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class Bomb: IProjectile
    {
        public Vector2 Position { get; set; }
        public IProjectileState State { get; set; }
        public Rectangle Rectangle => new Rectangle((int)Position.X, (int)Position.Y, Sprite.Width, Sprite.Height);
        private static ISprite Sprite = ProjectileSpriteFactory.Instance.CreateBombSprite();

        public Bomb(int x, int y)
        {
            Position = new Vector2(x, y);
            State = new BombIdleState(this);
        }

        public void Update()
        {
            State.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
        }

        public void UseProjectile()
        {
            State.UseProjectile();
        }
        public Rectangle GetRectangle()
        {
            return Rectangle;
        }

    }
}
