using System;

namespace Brasileirao
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo a;
             Tabela a = new Tabela();

            do {
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("Enter - Time e pontuação \n2 - Mostra a tabela");
                System.Console.WriteLIne("Informe sua opção");
                a = Console.ReadKey();
                if (a.Key == ConsoleKey.D1) {
                    System.Console.WriteLine("nome do time");
                    String time = Console.ReadLine();
                    System.Console.WriteLine("pontuação");
                        String pont = Console.ReadLine();
                        a.timea.Add(new Times(time, Int32.Parse(pont)));
                        times.Sport(pont, a.pont);
                        {
                        } while (a.Key != Console)


        }
    }
}