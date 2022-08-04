using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class UseMapCommand : ICommand
    {
        private IController mouse;
        public UseMapCommand(IController mouseController)
        {
            mouse = mouseController;
        }
        public void Execute()
        {
            ItemSpriteFactory.Instance.CreateDetailedMapSprite();
            mouse.IsMapUsed = true;
        }
    }
}
