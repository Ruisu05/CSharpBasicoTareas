using System;

namespace T2HIstoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del protagonista: ");
            string protagonista = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la ciudad: ");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la mano deracha del protagonista: ");
            string manoDerecha = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del mago de la corte: ");
            string magoCorte = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la princesa: ");
            string princesa = Console.ReadLine();

            Console.WriteLine($"Hace mucho tiempo en la ciudad de {ciudad} habia una espada clavada en una piedra y segun el mago de la corte {magoCorte} " +
                $"cualquier persona capaz de retirar la espada se convertiria en el rey, por muchos años lo intentaron pero no lo lograron, hasta que un dia {protagonista} " +
                $"un simple joven logro sacar la espada de la piedra y junto a su mano deracha {manoDerecha} y su esposa, quien se convertiria en princesa, {princesa} reino como un rey justo");
        }
    }
}
