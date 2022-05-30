using System;

namespace Exercicio029 {
    class Program {
        public static void Main(String[] args) {
            String nome;
            double salarioAtual, novoSalario;
            int tempo;
            Console.WriteLine("Qual o nome do funcionario? ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual salario atual de " + nome + "?");
            salarioAtual = Double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto tempo ele trabalhou na empresa? ");
            tempo = int.Parse(Console.ReadLine());

            if (tempo <= 3) {
                novoSalario = salarioAtual + (salarioAtual * 0.03);
            }
            else if (tempo <= 10) {
                novoSalario = salarioAtual + (salarioAtual * 0.125);
            }
            else {
                novoSalario = salarioAtual + (salarioAtual * 0.020);
            }

            Console.WriteLine("O(a) funcionário(a) " + nome + " que trabalha á " + tempo + " anos receberá R$", novoSalario, " reais");
        }
    }
}