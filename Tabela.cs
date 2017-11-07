using System;
using System.Collections.Generic;

namespace Brasileirao
{
    class Tabela
    {
        public List<Times> times = new List<Times>();
        public void tabela() {
            System.Console.WriteLine("Tabela");
            System.Console.WriteLine("Enter - Adiciona times e pontuação\n0 - Mostra o resultado da tabela");

            while (Console.ReadKey().Key == ConsoleKey.Enter) {
                System.Console.WriteLine("Informe o nome do time: ");
                string time = Console.ReadLine();

                 System.Console.WriteLine("pontuação do time: ");
                int pontuacao = Convert.ToInt32(Console.ReadLine());
                this.times.Add(new Times(time, pontuacao));
            }

            for (int i = 0; i < times.Count; i++) {
                times[i].dados();
            }
        }
    }
}