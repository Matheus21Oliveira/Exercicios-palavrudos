using System;

namespace Exercicio028 {
    class Program {
        public static void Main(String[] args) {
            double largura, compriemnto, terreno;

            Console.WriteLine("qual a largura?");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("qual é o comprimento? ");
            compriemnto = double.Parse(Console.ReadLine());

            terreno = largura * compriemnto;

            if (terreno < 100) {
                Console.WriteLine("esse terreno tem " + terreno + "m² e é um terreno popular");
            } else if (terreno <= 500) {
                Console.WriteLine("esse terreno tem " + terreno + "m² e é um terreno master");
            } else {
                Console.WriteLine("este terreno tem " + terreno + "m² e é um terreno vip");
            }
        }
    }
}