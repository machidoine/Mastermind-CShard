using System;
using Microsoft.Xna.Framework.Input;

namespace Mastermind.View
{
    class ClickEventArgs: EventArgs
    {
        public MouseState CurrentMouseState { get; set; }

        public ClickEventArgs(MouseState currentMouseState)
        {
            CurrentMouseState = currentMouseState;
        }
    }
}
