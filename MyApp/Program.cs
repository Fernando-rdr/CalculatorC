using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            System.Console.WriteLine(DateTime.Now.ToString("D", atual));
            // System.Console.WriteLine(string.Format());

        }
    }
}
            // var data = DateTime.Now;

            // if (data.Date == DateTime.Now.Date){
            //     System.Console.WriteLine("É Igual");
            // }
            // System.Console.WriteLine(data);

            // System.Console.WriteLine(data);

            // System.Console.WriteLine(data.AddDays(12));
            // System.Console.WriteLine(data.AddMonths(-1));
            // System.Console.WriteLine(data.AddYears(1));
            

            // var formatada = string.Format("{0:d}", data);
            // System.Console.WriteLine(formatada);

            // var formatada = string.Format("{0:d/M/yy hh:mm:ss ff}", data);

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