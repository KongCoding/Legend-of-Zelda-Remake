using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class MoveRightCommand : ICommand
    {
        private IPlayer link;
        public MoveRightCommand(IPlayer linkClass)
        {
            this.link = linkClass;
        }
        public void Execute()
        {
            if (link.Direction == Direction.RIGHT)
            {
                link.Run();
            }
            else
            {
                link.FaceRight();
            }
        }

    }
}