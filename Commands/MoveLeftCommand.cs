using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class MoveLeftCommand : ICommand
    {
        private IPlayer link;
        public MoveLeftCommand(IPlayer linkClass)
        {
            this.link = linkClass;
        }
        public void Execute()
        {
            if (link.Direction == Direction.LEFT)
            {
                link.Run();
            }
            else
            {
                link.FaceLeft();
            }
        }

    }
}