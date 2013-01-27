using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace InvasionEngine.Core.UI.Controls
{
    public class UIControlWindow:UIControlBase
    {
        public string TextureName { get; set; }
        public Texture2D Texture { get; private set; }

        public UIControlWindow() : base()
        {
            this.TextureName = null;
            this.Texture = null;
        }

    }
}
