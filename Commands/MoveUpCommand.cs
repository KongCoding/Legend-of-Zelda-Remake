using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class MoveUpCommand : ICommand
    {
        private IPlayer link;
        public MoveUpCommand(IPlayer linkClass)
        {
            this.link = linkClass;
        }
        public void Execute()
        {
            if (link.Direction == Direction.UP)
            {
                link.Run();
            }
            else
            {
                link.FaceUp();
            }
        }

    }
}