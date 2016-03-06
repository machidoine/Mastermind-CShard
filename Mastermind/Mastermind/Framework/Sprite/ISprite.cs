using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mastermind.Framework.Composite;
using Mastermind.Framework.Vistor;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mastermind.Framework.Sprite
{
    interface ISprite : IComposite<ISprite>
    {
        void LoadContent(ContentManager contentManager, String assetName);
        
        Texture2D Texture2D { get; }

        Vector2 Position { get; set; }

        void Accept(IVisitor<ISprite> visitor);
    }
}
