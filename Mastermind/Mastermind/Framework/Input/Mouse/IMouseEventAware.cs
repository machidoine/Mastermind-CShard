using System;

namespace Mastermind.Framework.Input.Mouse
{
    interface IMouseEventAware
    {
        event EventHandler<ClickEventArgs> MouseClicked;
    }
}
