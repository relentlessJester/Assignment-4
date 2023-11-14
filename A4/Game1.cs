using System.Net.Http.Headers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace A4
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont font;
        private Texture2D viktor;
        private Texture2D LittlePrince;
        private Texture2D _falsettos;
        private Texture2D _palia;
        private Texture2D _botw;
        private Texture2D _onesJustice;

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
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("HelloFont");
            viktor = Content.Load<Texture2D>("vik");
            LittlePrince = Content.Load<Texture2D>("petitPrince");
            _falsettos = Content.Load<Texture2D>("FalsettoLand");
            _palia = Content.Load<Texture2D>("palia");
            _botw = Content.Load<Texture2D>("botw");
            _onesJustice = Content.Load<Texture2D>("mha");


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
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.DrawString(font, "My  name is:", new Vector2(50, 50), Color.White);
            _spriteBatch.DrawString(font, "Viktor Szymaniak", new Vector2(75, 70), Color.Lime);
            _spriteBatch.Draw(viktor, new Rectangle(210, 20, viktor.Width /10, viktor.Height /10), Color.White);
            _spriteBatch.DrawString(font, "My Favourite movie is", new Vector2(50, 150), Color.White);
            _spriteBatch.DrawString(font, "The Little Prince", new Vector2(75, 170), Color.Lime);
            _spriteBatch.Draw(LittlePrince, new Rectangle(210, 115, LittlePrince.Width / 5, LittlePrince.Height / 5), Color.White);
            _spriteBatch.DrawString(font, "My favourite YouTube Video has", new Vector2(350, 50), Color.White);
            _spriteBatch.DrawString(font, "228,359 views", new Vector2(450, 70), Color.Lime); 
            _spriteBatch.Draw(_falsettos, new Rectangle(575, 20, _falsettos.Width / 6, _falsettos.Height / 6), Color.White);
            _spriteBatch.DrawString(font, "Three games I am very fond of are:", new Vector2(275, 300), Color.White);
            _spriteBatch.Draw(_palia, new Rectangle(150, 340, _palia.Width /5, _palia.Height / 5), Color.White);
            _spriteBatch.Draw(_botw, new Rectangle(375, 340, _botw.Width /4, _botw.Height / 4), Color.White);
            _spriteBatch.Draw(_onesJustice, new Rectangle(500, 340, _onesJustice.Width / 7, _onesJustice.Height / 7), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}