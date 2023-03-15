using System;

namespace ListaExercicios.Exercicio015
{
    class Program
    {
        static void Main(string[] args)
        {
            Double temperaturaC, temperaturaF;


            Console.WriteLine("Informe o temperatura Calsius que você quer converter em Fahrenheit");
            temperaturaC = Convert.ToDouble(Console.ReadLine());

            temperaturaF = temperaturaC * 1.8 + 32;

            Console.WriteLine("O valor convertido para Fahrenheit é:" + temperaturaF);
        }
    }
}
