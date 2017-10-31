using System;

namespace console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            nome = "Grovy";
            // Console.WriteLine("Opaaaaaaa");
            Console.WriteLine(nome);

            Double valor = 2.2;
            Double quantidade = 6.888;
            Double resultado = valor * quantidade;
            Console.WriteLine(resultado);

            Boolean maiorQueDez = (resultado > 10);
            if (maiorQueDez) {
                System.Console.WriteLine($"{resultado} é maior que dez");
            } else {
                System.Console.WriteLine($"{resultado} é menor que dez");
            }
                Grovy a = new Grovy();
                System.Console.WriteLine(a.calc(6, 2, 3));
                System.Console.WriteLine(a.calc2(10, 35, 22));
                Acesso q = new Acesso();
                q.numerogerado(0,9);
            
        }
    }
}