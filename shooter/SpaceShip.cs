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
        private Vector2 direction;

        public Vector2 Direction
        {
            get { return direction; }
        }
        public Texture2D Texture
        {
            get { return texture; }
        }
        public int Speed
        {
            get { return speed; }
        }
        public SpaceShip(int coordX, int coordY, ContentManager content)
        {            
            texture = content.Load<Texture2D>("Sprites/ship.png");
            hitBox = new Rectangle(coordX, coordY, texture.Width, texture.Height);
            direction = Vector2.Zero;
        }

        public void move(Vector2 direction)
        {
            hitBox.X += (int) direction.X;
            hitBox.Y += (int) direction.Y;
            
        }

        public void Draw(SpriteBatch batch)
        {
            batch.Draw(texture, hitBox, Color.Pink);
        }
    }
    public enum Direction
    {
        Up,
        Down,
        Right,
        Left,
        LeftUp,
        LeftDown,
        RightUp,
        RightDown,
        None
    }
}
