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
    public class BoomerangIdleState : IProjectileState
    {
        private ISprite boomerangSprite;
        private Boomerang boomerang;

        public BoomerangIdleState(Boomerang boomerang)
        {
            this.boomerang = boomerang;
            boomerangSprite = ProjectileSpriteFactory.Instance.CreateBoomerangSprite();
        }

        public void UseProjectile()
        {
            boomerang.State = new BoomerangUsedState(boomerang);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            boomerangSprite.Draw(spriteBatch, boomerang.Position);
        }

        public void Update()
        {
            boomerangSprite.Update();
        }

    }
}
