using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            var formatada = string.Format("{0:d/M/yy hh:mm:ss ff}", data);
            System.Console.WriteLine(formatada);

        }
    }
}

            // var data = new DateTime(2023, 12, 31, 11, 22, 02);
            // // var data = DateTime.Now;
            // System.Console.WriteLine(data);
            // System.Console.WriteLine(data.Year);
            // System.Console.WriteLine(data.Month);
            // System.Console.WriteLine(data.Day);
            // System.Console.WriteLine(data.Hour);
            // System.Console.WriteLine(data.Minute);
            // System.Console.WriteLine(data.Second);
            // System.Console.WriteLine(data.DayOfWeek);
            // System.Console.WriteLine(data.DayOfYear);