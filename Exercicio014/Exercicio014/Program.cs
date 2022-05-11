using System;

namespace Exercicio014 {
    class program {
        public static void Main(String[] args) {
            double km, distancia, serviço;
            int dia, aluguel;
            
            Console.Write("qual a quantidade de km percorridos? ");
            distancia = double.Parse(Console.ReadLine());

            Console.Write("Por quantos dias o carro foi alugado? ");
            dia = int.Parse(Console.ReadLine());

            km = distancia * 0.20;

            aluguel = dia * 90;

            serviço = km * aluguel;

            Console.WriteLine("O serviço da locação vai sair por: R$" + serviço);
        }
    }
}