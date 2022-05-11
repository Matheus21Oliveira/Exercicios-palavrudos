using System;

namespace Exercicio010 {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Qual a largura da parede?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura da parede?");
            double altura = double.Parse(Console.ReadLine());

            double area = 0;
            double pintura = 0;
            area = largura * altura;

            pintura = area / 2;

            Console.WriteLine("A área a ser pintada é: " + area);
            Console.WriteLine("Quantidade de tinta será usada é de: " + pintura);
        }
    }
}