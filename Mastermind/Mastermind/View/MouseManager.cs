using Microsoft.Xna.Framework.Input;

namespace Mastermind.View
{
    class MouseManager
    {

        MouseState _lastMouseState;
        MouseState _currentMouseState;

        public delegate void ClickHandler(ClickEventArgs clickEventArgs);
        public event ClickHandler ClickLeftEvent;

        private static MouseManager _instance;


        internal static MouseManager Instance
        {
            get { return _instance ?? (_instance = new MouseManager()); }
        }


        private MouseManager()
        {
            _lastMouseState = Mouse.GetState();
            _currentMouseState = Mouse.GetState();
        }

        public void Update()
        {
            _lastMouseState = _currentMouseState;
            _currentMouseState = Mouse.GetState();

            if (DetectLeftClick())
            {
                HandleLeftClick();
            }

        }

        private void HandleLeftClick()
        {
            if (ClickLeftEvent != null)
            {
                ClickLeftEvent(new ClickEventArgs(_currentMouseState));
            }
        }


        private bool DetectLeftClick()
        {
            return _lastMouseState.LeftButton == ButtonState.Released && _currentMouseState.LeftButton == ButtonState.Pressed;
        }


    }
}
