using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;
using System.Linq;
using ProjectName;

namespace SpriteandDraw {
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        List<Circle> board = new List<Circle>();
        //List<int> vertical = new List<int>();
        //ILookup<int, int> board;
        private SpriteFont font;
        //private double score = 0;

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1600;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 900;   // set this value to the desired height of your window
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }
        protected void CreateBoard() {
            int i, height;
            int[] x = new int[100];
            int[] y = new int[100];
            //middle row
            height = 130;
            for (i = 0; i <= 8; i++)
            {
                x[i] = 735;
                y[i] = height;
                height += 80;
            }
            //left 1
            height = 170;
            for(i = 9; i <= 16; i++)
            {
                x[i] = 714;
                y[i] = height;
                height += 80;
            }
            //left 2
            height = 210;
            for (i = 17; i <= 23; i++)
            {
                x[i] = 693;
                y[i] = height;
                height += 80;
            }
            //left 3
            height = 250;
            for (i = 24; i <= 29; i++)
            {
                x[i] = 672;
                y[i] = height;
                height += 80;
            }
            //left 4
            height = 290;//reuse the height
            for (i = 30; i <= 34; i++)
            {
                x[i] = 651;
                y[i] = height;
                height += 80;
            }
            //left 5
            height = 330; //resue for height 2
            for (i = 35; i <= 38; i++)
            {
                x[i] = 630;
                y[i] = height;
                height += 80;
            }
            //left 6
            height = 290;
            for (i = 40; i <= 44; i++)
            {
                x[i] = 609;
                y[i] = height;
                height += 80;
            }
            //left 7
            height = 330;
            for (i = 45; i <= 48; i++)
            {
                x[i] = 588;
                y[i] = height;
                height += 80;
            }
            //left 8
            height = 290;
            for (i = 49; i <= 53; i++)
            {
                x[i] = 567;
                y[i] = height;
                height += 80;
            }
            //left 9
            height = 330;
            for (i = 54; i <= 57; i++)
            {
                x[i] = 546;
                y[i] = height;
                height += 80;
            }
            //left 10
            height = 290;
            for (i = 58; i <= 59; i++)
            {
                x[i] = 525;
                y[i] = height;
                height += 80;
            }
            height = 530;
            for (i = 60; i <= 61; i++)
            {
                x[i] = 525;
                y[i] = height;
                height += 80;
            }
            //left 11
            x[62] = 504;
            y[62] = 330;
            x[63] = 504;
            y[63] = 570;
            //left 12
            x[64] = 483;
            y[64] = 290;
            x[65] = 483;
            y[65] = 610;



            for (i = 0; i < y.Length; i++)
            {
                //Console.WriteLine(GraphicsDevice.Viewport.Width);
                board.Add(new Circle(new Vector2(x[i], y[i])));
            }
            /*height = 170;
            for (i = 17; i <= 24; i++)
            {
                x[i] = 756;
                y[i] = height;
                height += 80;
            }*/
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() {
            // TODO: Add your initialization logic here
            this.IsMouseVisible = true;


            CreateBoard();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            font = Content.Load<SpriteFont>("alphabet");
            Circle.LoadContent(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            foreach (Circle circle in board)
                circle.Draw(spriteBatch);
            //spriteBatch.DrawString(font, "Chung what the hell are you doing: " + score, new Vector2(100, 100), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
