using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lain_Bootleg_DUX.GameContent
{
    public class LainInterfaceScene : GameScene
    {
        Texture2D texture;

        public LainInterfaceScene()
        {

        }

        public override void OnInitialize()
        {
           
        }

        public override void OnLoadContent()
        {
            texture = GraphicsDevice.LoadTexture2D("Asset/lainSprite/upscaledBootlegSprites/460.png");

            DLog.Log(texture.Width + " || " + texture.Height);
        }

        public override void OnUpdate(GameTime gameTime)
        {
           
        }

        public override void OnDraw(GameTime gameTime)
        {
            _spriteBatch.Begin();

            _spriteBatch.Draw(texture, Vector2.Zero, Color.White);

            _spriteBatch.End();
        }
    }
}
