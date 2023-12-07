using System;

namespace DotnetLists // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            foreach (var item in meuArray)
            {
                
                System.Console.WriteLine(item);
            }



        }
    }
}
            // for (var index = 0; index < meuArray.Length; index++) {
            //     System.Console.WriteLine(meuArray[index]);

            // }

    //         System.Console.WriteLine(meuArray[0].Id);
    //         System.Console.WriteLine(meuArray[1]);
    //         System.Console.WriteLine(meuArray[2]);
    //         System.Console.WriteLine(meuArray[3]);
    //         System.Console.WriteLine(meuArray[4]);

    //     }
    // }
    // struct Teste
    // {
    //     public int Id {}
    // }
            // var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            // meuArray[0] = 12;

            // System.Console.WriteLine(meuArray[0]);
            // System.Console.WriteLine(meuArray[1]);
            // System.Console.WriteLine(meuArray[2]);
            // System.Console.WriteLine(meuArray[3]);
            // System.Console.WriteLine(meuArray[4]);


            // System.Console.WriteLine(meuArray[0]);
            // System.Console.WriteLine(meuArray[1]);
            // System.Console.WriteLine(meuArray[2]);
            // System.Console.WriteLine(meuArray[3]);
            // System.Console.WriteLine(meuArray[4]);