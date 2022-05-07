using System;

namespace Exercicio008 {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Qual é a medida em metros? ");
            double metros = double.Parse(Console.ReadLine());

            double decametro = metros / 10;

            double hectometro = decametro / 10;

            double quilometro = hectometro / 10;

            double decimetro = metros * 10;

            double centimetro = decimetro * 10;

            double milimetro = centimetro * 10;

            Console.WriteLine("As medidas de distancia em metros é de");
            Console.WriteLine("Km: " + quilometro);
            Console.WriteLine("Hm: " + hectometro);
            Console.WriteLine("Dam: " + decametro);
            Console.WriteLine("Dm: " + decimetro);
            Console.WriteLine("Cm: " + centimetro);
            Console.WriteLine("Mm: " + milimetro);
        }
    }
}