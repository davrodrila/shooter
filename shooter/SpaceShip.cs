using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace shooter
{
    class SpaceShip
    {
        private Texture2D texture;
        private int speed = 5;
        private Rectangle hitBox;
        public Texture2D Texture
        {
            get { return texture; }
        }

        public SpaceShip(int coordX, int coordY, ContentManager content)
        {            
            texture = content.Load<Texture2D>("Sprites/ship.png");
            hitBox = new Rectangle(coordX, coordY, texture.Width, texture.Height);
        }

        public void mover(Sentido sentido)
        {
            switch (sentido)
            {
                case Sentido.Up:
                    hitBox.Y -= speed;
                    break;
                case Sentido.Down:
                    hitBox.Y += speed;
                    break;
                case Sentido.Right:
                    hitBox.X += speed;
                    break;
                case Sentido.Left:
                    hitBox.X -= speed;
                    break;
                default:
                    break;
            }
        }

        public void Draw(SpriteBatch batch)
        {
            batch.Draw(texture, hitBox, Color.Pink);
        }
}
public enum Sentido
    {
        Up,
        Down,
        Right,
        Left
    }
}
