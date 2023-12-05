// See https://aka.ms/new-console-template for more information
using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            var mouse = new Product(1, "mouse gamer", 299.99);

            System.Console.WriteLine(mouse.Id);
            System.Console.WriteLine(mouse.Name);
            System.Console.WriteLine(mouse.Price);
        }
    }
    struct Product {

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name;
        public double Price;

        public double PriceInDolar(double dolar) {
            return Price * dolar;
        }
    }
}






















            // var arr = new string[2];
            // arr[0] = "Item 1";

            // var arr2 = arr;

            // Console.WriteLine(arr[0]);
            // System.Console.WriteLine(arr2[0]);

            // arr[0] = "Item 2";

            // System.Console.WriteLine(arr[0]);
            // System.Console.WriteLine(arr2[0]);
            // int x = 25;
            // int y = x;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // x = 32;

            // Console.WriteLine(x);
            // Console.WriteLine(y);
        // {
        //     MeuMetodo();

        //     string nome = RetornaNome("Fernando", "Rodrigues", 34);
        //     Console.WriteLine(nome);
        // }

        // static void MeuMetodo() 
        // {
        //     Console.WriteLine("C#, é legal.");
        // }

        // static string RetornaNome(
        //     string nome,
        //     string sobrenome,
        //     int idade = 0
        //     ) 
        //     {
        //     return nome + " " + sobrenome + " tem " + idade.ToString();
            // int valor = 0;

            // do {
            //     Console.WriteLine(valor);
            //     valor++;
            // } while(valor <= 100);
            // int valor = 0;
            // while (true)
            // {
            //     Console.WriteLine(valor);
            //     valor++;
            // }
            // for (int i=5; i>=1;i--) {
            //     Console.WriteLine(i);

            // bool? valor = false;
            // switch (valor) {
            //     case true: Console.WriteLine("Opção verdadeira");
            //     break;
            //     case false: Console.WriteLine("Opção falsa");
            //     break;
            //     default: Console.WriteLine("Opção invalida/Nulla.");
            //     break;

            // string valor = "Fernando";
            // switch (valor) {
            //     case "A": Console.WriteLine("opção 1");
            //     break;
            //     case "B": Console.WriteLine("opção 3");
            //     break;
            //     case "Fernando": Console.WriteLine("Opção 3");
            //     break;
            //     default: Console.WriteLine("Não encontrei");    
            //     break;
            // }


            // int idade = 18;
            // int maioridade = 21;
            // if (idade >= maioridade) {
            //     Console.WriteLine("Maior de idade");
            // } else {
            //     Console.WriteLine("Menor de idade");
            // }
            // Console.WriteLine("Finalizou o programa.");
            // bool entre = x > 25 && x < 40;
            // Console.WriteLine(entre);
            // bool ou = x > 25 || x < 40;
            // Console.WriteLine(ou);
            // bool negacao = !(x < 25);
            // Console.WriteLine(negacao);

            // x += 5 é o mesmo que x = x + 5
            // x -= 5 é o mesmo que x = x - 5
            // x *= 5 é o mesmo que x = x * 5
            // x /= 5 é o mesmo que x = x / 5


            // int x = 2 + 2 * 2;
            // Console.WriteLine(x);
            // int y = 2 + (2*2);
            // Console.WriteLine(y);
            // int z = (2 + 2) * 2;
            // Console.WriteLine(z);

            // int soma = 25 + 22;
            // Console.WriteLine(soma);
            // int subtracao = 25 - 22;
            // Console.WriteLine(subtracao);
            // int divisao = 25 * 22;
            // Console.WriteLine(divisao);
            // int mult = 22 / 5;
            // Console.WriteLine(mult);


            // int inteiro = 100;
            // float real = 25.8f;

            // inteiro = Convert.ToInt32(real);
            // string valorReal = real.ToString();
            // inteiro = int.Parse(valorReal);
            // real = inteiro;
            // inteiro = real;          errado
            // inteiro = (int)real;     explicito
            // Console.WriteLine(valorReal);
            // Console.WriteLine(inteiro);
            // Console.WriteLine(Convert.ToBoolean(1));

            /*
            int? idade = 0;
            Console.WriteLine(idade);
            idade = null;
            Console.WriteLine(idade);
            idade = 25;
            Console.WriteLine(idade);
            */
            /*
            object qtde;
            qtde = 2.5;
            qtde = 1;
            qtde = "Teste";
            */

            /* string
            string primeiraLetra = "C";
            string texto = "Meu texto";
            var documento = "12345.99";
            */
            /* char
            char primeiraLetra = 'M';
            var segundaLetra = 'D';
            */
            // float salario = 2.500f;
            // double salarioSemestral = 22.000;
            // decimal salarioAnual = 22.000m;
            // const int IDADE-MIN;
            // const int IDADE-MIN .= 25;
            /* 
            int idade ;
            int idade = 25;
            var idade = 25;
            var idade;
            string gr = "ola";
            */
            /*
            Console.WriteLine(gr);
            string gt = 'Hello';
            Console.WriteLine(gt);
            */
