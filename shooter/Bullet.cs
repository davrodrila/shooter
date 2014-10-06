using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace shooter
{
    class Bullet
    {
        private string texture_path = "Sprites/shoot";
        private Texture2D texture;
        private Rectangle hitBox;
        private int speed;
      
        public Bullet(ContentManager content, int coordX,int coordY)
        {
            texture = content.Load<Texture2D>(texture_path);
            hitBox = new Rectangle(coordX, coordY, texture.Width, texture.Height);
            speed = 5;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, hitBox, Color.SeaGreen);
        }

        public void move(Vector2 direction) 
        {
            hitBox.X += (int) direction.X;
            hitBox.Y += (int) direction.Y;
        }

        public int Speed
        {
            get { return speed; }
        }
        public Texture2D Texture
        {
            get { return texture; }
        }
    }
}
