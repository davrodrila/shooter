using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace shooter
{
    class SpaceShip
    {
        private Texture2D texture;
        private float speed=5;
        private Rectangle hitBox; 
        public Texture2D Texture
        {
            get { return texture; }
        }

        public SpaceShip(int coordX,int coordY, GraphicsDevice graphicsDevice)
        {
            hitBox = new Rectangle(coordX,coordY,100,100);
            texture = new Texture2D(graphicsDevice,);
        }

        public void mover(Sentido sentido)
        {
            switch (sentido)
            { 
                case Sentido.Up:
                    
                    break;
                case Sentido.Down:
                    break;
                case Sentido.Right:
                    break;
                case Sentido.Left:
                    break;
                default:
                    break;
            }
        }
    }

    enum Sentido
    {
        Up,
        Down,
        Right,
        Left
    }
}
