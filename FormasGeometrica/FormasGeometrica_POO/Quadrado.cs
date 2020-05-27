using System;
using System.Collections.Generic;
using System.Text;

namespace FormasGeometrica_POO
{
    class Quadrado : FomasGeometricas
    {
        private double lado;
        public Quadrado(int x, int y, double lado) : base(x, y)
        {
            this.lado = lado;
        }
        public override double area()
        {
            return Math.Pow(lado, 2);
        }

        public override double perimetro()
        {
            return 4 * lado;
        }
    }
}
