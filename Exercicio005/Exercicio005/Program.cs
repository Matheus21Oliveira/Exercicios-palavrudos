using System;

namespace Exercicio005 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual a primeira nota?");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a segunda nota?");
            double nota2 = double.Parse(Console.ReadLine());

            double media = 0;

            media = (nota1 + nota2) / 2;

            
            Console.WriteLine("A média entre " + nota1 + " e " + nota2 + " é de: " + media);
        }
    }
}