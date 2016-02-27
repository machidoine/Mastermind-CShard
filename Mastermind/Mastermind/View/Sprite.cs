using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mastermind.View
{
    class Sprite : IMouseEventAware
    {
        public event EventHandler<ClickEventArgs> MouseClicked;

        private Texture2D _texture2D;

        private Vector2 _position;
        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Sprite()
        {
            MouseManager.Instance.ClickLeftEvent += Instance_ClickLeftEvent;
        }

        void Instance_ClickLeftEvent(ClickEventArgs clickEventArgs)
        {
            if (MouseClicked != null && IsOn(clickEventArgs.CurrentMouseState.X, clickEventArgs.CurrentMouseState.Y))
            {
                MouseClicked(this, clickEventArgs);
            }
        }

        private bool IsOn(int mouseX, int mouseY)
        {
            Rectangle rect = new Rectangle((int)Math.Round(_position.X), (int)Math.Round(_position.Y), _texture2D.Width, _texture2D.Height);
            return rect.Contains(new Point(mouseX, mouseY));
        }

        public void LoadContent(ContentManager contentManager, String assetName)
        {
            _texture2D = contentManager.Load<Texture2D>(assetName);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture2D, _position, Color.White);
        }

        
    }
}
