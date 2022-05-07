using System;

namespace Exercicio006 {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Digite um numero? ");
            int numero = int.Parse(Console.ReadLine());

            int antecessor = numero - 1;

            int sucessor = numero + 1;

            Console.WriteLine("O antecessor de " + numero + " é: " + antecessor);
            Console.WriteLine("O sucessor de " + numero + " é: " + sucessor);
        }
    }
}