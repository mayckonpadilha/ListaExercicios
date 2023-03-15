using System;

namespace ListaExercicios.Exercicio03

    //3. Crie um programa para calcular o volume de um Cilindro
{
    class Program
    {     
        static void Main(string[] args)

        {
            double altura, raio, volume ;

            Console.WriteLine("Informe a altura do cilindro: ");

                altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o raio do cilindro: ");

                raio = Convert.ToDouble(Console.ReadLine());


              volume = Math.PI * Math.Pow(raio, 2) * altura;


            Console.WriteLine("O valume do cilindro é: " + volume);

        }
    }
}
