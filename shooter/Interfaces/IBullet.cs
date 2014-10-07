using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace shooter.Interfaces
{
    interface IBullet
    {
        void Draw(SpriteBatch spriteBatch);
        void move(Vector2 direction);
        int Speed {get;}
        Texture2D Texture
        {
            get;
        }
    }
}
