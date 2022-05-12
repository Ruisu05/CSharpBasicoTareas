using System;
using System.Collections.Generic;

namespace NumeroDeComensales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int comensales;
            List<string> orden = new List<string>();
            int salir;

            Console.WriteLine("¿Cuantos comensales hay?");
            comensales = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < comensales; i++)
            {
                Console.WriteLine($"Cual es el nombre del comensal numero {i + 1}?");
                orden.Add(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("Que plato desea?");
                    orden.Add(Console.ReadLine());
                    Console.WriteLine("Es todo?\n1 - Si\n2 - No");
                    salir = Convert.ToInt32(Console.ReadLine());
                    if (salir == 1)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < orden.Count; i++)
            {
                Console.WriteLine(orden[i]);
            }
        }
    }
}
