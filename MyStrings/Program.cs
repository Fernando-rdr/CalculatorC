using System;

namespace MyStrings // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu nome: ");
            var nome = Console.ReadLine();
            System.Console.WriteLine("Digite seu sobrenome: ");
            var sobrenome = Console.ReadLine();

            if (nome == "Fernando" && sobrenome == "Rodrigues") {
                System.Console.WriteLine("Bem vindo Fernando Rodrigues");
            } else if (nome == "Fernando" && sobrenome != "Rodrigues") {
                System.Console.WriteLine("Bem vindo Fernando");
            } else if (nome != "Fernando" && sobrenome == "Rodrigues") {
                System.Console.WriteLine("Parente?");
            } else { 
                System.Console.WriteLine("Ocorreu um erro");
            }
        }
        
    }
}