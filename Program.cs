using System;

namespace tabelaCampeonato
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo a;
            Tabela t = new Tabela();

            do {
                System.Console.WriteLine("Menu:");
                System.Console.WriteLine("1 - Time e pontuação \n2 - mostra a tabela");
                System.Console.WriteLine("Informe sua opção:");
                a = Console.ReadKey();
                if (a.Key == ConsoleKey.D1) {
                    System.Console.WriteLine("Time:");
                    string time = Console.ReadLine();
                    System.Console.WriteLine("Pontuação:");
                    string pont = Console.ReadLine();
                    t.times.Add(new Times(time, Int32.Parse(pont)));
                    pont.CompareTo(pont);
                }
            } while (a.Key != ConsoleKey.D2);

            System.Console.WriteLine("Tabela");
            t.resultado();
        }
    }
}