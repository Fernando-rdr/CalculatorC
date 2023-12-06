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

            Console.WriteLine("Bem vindo, o que deseja fazer?");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtração");
            System.Console.WriteLine("3 - Divisão");
            System.Console.WriteLine("4 - Multiplicação");
            System.Console.WriteLine("5 - Sair");

            System.Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res) 
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

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

            Console.ReadKey();
            Menu();
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

            Console.ReadKey();
            Menu();
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

            Console.ReadKey();
            Menu();
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
            
            Console.ReadKey();
            Menu();
        }
    }
}

            // if (res == 1)
            //     Soma();
            // if (res == 2)
            //     Subtracao();
            // if (res == 3)
            //     Divisao();
            // if (res == 4)
            //     Multiplicacao();
            // if (res >= 0 || res > 4)
            //     System.Console.WriteLine("Opção invalida.");