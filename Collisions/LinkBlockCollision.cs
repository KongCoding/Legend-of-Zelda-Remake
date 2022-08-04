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
    public class LinkBolckCollision
    {
        private Link curLink;

        public LinkBolckCollision(Link link)
        {
            curLink = link;
        }

        public void BlockCollisionTest(IList<IBlock> blocks)
        {
            Rectangle linkRectangle = curLink.GetRectangle();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;
            bool isMovable = false;

            foreach (IBlock block in blocks)
            {
                blockRectangle = block.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, blockRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height))
                    {
                        if (linkRectangle.Y > blockRectangle.Y)
                        {
                            if (isMovable)
                            {
                                //Move block in up direction
                                
                                linkRectangle.Y -= intersectionRectangle.Height;
                                blockRectangle.Y -= intersectionRectangle.Height;
                            }
                            else
                            {
                                //Cannot move or change direction to down?
                                linkRectangle.Y += intersectionRectangle.Height;
                            }
                        }
                        else
                        {
                            if (isMovable)
                            {
                                linkRectangle.Y += intersectionRectangle.Height;
                            }
                            else
                            {
                                //Cannot move or change direction to up?
                                linkRectangle.Y -= intersectionRectangle.Height;
                            }
                        }
                    }
                    else
                    {
                        if (linkRectangle.X > blockRectangle.X)
                        {
                            
                            if (isMovable)
                            {
                                linkRectangle.X -= intersectionRectangle.X;
                                blockRectangle.X -= intersectionRectangle.X;
                            }
                            else
                            {
                                //Cannot move or change direction to right?
                                linkRectangle.X += intersectionRectangle.X;
                            }
                            
                        }
                        else
                        {
                            if (isMovable)
                            {
                                linkRectangle.X += intersectionRectangle.X;
                                blockRectangle.X += intersectionRectangle.X;
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
}
