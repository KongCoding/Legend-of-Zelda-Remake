using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2.Collisions
{
    public class EnemyBlockCollision
    {
        private IEnemy curEnemy;

        public EnemyBlockCollision(IEnemy enemy)
        {
            curEnemy = enemy;
        }

        public void BlockCollisionTest(IList<IBlock> blocks)
        {
            Rectangle curRectangle = curEnemy.GetRectangle();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;

            foreach (IBlock block in blocks)
            {

                blockRectangle = block.GetRectangle();

                intersectionRectangle = Rectangle.Intersect(curRectangle, blockRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height))
                    {
                        if (curRectangle.Y > blockRectangle.Y)
                        {
                            //reverse to down direction
                            curEnemy.ColidedWithBlock(block);
                        }
                        else
                        {
                            //reverse to up direction
                            curEnemy.ColidedWithBlock(block);
                        }
                    }
                    else
                    {
                        if (curRectangle.X > blockRectangle.X)
                        {
                            //reverse to right direction
                            curEnemy.ColidedWithBlock(block);
                        }
                        else
                        {
                            //reverse to left direction
                            curEnemy.ColidedWithBlock(block);
                        }
                    }
                }
            }
        }

  


    }

       
}



