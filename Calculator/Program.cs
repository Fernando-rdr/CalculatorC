using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo, o que deseja fazer?")
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtração");
            System.Console.WriteLine("3 - Divisão");
            System.Console.WriteLine("4 - Multiplicação");

            System.Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção:")
            short res = short.Parse(Console.ReadLine());
        }

        static void Soma()
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

        static void Subtracao()
        {
            Console.Clear();

            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O Resultado da subtração é: {resultado}");
        }
        static void Divisao()
        {
            Console.Clear();

            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            System.Console.WriteLine("");

            System.Console.WriteLine($"O Resultado da divisão é: {resultado}");
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da Multiplicação é: {resultado}");
        }
    }
}
