using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace InvasionEngine.Core.UI.Controls
{
    public abstract class UIControl
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public void SetDimensions(int x, int y, int width, int height) { this.X = x; this.Y = y; this.Width = width; this.Height = height; }
        public abstract void LoadContent(ContentManager content);
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
        public abstract void Update(GameTime gameTime);
    }
}
