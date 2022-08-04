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
    public interface IProjectileState
    {
        void UseProjectile();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
