using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class TextEditor
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("O que voc deseja fazer?");
            System.Console.WriteLine("1 - Abrir arquivo");
            System.Console.WriteLine("2 - Criar novo arquivo");
            System.Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0 : System.Environment.Exit(0); break;
                case 1 : Abrir(); break;
                case 2 : Editar(); break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {
            
        }
        static void Editar() 
        { 
            Console.Clear();
            System.Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
            System.Console.WriteLine("----------------");
            string text = "";

            while(Console.ReadKey().Key != ConsoleKey.Escape)
        }
    }
}