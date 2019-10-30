using System;
using System.Collections.Generic;

namespace EncontreOTelefone
{
    internal class Telefone
    {
        private Dictionary<string, string> tabelaLetras;
        
        public Telefone()
        {
            CriarTabelaLetras();
        }

        private void CriarTabelaLetras()
        {
            this.tabelaLetras = new Dictionary<string, string>
            {
                { "-", "-" },
                { "1", "1" },
                { "A", "2" },
                { "B", "2" },
                { "C", "2" },
                { "D", "3" },
                { "E", "3" },
                { "F", "3" },
                { "G", "4" },
                { "H", "4" },
                { "I", "4" },
                { "J", "5" },
                { "K", "5" },
                { "L", "5" },
                { "M", "6" },
                { "N", "6" },
                { "O", "6" },
                { "P", "7" },
                { "Q", "7" },
                { "R", "7" },
                { "S", "7" },
                { "T", "8" },
                { "U", "8" },
                { "V", "8" },
                { "W", "9" },
                { "X", "9" },
                { "Y", "9" },
                { "Z", "9" }
            };
        }

        internal string ConverteLetraParaNumero(string letra) => tabelaLetras.GetValueOrDefault(letra);

        internal string ConverteExpressaoParaNumeroDeTelefone(string expressao)
        {
            string numeroTelefone = string.Empty;

            for (int i = 0; i < expressao.Length; i++)
            {
                numeroTelefone += ConverteLetraParaNumero(expressao.Substring(i, 1));
            }

            return numeroTelefone;
        }
    }
}