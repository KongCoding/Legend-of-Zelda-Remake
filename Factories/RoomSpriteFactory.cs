using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class RoomSpriteFactory
    {
        private Texture2D roomSpritesheet;

        private static RoomSpriteFactory instance;

        public static RoomSpriteFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomSpriteFactory();
                }
                return instance;
            }
        }

        private RoomSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            roomSpritesheet = content.Load<Texture2D>("RoomSprites/Room");
        }

        public ISprite CreateRoomSprite(int roomNum)
        {
            return new BackgroundSprite(roomSpritesheet, roomNum, 6, 6);
        }

    }
}
