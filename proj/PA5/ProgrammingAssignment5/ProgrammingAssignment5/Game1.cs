using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using TeddyMineExplosion;

namespace ProgrammingAssignment5
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        const int WINDOW_WIDTH = 800;
        const int WINDOW_HEIGHT = 600;

        // teddy support
        Texture2D teddySprite;

        // mine support
        Texture2D mineSprite;

        // teddy bear support
        Random rand = new Random();

        // explosion support
        Texture2D explosionSprite;

        // spawning support
        const int MIN_SPAWN_DELAY_MILLISECONDS = 1000;
        const int MAX_SPAWN_DELAY_MILLISECONDS = 3000;
        int targetSpawnDelayMilliseconds = 0;
        int elapsedSpawnDelayMilliseconds = 0;

        // click processing
        bool leftClickStarted = false;
        bool leftButtonReleased = true;

        // game objects
        List<TeddyBear> bears = new List<TeddyBear>();
        List<Explosion> explosions = new List<Explosion>();
        List<Mine> mines = new List<Mine>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;
            IsMouseVisible = true;
        
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

            // TODO: use this.Content to load your game content here
            mineSprite  = Content.Load<Texture2D>("mine");
            teddySprite = Content.Load<Texture2D>("teddybear");
            explosionSprite= Content.Load<Texture2D>("explosion");

            targetSpawnDelayMilliseconds = rand.Next(MIN_SPAWN_DELAY_MILLISECONDS, MAX_SPAWN_DELAY_MILLISECONDS);
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

            // TODO: Add your update logic here
            MouseState mouse = Mouse.GetState();

            // spawn a teddy bear when timer elapses
            elapsedSpawnDelayMilliseconds += gameTime.ElapsedGameTime.Milliseconds;

            if (elapsedSpawnDelayMilliseconds > targetSpawnDelayMilliseconds)
            {
                elapsedSpawnDelayMilliseconds = 0;

                Vector2 velocity = new Vector2(
                    (float)(rand.NextDouble() - 0.5),
                    (float)(rand.NextDouble() - 0.5));

                TeddyBear bear = new TeddyBear(teddySprite, velocity, WINDOW_WIDTH, WINDOW_HEIGHT);
                
                bears.Add(bear);

                // create new random spawn interval
                targetSpawnDelayMilliseconds = rand.Next(MIN_SPAWN_DELAY_MILLISECONDS, MAX_SPAWN_DELAY_MILLISECONDS);
            }

            // check for left click started
            if (mouse.LeftButton == ButtonState.Pressed &&
                leftButtonReleased)
            {
                leftClickStarted = true;
                leftButtonReleased = false;
            }
            else if (mouse.LeftButton == ButtonState.Released)
            {
                leftButtonReleased = true;

                // if left click finished, add new mine to list
                if (leftClickStarted)
                {
                    leftClickStarted = false;

                    // add a new mine to the end of the list of mines
                    mines.Add(new Mine(mineSprite, mouse.X, mouse.Y));
                }
            }

            // update teddy bears
            foreach (TeddyBear bear in bears)
            {
                bear.Update(gameTime);

                // detect collisions
                foreach (Mine mine in mines)
                {
                    if (bear.Active && mine.Active && 
                        bear.CollisionRectangle.Intersects(mine.CollisionRectangle))
                    {
                        bear.Active = false;
                        mine.Active = false;

                        explosions.Add(new Explosion(explosionSprite,
                            bear.CollisionRectangle.Center.X,
                            bear.CollisionRectangle.Center.Y));
                    }
                }
            }

            // update explosions
            foreach (Explosion explosion in explosions)
            {
                explosion.Update(gameTime);
            }

            // remove dead teddies
            for (int i = bears.Count - 1; i >= 0; i--)
            {
                if (!bears[i].Active)
                {
                    bears.RemoveAt(i);
                }
            }

            // remove inactive mines
            for (int i = mines.Count - 1; i >= 0; i--)
            {
                if (!mines[i].Active)
                {
                    mines.RemoveAt(i);
                }
            }

            // remove explosions after they finish playing
            for (int i = explosions.Count - 1; i >= 0; i--)
            {
                if (!explosions[i].Playing)
                {
                    explosions.RemoveAt(i);
                }
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            foreach (Mine mine in mines)
            {
                mine.Draw(spriteBatch);
            }

            foreach (TeddyBear bear in bears)
            {
                bear.Draw(spriteBatch);
            }

            foreach (Explosion explosion in explosions)
            {
                explosion.Draw(spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
