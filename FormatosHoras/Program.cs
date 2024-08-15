using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatosDataHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataHora = DateTime.Now;
            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(dataHora.ToString("dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm:ss", cultura));
            Console.WriteLine(dataHora.ToString("dd/MM/yyyy", cultura));
            Console.WriteLine(dataHora.ToString("HH:mm:ss", cultura));
            Console.WriteLine(dataHora.ToString("dd/MMMM/yyyy", cultura));

            Console.ReadKey();
        }
    }
}
