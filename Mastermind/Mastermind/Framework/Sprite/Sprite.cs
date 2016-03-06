using System;
using Mastermind.Framework.Composite;
using Mastermind.Framework.Input.Mouse;
using Mastermind.Framework.Vistor;
using Mastermind.View;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mastermind.Framework.Sprite
{
    class Sprite : Composite<ISprite>, IMouseEventAware, ISprite
    {
        public event EventHandler<ClickEventArgs> MouseClicked;

        public Texture2D Texture2D { get; private set; }
        public Vector2 Position { get; set; }
 



        public Sprite()
        {
            MouseManager.Instance.ClickLeftEvent += MouseManager_ClickLeftEvent;
        }

        void MouseManager_ClickLeftEvent(ClickEventArgs clickEventArgs)
        {
            if (MouseClicked != null && IsOn(clickEventArgs.CurrentMouseState.X, clickEventArgs.CurrentMouseState.Y))
            {
                MouseClicked(this, clickEventArgs);
            }
        }

        private bool IsOn(int mouseX, int mouseY)
        {
            Rectangle rect = new Rectangle((int)Math.Round(Position.X), (int)Math.Round(Position.Y), Texture2D.Width, Texture2D.Height);
            return rect.Contains(new Point(mouseX, mouseY));
        }

        public void LoadContent(ContentManager contentManager, String assetName)
        {
            Texture2D = contentManager.Load<Texture2D>(assetName);
        }


/*        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture2D, Position, Color.White);
        }*/

        public override void Accept(IVisitor<ISprite> vistor)
        {
            vistor.Visit(this);
        }
    }
}
