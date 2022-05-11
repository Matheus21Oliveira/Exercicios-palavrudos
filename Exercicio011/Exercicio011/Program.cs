using System;

namespace Exercicio011 {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Qual o valor de A? ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor de B? ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor de C? ");
            int c = int.Parse(Console.ReadLine());

            double delta = 0;

            delta = (Math.Pow(b, 2)) - (4 * a * c);

            Console.WriteLine("O valor de delta é: " + delta);
        }
    }
}