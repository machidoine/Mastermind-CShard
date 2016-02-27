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
    public class MastermindGame : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        SpriteManager _spriteManager;
        Sprite _arrowRightSprite;
        Sprite _arrowLeftSprite;

        public MastermindGame()
        {
            _graphics = new GraphicsDeviceManager(this);


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
            _spriteManager = new SpriteManager();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _arrowRightSprite = new Sprite();
            _arrowRightSprite.LoadContent(Content, "arrowRight");
            _arrowRightSprite.Position = Vector2.Zero;

            _arrowLeftSprite = new Sprite();
            _arrowLeftSprite.LoadContent(Content, "arrowLeft");
            _arrowLeftSprite.Position = new Vector2(100, 100);

            _arrowRightSprite.MouseClicked += arrowRightSprite_mouseClicked;

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
                Exit();

            MouseManager.Instance.Update();
            _arrowRightSprite.Position += new Vector2(1, 0);



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            _spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            _arrowRightSprite.Draw(_spriteBatch);
            _arrowLeftSprite.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }


    }
}
