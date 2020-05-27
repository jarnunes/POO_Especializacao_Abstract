using System;
using System.Collections.Generic;
using System.Text;

namespace FormasGeometrica_POO
{
    class Circulo : FomasGeometricas
    {
        private double raio;
        public Circulo(int x, int y, double raio) : base(x, y)
        {
            this.raio = raio;
        }
        public override double area()
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        public override double perimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
