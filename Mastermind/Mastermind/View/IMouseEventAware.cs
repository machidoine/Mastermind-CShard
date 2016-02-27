using System;

namespace Mastermind.View
{
    interface IMouseEventAware
    {
        event EventHandler<ClickEventArgs> MouseClicked;
    }
}
