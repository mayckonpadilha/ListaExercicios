using System;

namespace ListaExercicios.Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorSalario, valorVendido, valorComissionado, porcetagem, valorSalarioFinal;

            Console.WriteLine("Informe abaixo o valor do seu Salario em a comissão: ");
            valorSalario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Infomre o valor total da suas vendas este mês:");
            valorVendido = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Informe sobre qual porcetegem você recebe a comissão: ");
            porcetagem = Convert.ToDouble(Console.ReadLine());


            valorComissionado = porcetagem / 100 * valorVendido;

            valorSalarioFinal = valorComissionado + valorSalario;

            Console.WriteLine("Seu Salario junto com a comissão será de:" + valorSalarioFinal);


        }
    }
}
