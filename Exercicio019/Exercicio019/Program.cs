using System;

namespace Exercicio019 {
    class program {
        public static void Main(String[] args) {
            double nota1, nota2, media;

            Console.Write("Qual a primeira nota? ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Qual a segunda nota? ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 * nota2) / 2;

            if (media <= 6) {
                Console.WriteLine("Esta abaixo da média " + media);
            } else if (media >= 7) {
                Console.WriteLine("Esta acima da média " + media);
            }


        }
    }
}