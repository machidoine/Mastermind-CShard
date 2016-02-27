using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mastermind.View
{
    class Sprite : IMouseEventAware
    {
        public event EventHandler<ClickEventArgs> MouseClicked;

        private Texture2D texture2d;

        private Vector2 position;
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Sprite()
        {
            MouseManager.Instance.ClickLeftEvent += Instance_ClickLeftEvent;
        }

        void Instance_ClickLeftEvent(ClickEventArgs clickEventArgs)
        {
            if (MouseClicked != null && isOn(clickEventArgs.CurrentMouseState.X, clickEventArgs.CurrentMouseState.Y))
            {
                MouseClicked(this, clickEventArgs);
            }
        }

        private bool isOn(int mouseX, int mouseY)
        {
            Rectangle rect = new Rectangle((int)Math.Round(position.X), (int)Math.Round(position.Y), texture2d.Width, texture2d.Height);
            return rect.Contains(new Point(mouseX, mouseY));
        }

        public void LoadContent(ContentManager contentManager, String assetName)
        {
            texture2d = contentManager.Load<Texture2D>(assetName);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture2d, position, Color.White);
        }

        
    }
}
