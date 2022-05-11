using System;

namespace Exercicio012 {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Qual o preço do produto? ");
            double produto = double.Parse(Console.ReadLine());

            double promocao = 0;

            promocao = produto / 0.05;

            Console.WriteLine("Preço promocional do produto é de: " + promocao);
        }
    }
}