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
    public class LinkItemCollision
    {
        private Link curLink;

        public LinkItemCollision(Link link)
        {
            curLink = link;
        }

        public void ItemCollisionTest(Link link, IList<IItem> items)
        {
            Rectangle linkRectangle = curLink.GetRectangle();
            Rectangle itemRectangle;
            Rectangle intersectionRectangle;

            foreach (IItem item in items)
            {

                itemRectangle = item.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, itemRectangle);
                // bool picked
                if (!intersectionRectangle.IsEmpty)
                {
                    //Get item name?
                    link.PickUpItem();
                }
            }

        }
    }
}