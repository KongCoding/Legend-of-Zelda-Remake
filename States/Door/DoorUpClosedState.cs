﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class DoorUpClosedState : IDoorState
    {
        private ISprite doorSprite;
        private Door door;
        public int Width { get; set; }
        public int Height { get; set; }
        public DoorUpClosedState(Door door)
        {
            this.door = door;
            doorSprite = ArtifactSpriteFactory.Instance.CreateUpClosedDoorSprite();
            this.Width = doorSprite.Width;
            this.Height = doorSprite.Height;
            this.door.DoorState = DoorState.CLOSED;
        }

        public void Down()
        {
            door.State = new DoorDownClosedState(door);
        }

        public void Left()
        {
            door.State = new DoorLeftClosedState(door);
        }

        public void Right()
        {
            door.State = new DoorRightClosedState(door);
        }

        public void Up()
        {
            //Do nothing. Is already in this state.
        }

        public void Locked()
        {
            door.State = new DoorUpLockedState(door);
        }

        public void Open()
        {
            door.State = new DoorUpOpenState(door);
        }

        public void Closed()
        {
            //Do nothing. Is already in this state.
        }

        public void Update()
        {
            doorSprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            doorSprite.Draw(spriteBatch, door.Position);
        }
    }
}
