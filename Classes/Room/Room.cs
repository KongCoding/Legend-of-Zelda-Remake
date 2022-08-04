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
    public class Room : IRoom
    {
        public int RoomNum { get; set; }
        private Vector2 position;
        private ISprite roomSprite;

        public Room(int num)
        {
            this.RoomNum = num;
            position = new Vector2(0, 0);
            roomSprite = RoomSpriteFactory.Instance.CreateRoomSprite(num);
        }

        public void Update()
        {
            roomSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            roomSprite.Draw(spriteBatch, position);
        }
    }
}
