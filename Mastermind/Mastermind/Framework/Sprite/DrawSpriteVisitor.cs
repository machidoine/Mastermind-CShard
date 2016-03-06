using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Mastermind.Framework.Vistor;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mastermind.Framework.Sprite
{
    class DrawSpriteVisitor : CompositeVisitor<ISprite>
    {
        public static void Draw(ISprite sprite, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            
            DrawSpriteVisitor drawVisitor = new DrawSpriteVisitor(spriteBatch);
            sprite.Accept(drawVisitor);

            spriteBatch.End();
        }
        private readonly SpriteBatch _spriteBatch;

        public DrawSpriteVisitor(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
        }

        public override void Visit(ISprite sprite)
        {
            _spriteBatch.Draw(sprite.Texture2D, sprite.Position, Color.White);
        }
    }
}
