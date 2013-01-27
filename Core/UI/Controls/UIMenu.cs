using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using InvasionEngine.Core.Util.DataStructures;

namespace InvasionEngine.Core.UI.Controls
{
    public class UIMenu
    {
        public NodeTree<UIControlBase> controls;

        public UIMenu() { }

        public void Update(GameTime gameTime) { }

        public void Draw(GameTime gameTime) { }
    }
}
