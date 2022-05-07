using System;

namespace Exercicio007 {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Digite um numero real: ");
            double numero = double.Parse(Console.ReadLine());

            double dobro = numero * 2;

            double terca = numero / 3;

            Console.WriteLine("O dobro do numero: " + numero + " é igual á: " + dobro);
            Console.WriteLine("A terça parte de: " + numero + " é igual á: " + terca);
        }
    }
}