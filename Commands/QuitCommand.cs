using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class QuitCommand : ICommand
    {
        private Game1 game;
        public QuitCommand(Game1 gameClass)
        {
            this.game = gameClass;
        }
        public void Execute()
        {
            game.Exit();
        }

    }
}
