using System;

namespace console_dotnet
{
    class Acesso
    {
        public void numerogerado(int a, int b) {
            Random t = new Random();
            int d = t.Next(a, b);
            int f = t.Next(a, b);
            int soma = d + f;
            System.Console.WriteLine(d + "+" + f);
            
            int resp = Convert.ToInt32(Console.ReadLine());

            if (resp == soma) {
                System.Console.WriteLine("Acesso Permitido");
            }
            else{
                System.Console.WriteLine("Acesso Negado");
            }

        }
    }
}