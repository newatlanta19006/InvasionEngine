using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using InvasionEngine.Core.UI.Controls;

namespace InvasionEngine.Core.UI.UIEngine
{
    public class UIEngine
    {
        List<UIMenu> activeMenus;
        public ContentManager content;

        public UIEngine() 
        {
            activeMenus = new List<UIMenu>();
            LoadTestMenus();
        }

        public void Initialize(Game game) 
        {
            content = new ContentManager(game.Services);
            content.RootDirectory = "InvasionEngineContent";
        }

        public void LoadContent() 
        {
            foreach (UIMenu menu in activeMenus)
            {
                menu.LoadContent(content);
            }
        }

        public void UnloadContent() { }

        public void Update(GameTime gameTime) 
        {
            foreach (UIMenu menu in activeMenus)
            {
                menu.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch) 
        {
            spriteBatch.Begin();
            foreach (UIMenu menu in activeMenus)
            {
                menu.Draw(gameTime, spriteBatch);
            }
            spriteBatch.End();
        }

        public void LoadTestMenus()
        {
            UIMenu menu = new UIMenu();
            UIControlWindow testWindow1 = new UIControlWindow();
            UIControlWindow testWIndow2 = new UIControlWindow();
            testWindow1.BackgroundColor = Color.Red;
            testWindow1.SetDimensions(0, 0, 500, 500);
            testWIndow2.BackgroundColor = Color.Green;
            testWIndow2.SetDimensions(350, 150, 230, 100);

            menu.controls.Root.AddChild(testWindow1);
            menu.controls.Root.AddChild(testWIndow2);

            activeMenus.Add(menu);
        }
    }
}
