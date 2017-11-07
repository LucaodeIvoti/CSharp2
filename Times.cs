using System;

namespace Brasileirao
{
    class Times
    {
        private string time;
        private int pontuacao;

        public Times(string nomeTime, int pont) {
            this.time = nomeTime;
            this.pontuacao = pont;
        }

        public void dados() {
            System.Console.WriteLine("\nTime: " + time + " \nPontuacao: " + pontuacao);
        }
    }
} 