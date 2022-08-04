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
    public class LinkEnemyCollision
    {
        private Link curLink;

        public LinkEnemyCollision(Link link)
        {
            curLink = link;
        }

        public void EnemyCollisionTest(Link link, IList<IEnemy> enemies)
        {
            Rectangle linkRectangle = curLink.GetRectangle();
            Rectangle enemyRectangle;
            Rectangle intersectionRectangle;
            bool isAttack = curLink.IsAttacking;
            Direction direction = curLink.Direction;
            foreach (IEnemy enemy in enemies)
            {

                enemyRectangle = enemy.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, enemyRectangle);

                if (!intersectionRectangle.IsEmpty)
                {


                    if ((intersectionRectangle.Width >= intersectionRectangle.Height))
                    {
                        if (linkRectangle.Y > enemyRectangle.Y)
                        {
                            if (isAttack && direction == Direction.UP)
                            {
                                enemy.Bekilled();
                            }
                            else
                            {
                                link.TakeDamage();
                            }
                        }
                        else
                        {
                            if (isAttack && direction == Direction.DOWN)
                            {
                                enemy.Bekilled();
                            }
                            else
                            {
                                link.TakeDamage();
                            }
                        }
                    }
                    else
                    {
                        if (linkRectangle.X > enemyRectangle.X)
                        {
                            if (isAttack && direction == Direction.LEFT)
                            {
                                enemy.Bekilled();
                            }
                            else
                            {
                                link.TakeDamage();
                            }
                        }
                        else
                        {
                            if (isAttack && direction == Direction.RIGHT)
                            {
                                enemy.Bekilled();
                            }
                            else
                            {
                                link.TakeDamage();
                            }
                        }
                    }

                }
            }

        }
    }
}