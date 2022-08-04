using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class ResetCommand : ICommand
    {
        private Game1 game;
        public ResetCommand(Game1 gameClass)
        {
            this.game = gameClass;
        }
        public void Execute()
        {
            game.Level = LevelLoaderFactory.Instance.LoadContents(game.XmlString, 1);
            game.ControllerList = new List<IController>();
            game.ControllerList.Add(new KeyboardController(game));
            game.ControllerList.Add(new MouseController(game));
            foreach (IController controller in game.ControllerList)
            {
                controller.RegisterCommand();
            }
        }
    }
}
