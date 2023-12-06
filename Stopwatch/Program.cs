using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Stopwath
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                currentTime++;
            }
        }
    }
}