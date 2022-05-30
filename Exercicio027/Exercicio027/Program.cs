using System;

namespace Exercicio027 {
    class Program {
        public static void Main(String[] args) {
            double media, nota1, nota2;

            Console.WriteLine("insira a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("insira a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media <= 4.9) {
                Console.WriteLine("reprovado");
            } else if (media <= 6.9 ) {
                Console.WriteLine("recuperaçao");
            } else {
                Console.WriteLine("aprovado");
            }
        }
    }
}