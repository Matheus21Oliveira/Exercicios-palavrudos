/*Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) 
e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.*/

using System;

namespace Exercicio009 {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Quanto de dinheiro você tem na carteira? ");
            double reais = double.Parse(Console.ReadLine());

            double dolar = 0;

            dolar = reais * 3.45;

            Console.WriteLine("Voce pode comprar: US$" + dolar);
        }
    }
}