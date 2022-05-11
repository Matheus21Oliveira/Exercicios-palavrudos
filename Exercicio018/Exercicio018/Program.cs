using System;

namespace Exercicio018 {
    class program {
        public static void Main(String[] args) {
            int idade;

            Console.Write("Qual a sua idade? ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18 ) {
                Console.WriteLine("voto obrigatório");
            } else if (idade >= 16 ) {
                Console.WriteLine("Voce pode votar, mas, não é obrigatório");
            } else {
                Console.WriteLine("Voce ainda nao tem idade para votar!");
            }
        }
    }
}