using System.Collections.Generic;

namespace Mastermind.View
{
    class SpriteManager
    {
        List<Sprite> _sprites;

        internal List<Sprite> Sprites
        {
            get { return _sprites; }
            set { _sprites = value; }
        }

        public SpriteManager()
        {
            _sprites = new List<Sprite>();
        }

        public void AddSprite(Sprite sprite)
        {
            _sprites.Add(sprite);
        }
    }
}
