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
    public class LinkWallCollision
    {
        private Link curLink;

        public LinkWallCollision(Link link)
        {
            curLink = link;
        }

        public void WallCollisionTest(IList<IWall> walls)
        {
            Rectangle linkRectangle = curLink.GetRectangle();
            Rectangle wallRectangle;
            Rectangle intersectionRectangle;

            foreach (IWall wall in walls)
            {
                wallRectangle = wall.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, wallRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height))
                    {
                        if (linkRectangle.Y > wallRectangle.Y)
                        {

                            //Cannot move or change direction to down?
                            linkRectangle.Y += intersectionRectangle.Height;

                        }
                        else
                        {

                            //Cannot move or change direction to up?
                            linkRectangle.Y -= intersectionRectangle.Height;
                        }
                    }
                    else
                    {
                        if (linkRectangle.X > wallRectangle.X)
                        {

                            //Cannot move or change direction to right?
                            linkRectangle.X += intersectionRectangle.X;
                        }


                        else
                        {
                            //Cannot move or change direction to left?
                            linkRectangle.X -= intersectionRectangle.X;
                        }
                    }
                }
            }
        }
            
    }
}
