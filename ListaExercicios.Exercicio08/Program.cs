using System;

namespace ListaExercicios.Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, raio, volume;

            Console.WriteLine("Informe a altura da lata de Oleo: ");

            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o raio da lata de Oleo: ");

            raio = Convert.ToDouble(Console.ReadLine());


            volume = Math.PI * Math.Pow(raio,2) * altura;

            Console.WriteLine("O valume da lata de oléo e de:" + volume);
        }
    }
}
