using System;
using Mastermind.View;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mastermind.App
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class MastermindGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteManager spriteManager;
        Sprite arrowRightSprite;
        Sprite arrowLeftSprite;

        public MastermindGame()
        {
            graphics = new GraphicsDeviceManager(this);

            MouseManager.Instance.ClickLeftEvent += mouseManager_ClickLeftEvent;

            Content.RootDirectory = "Content";
        }

        void mouseManager_ClickLeftEvent(ClickEventArgs clickEventArgs)
        {
            Console.WriteLine("clicked !!");
        }


        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            spriteManager = new SpriteManager();
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

            Texture2D arrowRight = Content.Load<Texture2D>("arrowRight");
            Texture2D arrowLeft = Content.Load<Texture2D>("arrowLeft");

            arrowRightSprite = new Sprite();
            arrowRightSprite.LoadContent(Content, "arrowRight");
            arrowRightSprite.Position = Vector2.Zero;

            arrowLeftSprite = new Sprite();
            arrowLeftSprite.LoadContent(Content, "arrowLeft");
            arrowLeftSprite.Position = new Vector2(100, 100);

            arrowRightSprite.MouseClicked += arrowRightSprite_mouseClicked;

        }

        void arrowRightSprite_mouseClicked(object sender, ClickEventArgs e)
        {
            Console.WriteLine("Mousue Clicked on sprite " + sender);
        }


        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            MouseManager.Instance.Update();
            arrowRightSprite.Position += new Vector2(1, 0);



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            arrowRightSprite.Draw(spriteBatch);
            arrowLeftSprite.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }


    }
}
