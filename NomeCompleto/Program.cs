using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeCompleto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome:");
            string nomeUsuario = Console.ReadLine();
            if (nomeUsuario.Equals(string.Empty))
            {
                Console.WriteLine("É necessário informar o nome!");
                return;
            }

            Console.WriteLine("Informe seu sobrenome:");
            string sobrenomeUsuario = Console.ReadLine();
            if (sobrenomeUsuario.Equals(string.Empty))
            {
                Console.WriteLine("É necessário informar o sobrenome!");
                return;
            }

            StringBuilder boasVindas = new StringBuilder();
            boasVindas.Append("Olá, ");
            boasVindas.Append(nomeUsuario);
            boasVindas.Append(" ");
            boasVindas.Append(sobrenomeUsuario);
            boasVindas.Append("! Seja muito bem-vindo!");

            Console.WriteLine(boasVindas.ToString());
            Console.ReadKey();
        }
    }
}
