using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2.Collision;

namespace Sprint2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        private GameTime gameTime;
        public AllCollisionHandler collisionDetection;
        public string XmlString { get; set; }
        public ILevel Level { get; set; }
        public List<IController> ControllerList { get; set; }
        private TextSprite textSprite;
        private SpriteFont text;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 640;
            graphics.PreferredBackBufferHeight = 440;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            XmlString = Environment.CurrentDirectory + "/Content/Level1.xml";
            ControllerList = new List<IController>() ;
            ControllerList.Add(new KeyboardController(this));
            ControllerList.Add(new MouseController(this));
            collisionDetection = new AllCollisionHandler(Level);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ArtifactSpriteFactory.Instance.LoadAllTextures(Content);
            CharacterSpriteFactory.Instance.LoadAllTextures(Content);
            EnemySpriteFactory.Instance.LoadAllTextures(Content);
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            ProjectileSpriteFactory.Instance.LoadAllTextures(Content);
            RoomSpriteFactory.Instance.LoadAllTextures(Content);
            Level = LevelLoaderFactory.Instance.LoadContents(XmlString, 1);
            foreach (IController controller in ControllerList)
            {
                controller.RegisterCommand();
            }

            text = Content.Load<SpriteFont>("TextSprite/Text");
            textSprite = new TextSprite(text);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            // TODO: Add your update logic here

            foreach (IController controller in ControllerList)
                controller.Update(this);
            collisionDetection.CheckAllCollisions();
            Level.Update();   
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            // TODO: Add your drawing code here
            Level.Draw(spriteBatch);

            textSprite.Draw(spriteBatch, new Vector2(270, 320));

            base.Draw(gameTime);
        }
    }
}
