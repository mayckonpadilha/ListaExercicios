using System;

namespace ListaExercicios.Exercicio01
{         /*1. Crie um programa para calcular o volume de uma caixa retangular*/
    class Program
    { 
        static void Main(string[] args)
        {
            int largura;
            int complimento;
            int altura;
            int volume;

            Console.WriteLine("Informe a largura");
            largura = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Informe o complimento");
            complimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a altura");
           altura = Convert.ToInt32(Console.ReadLine());

            volume = largura * complimento * altura;


            Console.WriteLine("o volume da caixa retangular é:" + volume);


        }
    }
}
