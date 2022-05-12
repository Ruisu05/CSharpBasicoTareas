using System;

namespace ValidarDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para ingresar por favor ingrese los datos solicitados");
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Edad:");
            int edad = int.Parse(Console.ReadLine());
            while (edad < 18)
            {
                Console.WriteLine("La edad debe ser mayor o igual a 18");
                Console.WriteLine("Edad:");
                edad = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Bienvenido");
        }
    }
}
