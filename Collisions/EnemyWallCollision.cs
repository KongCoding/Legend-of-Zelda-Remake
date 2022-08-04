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
    public class EnemyWallCollision 
    {
        private IEnemy curEnemy;

        public EnemyWallCollision(IEnemy enemy)
        {
            curEnemy = enemy;
        }
         
        public void WallCollisionTest(IList<IWall> walls)
        {
            Rectangle curRectangle = curEnemy.GetRectangle();
            Rectangle wallRectangle;
            Rectangle intersectionRectangle;

            foreach (IWall wall in walls)
            {

                wallRectangle = wall.GetRectangle();

                intersectionRectangle = Rectangle.Intersect(curRectangle, wallRectangle);

                if (!intersectionRectangle.IsEmpty)
                {
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height))
                    {
                        if (curRectangle.Y > wallRectangle.Y)
                        {
                            //reverse to down direction
                            curEnemy.ColidedWithWall(wall);
                        }
                        else
                        {
                            //reverse to up direction
                            curEnemy.ColidedWithWall(wall);
                        }
                    }
                    else
                    {
                        if (curRectangle.X > wallRectangle.X)
                        {
                            //reverse to right direction
                            curEnemy.ColidedWithWall(wall);
                        }
                        else
                        {
                            //reverse to left direction
                            curEnemy.ColidedWithWall(wall);
                        }
                    }
                }
            }
        }

        

    }

       
}



