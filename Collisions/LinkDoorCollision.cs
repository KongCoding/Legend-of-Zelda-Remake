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
    public class LinkDoorCollision
    {
        private Link curLink;

        public LinkDoorCollision(Link link)
        {
            curLink = link;
        }

        public void DoorCollisionTest(IList<IDoor> doors)
        {
            Rectangle linkRectangle = curLink.GetRectangle();
            Rectangle doorRectangle;
            Rectangle intersectionRectangle;
            // determine door state
            
            foreach (IDoor door in doors)
            {
                doorRectangle = door.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, doorRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height))
                    {
                        if (linkRectangle.Y > doorRectangle.Y)
                        {
                            if (door.DoorState == DoorState.LOCKED)
                            {
                                //Door open
                                door.Open();
                            }
                            else
                            {
                                //Cannot move or change direction to down?
                                linkRectangle.Y += intersectionRectangle.Height;
                            }
                        }
                        else
                        {
                            if (door.DoorState == DoorState.LOCKED)
                            {
                                //Door open
                                door.Open();
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
                        if (linkRectangle.X > doorRectangle.X)
                        {

                            if (door.DoorState == DoorState.LOCKED)
                            {
                                //Door open
                                door.Open();
                            }
                            else
                            {
                                //Cannot move or change direction to right?
                                linkRectangle.X += intersectionRectangle.X;
                            }

                        }
                        else
                        {
                            if (door.DoorState == DoorState.LOCKED)
                            {
                                //Door open
                                door.Open();
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