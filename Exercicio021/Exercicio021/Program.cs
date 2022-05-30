using System;

namespace Exercicio021 {
    class Program {
        public static void Main(String[] args) {
            int ano;

            Console.WriteLine("Que ano deseja saber se é bissexto? ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0) {
                Console.WriteLine("Esse ano é bissexto");
        } else {
                Console.WriteLine("Esse nao é bissexto");
            }
    }
}