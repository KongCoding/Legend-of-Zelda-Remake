using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IRoom
    {
        int RoomNum { get; set; }
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
