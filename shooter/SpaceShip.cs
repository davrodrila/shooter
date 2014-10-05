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
        private int coordX;
        private int coordY;
        private Rectangle hitBox; 
        public Texture2D Texture
        {
            get { return texture; }
        }

        public SpaceShip(int coordX,int coordY, GraphicsDevice graphicsDevice)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            texture = new Texture2D(graphicsDevice,);
        }

        public void mover(Sentido sentido)
        {
            switch (sentido)
            { 
                case Sentido.Arriba:
                    break;
                case Sentido.Abajo:
                    break;
                case Sentido.Derecha:
                    break;
                case Sentido.Izquierda:
                    break;
                default:
                    break;
            }
        }
    }

    enum Sentido
    {
        Arriba,
        Abajo,
        Derecha,
        Izquierda
    }
}
