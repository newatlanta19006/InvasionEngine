using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace InvasionEngine.Core.UI.Controls
{
    public class UIControlWindow:UIControl
    {
        public Color BackgroundColor { get; set; }
        private Texture2D BackgroundTexture;

        public UIControlWindow() : base()
        {
        }

        public override void LoadContent(ContentManager content)
        {
            BackgroundTexture = content.Load<Texture2D>("UIEngine\\White1x1");
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(BackgroundTexture, new Rectangle(X, Y, Width, Height), BackgroundColor);
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
