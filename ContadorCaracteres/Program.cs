using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto para ser contadas as palavras");
            string texto = Console.ReadLine();

            int i = 0;
            int quantidadeCaracteres = 0;
            int quantidadeCaracteresEspacos = 0;
            while (i < texto.Length)
            {
                quantidadeCaracteresEspacos++;
                char letra = texto[i];
                i++;
                if (letra == ' ')
                {
                    continue;
                }
                quantidadeCaracteres++;
            }
            Console.WriteLine("No seu texto há " + quantidadeCaracteres + " caracteres");
            if (quantidadeCaracteres != quantidadeCaracteresEspacos)
            {
                Console.WriteLine("No seu texto há " + quantidadeCaracteresEspacos + " caracteres (considerando espaços)");
            }
            Console.ReadKey();
        }
    }
}
