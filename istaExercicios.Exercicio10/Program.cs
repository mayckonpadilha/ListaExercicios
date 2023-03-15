using System;

namespace istaExercicios.Exercicio010
{
    class Program
    {
        static void Main(string[] args)

        {
            decimal nota1, nota2, peso1, peso2, mediaPonderada;
            
            
            Console.WriteLine("informe a nota da primeira prova;");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe a nota da segunda prova;");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe o peso da primeira prova;");
            peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe a peso da segunda prova;");
            peso2 = Convert.ToDecimal(Console.ReadLine());

            mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);


            Console.WriteLine("Há media ponderada entre as provas é de: " + mediaPonderada);

        }
    }
}
