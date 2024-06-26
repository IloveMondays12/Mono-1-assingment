﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_1_assingment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D _discoText, _zeusText, _androidText, _alienText, _scaredManText;
        Rectangle background;
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            background = new Rectangle(0, 0, 800, 500);
            _alienText = Content.Load<Texture2D>("alien pc");
            _zeusText = Content.Load<Texture2D>("Zeus action fig");
            _discoText = Content.Load<Texture2D>("disco party");
            _scaredManText = Content.Load<Texture2D>("scared man");
            _androidText = Content.Load<Texture2D>("android");
            
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_discoText,background, Color.White);
            _spriteBatch.Draw(_zeusText, new Vector2(300,250), Color.White);
            _spriteBatch.Draw(_alienText, new Vector2(100,405), Color.White);
            _spriteBatch.Draw(_androidText, new Vector2(320,390),Color.White);
            _spriteBatch.Draw(_scaredManText, new Vector2(650, 350), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}