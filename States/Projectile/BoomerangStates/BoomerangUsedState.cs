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
    public class BoomerangUsedState : IProjectileState
    {
        private ISprite boomerangSprite;
        private Boomerang boomerang;

        public BoomerangUsedState(Boomerang boomerang)
        {
            this.boomerang = boomerang;
            boomerangSprite = ProjectileSpriteFactory.Instance.CreateUseBoomerangSprite();
        }

        public void UseProjectile()
        {
            //Do nothing: boomerang is already in this state.
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
