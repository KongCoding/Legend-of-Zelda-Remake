using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Collision;

namespace Sprint2
{
    public enum DoorState
    {
        OPEN, CLOSED, LOCKED
    }
    public class Door : IDoor
    {
        public IDoorState State { get; set; }
        public Vector2 Position { get; set; }
        public DoorState DoorState { get; set; }
        private int x;
        private int y;


        public Door(int x, int y, int direction, int doorState)
        {
            this.x = x;
            this.y = y;
            Position = new Vector2(x, y);
            State = new DoorDownOpenState(this);
            this.InitializeState(direction, doorState);
        }

        public void Up()
        {
            State.Up();
        }

        public void Down()
        {
            State.Down();
        }

        public void Left()
        {
            State.Left();
        }

        public void Right()
        {
            State.Right();
        }

        public void Open()
        {
            State.Open();
        }

        public void Locked()
        {
            State.Locked();
        }

        public void Closed()
        {
            State.Closed();
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, State.Width, State.Height);
        }
        public void CollidedWithLink(IPlayer link, Collision.Direction direction)
        {
            LinkDoorHandler.UpateLocation(link, this, direction);
        }
        public void Update()
        {
            State.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
        }

        public void InitializeState(int direction, int doorState)
        {
            switch (direction)
            {
                case 1:
                    this.Up();
                    break;
                case 2:
                    this.Down();
                    break;
                case 3:
                    this.Left();
                    break;
                case 4:
                    this.Right();
                    break;
            }

            switch (doorState)
            {
                case 1:
                    this.Open();
                    break;
                case 2:
                    this.Closed();
                    break;
                case 3:
                    this.Locked();
                    break;
            }
        }

    }
}
