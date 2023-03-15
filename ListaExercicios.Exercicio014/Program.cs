using System;

namespace ListaExercicios.Exercicio014
{
    class Program
    {
        static void Main(string[] args)
        {
          int idade, diasVividos;
            
            Console.WriteLine("Informe sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            diasVividos = idade * 365;

            Console.WriteLine("Você viveu" + diasVividos + "dias");
        }
    }
}
