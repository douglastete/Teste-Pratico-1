using System;
using System.Linq;

namespace CauculosBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeiroNumero = 0;
            double segundoNumero = 0;

            Console.WriteLine("Informe o primeiro número:");
            Double.TryParse(Console.ReadLine(), out primeiroNumero);

            Console.WriteLine("Informe o segundo número:");
            Double.TryParse(Console.ReadLine(), out segundoNumero);

            Console.WriteLine("Resultado da soma: " + (primeiroNumero + segundoNumero));
            Console.WriteLine("Resultado da subtração: " + (primeiroNumero - segundoNumero));
            Console.WriteLine("Resultado da multiplicação: " + (primeiroNumero * segundoNumero));

            if (segundoNumero == 0)
            {
                Console.WriteLine("Não é possível efetuar a divisão. O segundo número é zero!");
            }
            else
            {
                Console.WriteLine("Resultado da divisão: " + (primeiroNumero / segundoNumero));
            }

            var listaNumeros = new double[] {primeiroNumero, segundoNumero};
            double media = Enumerable.Average(listaNumeros.AsEnumerable());
            Console.WriteLine("Resultado da média: " + media);

            Console.ReadKey();
        }
    }
}
