using System;

namespace ListaExercicios.Exercicio024
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int n = 1; n <= 500; n++)

            {

                if (n % 2 != 0 && n % 3 == 0)

                {

                    soma += n;

                }

            }

            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}
