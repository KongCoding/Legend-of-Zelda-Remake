using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class MoveDownCommand : ICommand
    {
        private IPlayer link;
        public MoveDownCommand(IPlayer linkClass)
        {
            this.link = linkClass;
        }
        public void Execute()
        {
            if (link.Direction == Direction.DOWN){
                link.Run();
            }
            else
            {
                link.FaceDown();
            }
        }

    }
}