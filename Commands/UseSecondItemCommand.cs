using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class UseSecondItemCommand : ICommand
    {
        private IProjectile boomerang;
        public UseSecondItemCommand(IProjectile boomerangClass)
        {
            this.boomerang = boomerangClass;
        }
        public void Execute()
        {
            boomerang.UseProjectile();
        }

    }
}