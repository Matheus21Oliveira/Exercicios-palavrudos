using System;

namespace Exercicio026 {
    class Program {
        public static void Main(String[] args) {
            int numero1, numero2;

            Console.WriteLine("insira o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o segundo valor: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 < numero2) {
                Console.WriteLine("o segundo valor é maior");
            } else if (numero1 > numero2) {
                Console.WriteLine("o primeiro valor é maior");
            } else {
                Console.WriteLine("os valores sao iguais");
            }
        }
    }
}