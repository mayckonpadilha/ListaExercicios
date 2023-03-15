using System;

namespace ListaExercicios.Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {

            double volume, raio;

            Console.WriteLine("Informe o raio do cilindro");
            raio = Convert.ToDouble(Console.ReadLine());
            
                volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine("O volume da esfera é: " + volume);
        }
    }
}
