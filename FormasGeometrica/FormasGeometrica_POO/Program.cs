using System;

namespace FormasGeometrica_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            FomasGeometricas[] figuras = new FomasGeometricas[6];
            Quadrado quad1 = new Quadrado(1, 1, 7);
            Quadrado quad2 = new Quadrado(1, 1, 8);
            Quadrado quad3 = new Quadrado(1, 1, 9);

            Circulo circ1 = new Circulo(1, 1, 12);
            Circulo circ2 = new Circulo(1, 1, 13);
            Circulo circ3 = new Circulo(1, 1, 15);

            figuras[0] = quad1;
            figuras[1] = quad2;
            figuras[2] = quad3;
            figuras[3] = circ1;
            figuras[4] = circ2;
            figuras[5] = circ3;

            foreach (FomasGeometricas f in figuras)
            {
                Console.WriteLine($"Área da figura: {f.area()}");
                Console.WriteLine($"Perímetro da figura: {f.perimetro()}");
            }

        }
    }
}
