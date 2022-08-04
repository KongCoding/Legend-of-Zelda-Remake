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
    public enum Direction { UP,DOWN,LEFT,RIGHT };
    public class AllCollisionHandler
    {
        public ILevel Level { get; set; }

        public AllCollisionHandler(ILevel level)
        {
            Level = level;
        }

        public void CheckAllCollisions()
        {
            Rectangle linkRectangle = Level.Link.GetRectangle();
            CheckLinkBlockCollision(linkRectangle);
            CheckLinkEnemyCollision(linkRectangle);
            CheckLinkItemCollision(linkRectangle);
            CheckLinkWallCollision(linkRectangle);
            CheckLinkDoorCollision(linkRectangle);
        }

        private void CheckLinkEnemyCollision(Rectangle linkRectangle)
        {
            foreach (IEnemy enemy in Level.Enemies)
            {
                Rectangle enemyRectangle = enemy.GetRectangle();
                Rectangle intersectionRectangle = Rectangle.Intersect(enemyRectangle, linkRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    Direction direction = GetCollisionDirection(intersectionRectangle, linkRectangle, enemyRectangle);
                    LinkEnemyHandler.HandleCollision(Level.Link, enemy, direction);
                }
            }
        }

        private void CheckLinkItemCollision(Rectangle linkRectangle)
        {

            foreach (IItem item in Level.Items)
            {
                Rectangle itemRectangle = item.GetRectangle();
                Rectangle intersectionRectangle = Rectangle.Intersect(itemRectangle, linkRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    LinkItemHandler.HandleCollision(Level.Link, item);
                }
            }


        }

        private void CheckLinkDoorCollision(Rectangle linkRectangle)
        {
            foreach (IDoor door in Level.Doors)
            {
                Rectangle doorRectangle = door.GetRectangle();
                Rectangle intersectionRectangle = Rectangle.Intersect(doorRectangle, linkRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    Direction direction = GetCollisionDirection(intersectionRectangle, linkRectangle, doorRectangle);
                    LinkDoorHandler.HandleCollision(Level.Link, door, direction);
                }
            }
        }

        private void CheckLinkBlockCollision(Rectangle linkRectangle)
        {
            foreach (IBlock block in Level.Blocks)
            {
                Rectangle blockRectangle = block.GetRectangle();
                Rectangle intersectionRectangle = Rectangle.Intersect(blockRectangle, linkRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    Direction direction = GetCollisionDirection(intersectionRectangle, linkRectangle, blockRectangle);
                    LinkBlockHandler.HandleCollision(Level.Link, block, direction);
                }
            }
        }

        private void CheckLinkWallCollision(Rectangle linkRectangle)
        {
            foreach (IWall wall in Level.Walls)
            {
                Rectangle wallRectangle = wall.GetRectangle();
                Rectangle intersectionRectangle = Rectangle.Intersect(wallRectangle, linkRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    Direction direction = GetCollisionDirection(intersectionRectangle, linkRectangle, wallRectangle);
                    LinkWallHandler.HandleCollision(Level.Link, wall, direction);
                }
            }
        }

        private static Direction GetCollisionDirection(Rectangle intersectionRectangle, Rectangle linkRectangle, Rectangle gameObjectRectangle)
        {
            if (intersectionRectangle.Width >= intersectionRectangle.Height)
            {
                return linkRectangle.Top <= gameObjectRectangle.Top ? Direction.UP : Direction.DOWN;
            }
            else
            {
                return linkRectangle.Left <= gameObjectRectangle.Left ? Direction.LEFT : Direction.RIGHT;
            }

        }


    }
}
