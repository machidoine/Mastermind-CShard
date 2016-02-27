using System;
using Microsoft.Xna.Framework.Input;

namespace Mastermind.View
{
    class ClickEventArgs: EventArgs
    {
        private MouseState currentMouseState;

        public MouseState CurrentMouseState
        {
            get { return currentMouseState; }
            set { currentMouseState = value; }
        }

        public ClickEventArgs(MouseState currentMouseState)
        {
            this.currentMouseState = currentMouseState;
        }
    }
}
