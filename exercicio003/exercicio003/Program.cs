using System;
using System.Globalization;

namespace exercicio003;
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual o nome do funcionario(a)? ");
            String nome = Console.ReadLine();

            Console.WriteLine("Qual é o salário de " + nome + "?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O salario de " + nome + " é de R$" + salario + ",00");
    }
}