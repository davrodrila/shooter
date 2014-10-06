#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using System.Timers;
#endregion

namespace shooter
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Controller : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpaceShip spaceShip;
        List<Bullet> bullets;
        int pushTime;
        private int spawnCoordX = 300;
        private int spawnCoordY = 300;
        public Controller()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            bullets = new List<Bullet>();
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
            spaceShip = new SpaceShip(spawnCoordX, spawnCoordY, Content);
            // TODO: use this.Content to load your game content here
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
            CheckControls(gameTime);
            base.Update(gameTime);
            CheckColisions(gameTime);
            MoveBullets(gameTime);
        }

        private void MoveBullets(GameTime gameTime)
        {
            foreach (Bullet b in bullets)
            {
                b.move(new Vector2(0.0f, (b.Speed * -1)));
            }
        }
        private void CheckColisions(GameTime gameTime)
        {
            foreach (Bullet s in bullets)
            {
                
            }
        }
        private void CheckControls(GameTime gameTime)
        {
            KeyboardState keyBoardState = Keyboard.GetState();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            spaceShip.move(obtainDirection(keyBoardState));
            pushTime -= gameTime.ElapsedGameTime.Milliseconds;
            if (keyBoardState.IsKeyDown(Keys.Space))
            {
                if (pushTime<=0)
                {
                    bullets.Add(spaceShip.shoot(Content));
                    pushTime = spaceShip.ShootDelay;
                }
            }
            else
            {
                pushTime = 0;
            }
        }

        public Vector2 obtainDirection(KeyboardState keyboardState)
        {
            Vector2 direction = Vector2.Zero;
            Keys[] keys = keyboardState.GetPressedKeys();
            foreach (Keys k in keys)
            {
                if (k == Keys.Up)
                {
                    direction += new Vector2(0,(spaceShip.Speed*-1));
                }
                else if (k == Keys.Down)
                {
                    direction += new Vector2(0,spaceShip.Speed);
                }
                else if (k == Keys.Left)
                {
                    direction += new Vector2((spaceShip.Speed*-1),0);
                }
                else if (k == Keys.Right)
                {
                    direction += new Vector2(spaceShip.Speed,0);
                }
            }
            return direction;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Pink);
            spriteBatch.Begin();
            spaceShip.Draw(spriteBatch);
            foreach(Bullet s in bullets)
            {
                s.Draw(spriteBatch);
            }
            // TODO: Add your drawing code here
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
