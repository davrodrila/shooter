﻿#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace shooter
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpaceShip spaceShip;
        Texture2D texture;
        private int spawnCoordX = 300;
        private int spawnCoordY = 300;
        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            spaceShip.mover(obtenerSentido(Keyboard.GetState(PlayerIndex.One)));
            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        public Sentido obtenerSentido(KeyboardState keyboardState) 
        {
            Sentido sentido;
            if (keyboardState.IsKeyDown(Keys.Up)) {
                sentido = Sentido.Up;
            }
            else if (keyboardState.IsKeyDown(Keys.Down))
            {
                sentido = Sentido.Down;
            }
            else if (keyboardState.IsKeyDown(Keys.Left))
            {
                sentido = Sentido.Left;
            }
            else if (keyboardState.IsKeyDown(Keys.Right))
            {
                sentido = Sentido.Right;
            } else
            {
                Keys[] currentKeys = keyboardState.GetPressedKeys();

                sentido = Sentido.None;
            }
           return sentido;
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

            // TODO: Add your drawing code here
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
