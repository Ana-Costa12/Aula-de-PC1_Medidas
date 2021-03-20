using System;

namespace Aula_de_PC1_Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros;
            double km = 0.001;
            double cm = 100;

            Console.WriteLine("Vamos transformar metros em centímetros e quilômetros!\n------------------------------------------------------\n\nTecle enter para começar:");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Digite o valor de metros para a conversão:");
            Console.ResetColor();
            metros = double.Parse(Console.ReadLine());

            Console.WriteLine("Tecle enter para ver os resultados:");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{metros} metros é equivalente a:\n{metros * cm} Centímetros\nE\n{metros * km} Quilômetros");
            Console.ResetColor();

        }
    }
}
