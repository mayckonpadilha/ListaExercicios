using System;

namespace ListaExercicios.Exercicio04
{
    //     4. Crie um programa para calcular o consumo de combustível por Km.Deverá ser informado a quilometragem
    //       Inicial e Final do Percurso do Veículo.Deverá ser informado o Consumo de Combustível
    class Program
    {
        static void Main(string[] args)
        {
            double kmInicial, kmFinal, distancia, combustivelUsado, valorPorKm;

            Console.WriteLine("Informe a quilometragem inicial: ");
            kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem final: ");
            kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de combustivel usado: ");
            combustivelUsado = Convert.ToDouble(Console.ReadLine());

            distancia = kmFinal - kmInicial;

            valorPorKm = distancia / combustivelUsado;


            Console.WriteLine("O valor de combustivel gastos por quilometros rodados é de:" + valorPorKm);






        }
    }
}
