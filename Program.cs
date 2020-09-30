using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.WriteLine("Digite o 1ºValor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2ºValor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine($"Seu resultado é: {valor1 + valor2}");

            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
        }
    }
}