using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment_4
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont _font;
        private Texture2D _me, _youtube, _fallguys, _jabwemet, _minecraft, _phasmophobia;
        private string _name;
        private int _views;
        private float _rating;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 1200;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _name = "Amneet Kaur";
            _views = 59876504;
            _rating = 7.9f;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _font = Content.Load<SpriteFont>("Font");
            _me = Content.Load<Texture2D>("Me");
            _fallguys = Content.Load<Texture2D>("FallGuys");
            _jabwemet = Content.Load<Texture2D>("JabWeMet");
            _minecraft = Content.Load<Texture2D>("minecraft");
            _phasmophobia = Content.Load<Texture2D>("phasmophobia");
            _youtube = Content.Load<Texture2D>("Youtube");

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
            _spriteBatch.Begin();
            // My name
            _spriteBatch.DrawString(_font, "My name is:", new Vector2(100,100), Color.MistyRose);
            _spriteBatch.DrawString(_font, _name , new Vector2(270, 100), Color.Black);
            // Movie Rating
            _spriteBatch.DrawString(_font, "My Favourite movie has IMDb rating of:", new Vector2(100, 300), Color.MistyRose);
            _spriteBatch.DrawString(_font, ""+ _rating , new Vector2(650, 300), Color.Black);
            // YouTube Video
            _spriteBatch.DrawString(_font, "My Favourite YouTube Video has this many views:", new Vector2(100, 500), Color.MistyRose);
            _spriteBatch.DrawString(_font, "" + _views , new Vector2(810, 500), Color.Black);
            // Favourite Games
            _spriteBatch.DrawString(_font, "My favourite three games are:", new Vector2(100, 600), Color.MistyRose);
            // My Photo
            _spriteBatch.Draw(_me, new Rectangle(500, 50, 100, 150), Color.White);
            // Movie cover
            _spriteBatch.Draw(_jabwemet, new Rectangle(750, 225, 100, 150), Color.White);
            // YouTube Video
            _spriteBatch.Draw(_youtube, new Rectangle(960, 425, 200, 150), Color.White);
            // Favourite Games
            _spriteBatch.Draw(_phasmophobia, new Rectangle(550, 625, 300, 150), Color.White);
            _spriteBatch.Draw(_minecraft, new Rectangle(850, 625, 100, 150), Color.White);
            _spriteBatch.Draw(_fallguys, new Rectangle(950, 625, 200, 150), Color.White);


            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}