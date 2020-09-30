using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.WriteLine("Digite o Valor 01 : ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor 02: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine($"Sua conta é: {valor1 + valor2}");

            Console.WriteLine("ENTER para sair");
            Console.ReadKey();
        }
    }
}