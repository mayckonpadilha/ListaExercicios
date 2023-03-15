using System;

namespace ListaExercicios.Exercicio019
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                decimal peso, altura, imc;
                Console.WriteLine("Digite seu peso em kg:");

                peso = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite sua altura em metros:");

                altura = Convert.ToDecimal(Console.ReadLine());

                imc = peso / (altura * altura);
                Console.WriteLine("Seu IMC é: " + imc);


                if (imc < 18.5m)

                {

                    Console.WriteLine("Abaixo do peso");

                }

                else if (imc < 25)

                {

                    Console.WriteLine("Peso normal");

                }
                else if (imc < 30)

                {

                    Console.WriteLine("Acima do peso");

                }

                else

                {

                    Console.WriteLine("Obeso");
                }
            }

        }
    }
}