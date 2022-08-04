using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyCommand;
        public bool IsMapUsed { get; set; }
        private Keys[] previousKeys;
        private Game1 game;
        public KeyboardController(Game1 gameClass)
        {
            game = gameClass;
            previousKeys = new Keys[0];

            keyCommand = new Dictionary<Keys, ICommand>();
           
            
        }
        public void RegisterCommand()
        {
            keyCommand.Add(Keys.W, new MoveUpCommand(game.Level.Link));
            keyCommand.Add(Keys.Up, new MoveUpCommand(game.Level.Link));
            keyCommand.Add(Keys.A, new MoveLeftCommand(game.Level.Link));
            keyCommand.Add(Keys.Left, new MoveLeftCommand(game.Level.Link));
            keyCommand.Add(Keys.S, new MoveDownCommand(game.Level.Link));
            keyCommand.Add(Keys.Down, new MoveDownCommand(game.Level.Link));
            keyCommand.Add(Keys.D, new MoveRightCommand(game.Level.Link));
            keyCommand.Add(Keys.Right, new MoveRightCommand(game.Level.Link));
            keyCommand.Add(Keys.D1, new UseItemCommand(game.Level.Projectiles[0]));
            keyCommand.Add(Keys.D2, new UseSecondItemCommand(game.Level.Projectiles[1]));
            keyCommand.Add(Keys.Q, new QuitCommand(game));
            keyCommand.Add(Keys.R, new ResetCommand(game));
            keyCommand.Add(Keys.D3, new AttackCommand(game.Level.Link));
            keyCommand.Add(Keys.M, new UseMapCommand(game.ControllerList[1]));
        }

        public void Update(Game1 game)
        {
            Keys[] currentKeys = Keyboard.GetState().GetPressedKeys();
            KeyboardState currentKeyState = Keyboard.GetState();
            foreach (Keys key in currentKeys)
            {
                if (keyCommand.ContainsKey(key) && !previousKeys.Contains(key))
                {
                    keyCommand[key].Execute();
                }
            }
            previousKeys = currentKeys;
            if (!currentKeys.Equals(Keys.D1) && !currentKeys.Equals(Keys.D2) && !currentKeys.Equals(Keys.D3)) {
                ReturnToIdle(game, currentKeyState);
            }
            
        
        }

        

        public void ReturnToIdle(Game1 game, KeyboardState currentKeyState)
        {
            if (currentKeyState.IsKeyUp(Keys.W) && currentKeyState.IsKeyUp(Keys.A) && currentKeyState.IsKeyUp(Keys.S) && currentKeyState.IsKeyUp(Keys.D)&& 
                currentKeyState.IsKeyUp(Keys.Down) && currentKeyState.IsKeyUp(Keys.Left) && currentKeyState.IsKeyUp(Keys.Up) && currentKeyState.IsKeyUp(Keys.Right)&&
                currentKeyState.IsKeyUp(Keys.D1)&& currentKeyState.IsKeyUp(Keys.D2) && currentKeyState.IsKeyUp(Keys.D3))
            {
                if (game.Level.Link.Direction == Direction.DOWN)
                {
                    game.Level.Link.FaceDown();
                }
                else if (game.Level.Link.Direction == Direction.UP)
                {
                    game.Level.Link.FaceUp();
                }
                else if (game.Level.Link.Direction == Direction.LEFT)
                {
                    game.Level.Link.FaceLeft();
                }
                else
                {
                    game.Level.Link.FaceRight();
                }
            }
        }
    }
}
