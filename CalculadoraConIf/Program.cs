using System;

namespace CalculadoraConIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese un calculo");
            string calculo = Console.ReadLine();
            string[] operadores = { "+", "-", "*", "/" };
            string[] numeros = calculo.Split(operadores, StringSplitOptions.RemoveEmptyEntries);
            double numero1 = Convert.ToDouble(numeros[0]);
            double numero2 = Convert.ToDouble(numeros[1]);
            string operador = calculo.Substring(calculo.IndexOf(numeros[0]) + 2, 1);
            double resultado = 0;
            if (operador == "+")
            {
                resultado = numero1 + numero2;
            }
            else if (operador == "-")
            {
                resultado = numero1 - numero2;
            }
            else if (operador == "*")
            {
                resultado = numero1 * numero2;
            }
            else if (operador == "/")
            {
                resultado = numero1 / numero2;
            }
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
