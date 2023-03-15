using System;

namespace ListaExercicios.Exercicio011
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, aux, div=0;

            Console.WriteLine("Informe o numero para verificar se ele é primo:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (aux = 1; aux<=numero; aux++)
            {
                if (numero / aux == 0)
                    div ++;
            }

            if (div == 2)
            {
                Console.WriteLine("O numero é primo");
            }
            else
            {
                Console.WriteLine("O numero não é primo");
            }
        }
    }
}
