using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class BombExplodedState : IProjectileState
    {
        private ISprite bombSprite;
        private Bomb bomb;

        public BombExplodedState(Bomb bomb)
        {
            this.bomb = bomb;
            bombSprite = ProjectileSpriteFactory.Instance.CreateUseBombSprite();
        }

        public void UseProjectile()
        {
            //Do nothing: bomb is already in this state.
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            bombSprite.Draw(spriteBatch, bomb.Position);
        }

        public void Update()
        {
            bombSprite.Update();
        }

    }
}
