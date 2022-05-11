using System;
using System.Globalization;

namespace Exercicio013 {
    class program {
        public static void Main(String[] args) {
            double antigo, novo;
            
            Console.WriteLine("Qual o salario do funcionario?");
            antigo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            novo = (antigo * 0.15) + antigo;

            Console.WriteLine("O novo salário vai ser de: R$" + novo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}