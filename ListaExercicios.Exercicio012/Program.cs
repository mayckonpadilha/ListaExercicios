using System;

namespace ListaExercicios.Exercicio012
{
    class Program
    {
        static void Main(string[] args)
        {

            double comprimento, largura, areaTotal;

            Console.WriteLine("Informe o complimento do terreno: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Infome a largura do terreno: ");
            largura = Convert.ToDouble(Console.ReadLine());

            areaTotal = comprimento * largura;


            Console.WriteLine("O terreno possui" + areaTotal + "metros quadrados");

        }
    }
}
