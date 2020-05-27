using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FormasGeometrica_POO
{
    abstract class FomasGeometricas
    {
        protected int coordX;
        protected int coordY;

        public FomasGeometricas(int x, int y)
        {
            if (x >= 1 && x <= 1024)
                this.coordX = x;
            else
                this.coordX = 500;

            if (y >= 1 && y <= 768)
                this.coordX = y;
            else
                this.coordY = 500;
        }
        public abstract double perimetro();
        public abstract double area();
    }
}
