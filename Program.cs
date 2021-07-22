using System;

namespace Desafiodiferenca
{    class Program
    {
        static void Main(string[] args)
        {
        double A = Convert.ToDouble(Console.ReadLine());
        double B = Convert.ToDouble(Console.ReadLine());
        double C = Convert.ToDouble(Console.ReadLine());
        double D = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("DIFERENCA = " + (A * B - C * D));
         Console.ReadKey();

        }
    }
}