﻿using System;

namespace ListaExercicios.Exercicio020
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.Write("Digite um número: ");

                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)

                {

                    Console.WriteLine("O número é par.");

                }

                else

                {

                    Console.WriteLine("O número é ímpar.");

                }

            }
        }
    }
}
