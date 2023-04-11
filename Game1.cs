using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson_2___Scaling_Using_Rectangles
{
    public class Game1 : Game
    {

        Texture2D rectangleTexture;
        Texture2D circleTexture;
        Texture2D starTexture;

        Rectangle circleWhiteRect;
        Rectangle circleRedRect;
        Rectangle rectangleFlagRect;
        Rectangle rectanglePoleRect;
        Rectangle starRect;
        Rectangle rectangleStringRect;
        Rectangle rectangleString2Rect;
        Rectangle circlePoleRect;


        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            this.Window.Title = "Scaling Rectangles";

            circleWhiteRect = new Rectangle(275, 150, 150, 150);
            circleRedRect = new Rectangle(312, 167, 115, 115);
            rectangleFlagRect = new Rectangle(200, 100, 400, 250);
            rectanglePoleRect = new Rectangle(170, 90, 20, 1000);
            starRect = new Rectangle(400, 185, 70, 70);
            rectangleStringRect = new Rectangle(169, 120, 40, 5);
            rectangleString2Rect = new Rectangle(169, 320, 40, 5);
            circlePoleRect = new Rectangle(170, 80, 20, 30);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            starTexture = Content.Load<Texture2D>("star");
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
            _spriteBatch.Draw(rectangleTexture, rectanglePoleRect, Color.Gray);
            _spriteBatch.Draw(circleTexture, circlePoleRect, Color.Gray);
            _spriteBatch.Draw(rectangleTexture, rectangleFlagRect, Color.Red);
            _spriteBatch.Draw(circleTexture, circleWhiteRect, Color.White);
            _spriteBatch.Draw(circleTexture, circleRedRect, Color.Red);
            _spriteBatch.Draw(starTexture, starRect, Color.White);
            _spriteBatch.Draw(rectangleTexture, rectangleStringRect, Color.Black);
            _spriteBatch.Draw(rectangleTexture, rectangleString2Rect, Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}