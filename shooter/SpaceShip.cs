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
        private float velocidad;
        private int coordX;
        private int coordY;
        private Rectangle hitBox; 
        public Texture2D Texture
        {
            get { return texture; }
        }

        public SpaceShip(int coordX,int coordY){
            this.coordX = coordX;
            this.coordY = coordY;
        }

        public void mover(Sentido sentido)
        {
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
