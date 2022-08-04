using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Collision;
namespace Sprint2.Collision
{
    class LinkDoorHandler
    {
        public static void HandleCollision(IPlayer link, IDoor door, Direction direction)
        {
            door.CollidedWithLink(link, direction);
        }
        public static void UpateLocation(IPlayer link, IDoor door, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    if (door.DoorState == DoorState.LOCKED)
                    {
                        //Door open
                        door.Open();
                    }
                    else
                    {
                        link.Location = new Vector2(link.Location.X, door.Location.Y - link.GetRectangle().Height);
                    }
                    break;
                    
                case Direction.LEFT:
                    if (door.DoorState == DoorState.LOCKED)
                    {
                        //Door open
                        door.Open();
                    }
                    else
                    {
                        link.Location = new Vector2(door.Location.X - link.GetRectangle().Width, link.Location.Y);
                    }
                    break;

                case Direction.RIGHT:
                    if (door.DoorState == DoorState.LOCKED)
                    {
                        //Door open
                        door.Open();
                    }
                    else
                    {
                        link.Location = new Vector2(door.Location.X + door.GetRectangle().Width, link.Location.Y);
                    }
                    break;

                case Direction.DOWN:
                    if (door.DoorState == DoorState.LOCKED)
                    {
                        //Door open
                        door.Open();
                    }
                    else
                    {
                        link.Location = new Vector2(link.Location.X, door.Location.Y + door.GetRectangle().Height);
                    }
                    break;
            }

        }
    }
}
