using System;

namespace ListaExercicios.Exercicio013
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantidadePaes, quantidadeBroa, totalValor, valorPopanca;

            Console.WriteLine("Informe a quantidade de pãoes vendido: ");
            quantidadePaes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de Broas vendida: ");
            quantidadeBroa = Convert.ToDouble(Console.ReadLine());


            totalValor = (quantidadePaes * 0.12) + (quantidadeBroa * 1.50);
            valorPopanca = 10 / 100 * totalValor;


            Console.WriteLine("O valor que deve ser depositado na poupança é de: " + valorPopanca);

        }
    }
}
