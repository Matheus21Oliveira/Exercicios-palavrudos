using System;

namespace Exercicio022 {
    class Program {
        public static void Main(String[] args) {
            int ano, alistamento, idade;

            Console.WriteLine("Em que ano você nasceu? ");
            ano = int.Parse(Console.ReadLine());

            idade = 2022 - ano;
            alistamento = 18 - idade;

            if (idade < 18) {                
                Console.WriteLine("faltara " + alistamento + " anos");
            } else if (idade == 18) {
                Console.WriteLine("esta na idade");
            } else {
                Console.WriteLine("passou " + alistamento + " anos");
            }
        }
    }
}