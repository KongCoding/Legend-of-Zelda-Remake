using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class UseItemCommand : ICommand
    {
        private IProjectile bomb;
        public UseItemCommand(IProjectile bombClass)

        {
            this.bomb = bombClass;
        }
        public void Execute()
        {
            bomb.UseProjectile();
        }
    }
}