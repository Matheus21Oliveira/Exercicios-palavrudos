using System;

namespace Exercicio004 {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = 0;

            soma = valor1 + valor2;

            Console.WriteLine("A soma de " + valor1 + " + " + valor2 + " é de: " + soma);
        }
    }
}