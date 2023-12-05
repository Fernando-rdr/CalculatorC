using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 + v2;
            System.Console.WriteLine("O Resultado da soma é: " + resultado);

            System.Console.WriteLine($"O Resultado da soma é: {resultado}");

            System.Console.WriteLine($"O Resultado da soma é: {v1 + v2}");

        }
    }
}
