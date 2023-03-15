using System;

namespace ListaExercicios.Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero1, numero2, numero3, mediaHarmonica;

            Console.WriteLine("Informe o valor da primeira nota:" );
            numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o valor da segunda nota:");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o valor da terceira nota:");
            numero3 = Convert.ToDecimal(Console.ReadLine());

            mediaHarmonica = 3 / (1 / (numero1 + 1) / (numero2 + 1) / numero3);


            Console.WriteLine("A media entre as notas harmonicas é de: " + mediaHarmonica);




        }
    }
}
