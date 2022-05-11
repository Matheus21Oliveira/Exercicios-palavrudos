using System;

namespace Exercicio020 {
    class program {
        public static void Main(String[] args) {
            int numero;

            Console.Write("Me diga um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("Esse numero é par!");
            } else {
                Console.WriteLine("Esse numero é impar!");
            }
        }
    }
}