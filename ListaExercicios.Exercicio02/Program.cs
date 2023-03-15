using System;

namespace ListaExercicios.Exercicio02
{         
    /*2. Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius*/
    
    
    class Program
    {
        static void Main(string[] args)

        {
            decimal temperaturaF, temperaturaC;
            

            Console.WriteLine("Informe o temperatura Fahrenheit que você quer converter em Calsius ");
            temperaturaF = Convert.ToDecimal(Console.ReadLine());

            temperaturaC = (((temperaturaF - 32) / 9) * 5);

           

            Console.WriteLine("O valor convertido para Celsius é:" + temperaturaC);
            
        }
    }
}
