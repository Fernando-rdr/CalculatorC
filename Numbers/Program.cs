using System;
using System.Globalization;

namespace Numbers // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            
            decimal valor = 10536.25m;
            

            System.Console.WriteLine(
                Math.Round(valor)
            );
            System.Console.WriteLine(Math.Ceiling(valor));
            System.Console.WriteLine(Math.Floor(valor));
        }
    }
}


            // System.Console.WriteLine(
            //     valor.ToString("C", 
            //         CultureInfo.CreateSpecificCulture("en-IT")));