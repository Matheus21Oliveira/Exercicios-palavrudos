using System;

namespace Exercicio024 {
    class Program {
        public static void Main(String[] args) {
            double km, preco;

            Console.WriteLine("Qual a distancia?");
            km = double.Parse(Console.ReadLine());  

            if (km == 200) {
                preco = 0.50 * km;
                Console.WriteLine("A passagem será de: " + preco)
            } else {
                preco = 0.45 * km;
                Console.WriteLine("A passagem será de: " + preco);
            }
        }
    }
}