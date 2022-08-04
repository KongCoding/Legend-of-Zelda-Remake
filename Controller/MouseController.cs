using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class MouseController : IController
    {
        private int width;
        private int height;
        private int i;
        public bool IsMapUsed { get; set; }
        private Dictionary<int, Rectangle> roomSource;
        private Game1 myGame;
        public MouseController(Game1 game)
        {
            myGame = game;
            width = 85;
            height = 59;
            i = 0;
            IsMapUsed = false;
            roomSource = new Dictionary<int, Rectangle>
            {
                { 1, new Rectangle(85, 293, width, height) },
                { 2, new Rectangle(171, 293, width, height) },
                { 3, new Rectangle(256, 293, width, height) },
                { 4, new Rectangle(256, 235, width, height) },
                { 5, new Rectangle(85, 176, width, height) },
                { 6, new Rectangle(171, 176, width, height) },
                { 7, new Rectangle(256, 176, width, height) },
                { 8, new Rectangle(0, 117, width, height) },
                { 9, new Rectangle(85, 117, width, height) },
                { 10, new Rectangle(171, 117, width, height) },
                { 11, new Rectangle(256, 117, width, height) },
                { 12, new Rectangle(341, 117, width, height) },
                { 13, new Rectangle(85, 59, width, height) },
                { 14, new Rectangle(171, 59, width, height) },
                { 15, new Rectangle(341, 59, width, height) },
                { 16, new Rectangle(427, 59, width, height) },
                { 17, new Rectangle(85, 0, width, height) },
                { 18, new Rectangle(171, 0, width, height) }
            };
        }

        public void RegisterCommand()
        {

        }

        public void Update(Game1 game)
        {
            MouseState mouse = Mouse.GetState();

            if (IsMapUsed)
            {
                while (i < roomSource.Count)
                {
                    if (roomSource[i + 1].Contains(mouse.Position))
                    {
                        game.Level = LevelLoaderFactory.Instance.LoadContents(myGame.XmlString, roomSource.ElementAt(i).Key);
                    }
                }
            }
        }
    }
}
