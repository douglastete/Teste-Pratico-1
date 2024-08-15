using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaPlaca
{
    internal class Program
    {
        const int TAMANHO_PLACA = 7;
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a placa a ser verificada");
            string placa = Console.ReadLine();
            string resultado = PlacaValida(placa) ? "Verdadeiro" : "Falso";
            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        static bool PlacaValida(string placa)
        {
            if (placa.Length != TAMANHO_PLACA)
            {
                return false;
            }

            bool tresPrimeirosLetras = true;
            bool quatroUltimosNumeros = true;
            for (int i = 0; i < placa.Length; i++)
            {
                char caracter = placa[i];
                if (i <= 2)
                {
                    if (!char.IsLetter(caracter))
                    {
                        tresPrimeirosLetras = false;
                        break;
                    }
                }
                else if (i > 2)
                {
                    if (!char.IsNumber(caracter))
                    {
                        quatroUltimosNumeros = false;
                        break;
                    }
                }
            }

            return (tresPrimeirosLetras && quatroUltimosNumeros);
        }
    }
}
