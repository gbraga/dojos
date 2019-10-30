using System;
using System.Collections.Generic;
using System.Text;

namespace EncontreOTelefone
{
    public class Program
    {
        public static void Main()
        {
            while(true)
            {
                string expressao = Console.ReadLine();

                if (expressao.Equals("0")) break;

                Telefone telefone = new Telefone();

                string telefoneExpressao = telefone.ConverteExpressaoParaNumeroDeTelefone(expressao);

                Console.WriteLine($"O telefone correspondente a sua expressão é: {telefoneExpressao}.");
            }
        }
    }
}
