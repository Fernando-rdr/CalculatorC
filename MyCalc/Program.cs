using System;

namespace MyCalc // Note: actual namespace depends on the project name.
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
            System.Console.WriteLine("Menu da Calculadora");
            System.Console.WriteLine("Digite qualquer tecla para iniciar");
            System.Console.WriteLine("1 - Somar!");
            System.Console.WriteLine("2 - Subtrair!");
            System.Console.WriteLine("3 - Multiplicar");
            System.Console.WriteLine("4 - Dividir");
            System.Console.WriteLine("0 - Encerrar Programa!");
            short res = short.Parse(Console.ReadLine());
            
            switch (res) {
                case 1: Soma();break;  
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 0: System.Environment.Exit(0); break;
                default: System.Console.WriteLine("Opção Invalida"); break;
            } 
            Console.ReadKey();
            Menu();

        }

        static void Soma()
        {
            Console.Clear();
            System.Console.WriteLine("Somando dois numeros!");
            System.Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            var resultado = v1 + v2;

            System.Console.WriteLine($"Primeiro valor {v1} e segundo valor {v2} Resultado {resultado}");

            Console.ReadKey();
            Menu();
   
        }
        static void Subtrair()
        {
            Console.Clear();
            System.Console.WriteLine("Subtraia dois numeros");
            System.Console.WriteLine("Digite o Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo numero");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            System.Console.WriteLine($"Primeiro valor da Subtração {v1} Segundo valor {v2} Resultado {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicar()
        {
            Console.Clear();

            System.Console.WriteLine("Multipicando dois numeros!");
            System.Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float res = v1 * v2;

            System.Console.WriteLine($"Primeiro valor {v1} Segundo valor {v2} Resultado: {res}");

            Console.ReadKey();
            Menu();

        }
        static void Dividir()
        {
            Console.Clear();

            System.Console.WriteLine("Dividindo dois numeros");
            System.Console.WriteLine("Digite o primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());
            float res = v1 / v2;

            System.Console.WriteLine($"O primeiro valor {v1} Segundo valor {v2} Resultado {res}");

            Console.ReadKey();
            Menu();
        }
    }
}

