using System;
using System.Runtime.Intrinsics.Arm;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine(v1);
        }
    }
}