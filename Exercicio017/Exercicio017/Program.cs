using System;
using System.Globalization;

namespace Exercicio017 {
    class program {
        public static void Main(String[] args) {
            double velocidade, multa;
            
            Console.Write("Qual a velocidade do carro? ");
            velocidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (velocidade > 80) {
                multa = (velocidade / 80) * 5;                
                Console.WriteLine("Você passou da velocidade permitida e receberá: R$" + multa.ToString("F2", CultureInfo.InvariantCulture) + " de multa!");
            } else {
                Console.WriteLine("Voce está na velocidade permitida");
            } 
        }
    }
}