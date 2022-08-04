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
    public class LinkWaterCollision
    {
        private Link curLink;

        public LinkWaterCollision(Link link)
        {
            curLink = link;
        }

        public void WaterCollisionTest(IList<IWater> waters)
        {
            Rectangle linkRectangle = curLink.GetRectangle();
            Rectangle waterRectangle;
            Rectangle intersectionRectangle;

            foreach (IWater water in waters)
            {
                waterRectangle = water.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, waterRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height))
                    {
                        if (linkRectangle.Y > waterRectangle.Y)
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
                        if (linkRectangle.X > waterRectangle.X)
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
