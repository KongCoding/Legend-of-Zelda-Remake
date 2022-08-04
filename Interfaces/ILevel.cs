using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface ILevel
    {
        IPlayer Link { get; set; }
        IRoom Room { get; set; }
        List<IEnemy> Enemies { get; set; }
        List<IItem> Items { get; set; }
        List<IBlock> Blocks { get; set; }
        List<IDoor> Doors { get; set; }
        List<IWater> Water { get; set; }
        List<IWall> Walls { get; set; }
        List<ICharacter> Characters { get; set; }
        List<IProjectile> Projectiles { get; set; }
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
