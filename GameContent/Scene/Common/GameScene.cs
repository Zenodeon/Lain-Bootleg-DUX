using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Lain_Bootleg_DUX.GameContent
{
    public class GameScene : Game
    {
        public GraphicsDeviceManager _graphics { get; private set; }
        public SpriteBatch _spriteBatch { get; private set; }

        public Color backgroundColor { get; set; } = Color.Black;

        public GameScene()
        {
            _graphics = new GraphicsDeviceManager(this);
            
            Window.AllowUserResizing = true;
            Window.AllowAltF4 = true;
            Window.ClientSizeChanged += OnWindowSizeChange;

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        private void OnWindowSizeChange(object sender, EventArgs e)
        {
            Window.BeginScreenDeviceChange(false);
        }

        #region PassThrough
        public virtual void OnInitialize() { }
        protected override void Initialize()
        {
            OnInitialize();
            base.Initialize();
        }

        public virtual void OnLoadContent() { }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            OnLoadContent();
        }

        public virtual void OnUpdate(GameTime gameTime) { }
        protected override void Update(GameTime gameTime)
        {
            OnUpdate(gameTime);
            base.Update(gameTime);
        }

        public virtual void OnDraw(GameTime gameTime) { }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backgroundColor);

            OnDraw(gameTime);
            base.Draw(gameTime);
        }
        #endregion

    }
}