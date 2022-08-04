using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class AttackCommand : ICommand
    {
        private IPlayer link;
        public AttackCommand(IPlayer linkClass)
        {
            this.link = linkClass;
        }
        public void Execute()
        {
            link.Attack();
        }

    }
}
