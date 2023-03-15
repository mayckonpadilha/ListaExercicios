using System;

namespace ListaExercicios.Exercicio021
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, resultado;

            Console.WriteLine("Digite o valor de A: ");

            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");

            B = Convert.ToInt32(Console.ReadLine());

            if (A == B)

            {

                resultado = A + B;

            }

            else

            {

                resultado = A * B;

            }

            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}
