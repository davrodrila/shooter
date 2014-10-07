using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using shooter.Interfaces;


namespace shooter
{
    class SpaceShip
    {
        private string texture_path = "Sprites/ship";
        private Texture2D texture;
        private int speed = 5;
        private Rectangle hitBox;
        private Vector2 direction;
        private int shootDelay = 100;
        private int missileAmmunition = 4;
        public int ShootDelay
        {
            get { return shootDelay; }
        }
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
            texture = content.Load<Texture2D>(texture_path);
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
            batch.Draw(texture, hitBox,Color.Pink);
        }

        public Bullet shoot(ContentManager content)
        {
            return new Bullet(content,hitBox.X,hitBox.Y);
        }

        public IMissil shootMissil()
        {
            if (missileAmmunition == 0)
            {
                return new EmptyMissil();
            }else
            {
                return new StandardMissil();
                missileAmmunition--;
            }
        }
    }
}
