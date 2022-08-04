using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Level : ILevel
    {
        public IPlayer Link { get; set; }
        public IRoom Room { get; set; }
        public List<IEnemy> Enemies { get; set; }
        public List<IItem> Items { get; set; }
        public List<IBlock> Blocks { get; set; }
        public List<IWater> Water { get; set; }
        public List<IDoor> Doors { get; set; }
        public List<IWall> Walls { get; set; }
        public List<ICharacter> Characters { get; set; }
        public List<IProjectile> Projectiles { get; set; }

        public Level()
        {
            Link = null;
            Room = null;
            Enemies = new List<IEnemy>();
            Items = new List<IItem>();
            Blocks = new List<IBlock>();
            Water = new List<IWater>();
            Doors = new List<IDoor>();
            Walls = new List<IWall>();
            Characters = new List<ICharacter>();
            Projectiles = new List<IProjectile>();
        }

        public void Update()
        {
            Link.Update();
            Room.Update();
            foreach (IEnemy enemy in Enemies)
                enemy.Update();
            foreach (IItem item in Items)
            {
                item.Update();
                if (item.Picked == true)
                {
                    Items.Remove(item);
                }
            }
            foreach (IBlock block in Blocks)
                block.Update();
            foreach (IWater water in Water)
                water.Update();
            foreach (IDoor door in Doors)
                door.Update();
            foreach (IWall wall in Walls)
                wall.Update();
            foreach (ICharacter character in Characters)
                character.Update();
            foreach (IProjectile projectile in Projectiles)
                projectile.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            Room.Draw(spriteBatch);
            foreach (IEnemy enemy in Enemies)
                enemy.Draw(spriteBatch);
            foreach (IItem item in Items)
                item.Draw(spriteBatch);
            foreach (IBlock block in Blocks)
                block.Draw(spriteBatch);
            foreach (IWater water in Water)
                water.Draw(spriteBatch);
            foreach (IDoor door in Doors)
                door.Draw(spriteBatch);
            foreach (IWall wall in Walls)
                wall.Draw(spriteBatch);
            foreach (ICharacter character in Characters)
                character.Draw(spriteBatch);
            foreach (IProjectile projectile in Projectiles)
                projectile.Draw(spriteBatch);
            Link.Draw(spriteBatch);
        }
    }
}
