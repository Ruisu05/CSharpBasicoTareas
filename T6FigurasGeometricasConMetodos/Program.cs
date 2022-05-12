using System;

namespace T6FigurasGeometricasConMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de la base: ");
            double base_ = double.Parse(Console.ReadLine()); // base_ porque base es una palabra reservada
            Console.WriteLine("Ingrese el valor de la base2: ");
            double base2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del radio: ");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la diagonal mayor: ");
            double diagonalMayor = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la diagonal menor: ");
            double diagonalMenor = double.Parse(Console.ReadLine());

            double aTriangulo = AreaTriangulo(base_, altura);
            Console.WriteLine("El area del triangulo es: " + aTriangulo);
            double aRectangulo = AreaRectangulo(base_, altura);
            Console.WriteLine("El area del rectangulo es: " + aRectangulo);
            double aTrapecio = AreaTrapecio(base_, base2, altura);
            Console.WriteLine("El area del trapecio es: " + aTrapecio);
            double aCirculo = AreaCirculo(radio);
            Console.WriteLine("El area del circulo es: " + aCirculo);
            double aRombo = AreaRombo(diagonalMayor, diagonalMenor);
            Console.WriteLine("El area del rombo es: " + aRombo);
        }

        public static double AreaTriangulo(double base_, double altura)
        {
            double aTriangulo = (base_ * altura) / 2;
            return aTriangulo;
        }

        public static double AreaRectangulo(double base_, double altura)
        {
            double aRectangulo = base_ * altura;
            return aRectangulo;
        }
        public static double AreaTrapecio(double base_, double base2, double altura)
        {
            double aTrapecio = ((base_ + base2) * altura) / 2;
            return aTrapecio;
        }
        public static double AreaCirculo(double radio)
        {
            double aCirculo = 3.14 * (radio * radio);
            return aCirculo;
        }
        public static double AreaRombo(double diagonalMayor, double diagonalMenor)
        {
            double aRombo = (diagonalMayor * diagonalMenor) / 2;
            return aRombo;
        }
    }
}
