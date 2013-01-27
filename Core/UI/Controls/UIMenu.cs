using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using InvasionEngine.Core.Util.DataStructures;

namespace InvasionEngine.Core.UI.Controls
{
    public class UIMenu
    {
        public NodeTree<UIControl> controls;

        public UIMenu() 
        {
            controls = new NodeTree<UIControl>();
            controls.Root = new Node<UIControl>(new UIControlWindow());
        }

        public void LoadContent(ContentManager content)
        {
            foreach (Node<UIControl> node in controls)
            {
                node.Value.LoadContent(content);
            }
        }

        public void Update(GameTime gameTime) 
        {
            foreach (Node<UIControl> node in controls)
            {
                node.Value.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch) 
        {
            foreach (Node<UIControl> node in controls)
            {
                node.Value.Draw(gameTime, spriteBatch);
            }
        }
    }
}
