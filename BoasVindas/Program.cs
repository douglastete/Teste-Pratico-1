using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoasVindas
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

            string boasVindas = "Olá, " + nomeUsuario + "! Seja muito bem-vindo!";
            Console.WriteLine(boasVindas);
            Console.ReadKey();
        }
    }
}
