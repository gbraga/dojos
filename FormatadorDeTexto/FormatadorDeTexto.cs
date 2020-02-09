using System;
using System.Collections.Generic;
using System.Text;

namespace FormatadorDeTexto
{
    class FormatadorDeTexto
    {
        public string Texto { get; private set; }
        public int Colunas { get; private set; }

        public FormatadorDeTexto(string texto, int colunas)
        {
            this.Texto = texto;
            this.Colunas = colunas;
        }

        internal string Formatar()
        {
            var palavras = Texto.Split(" ");
            string textoFormatado = string.Empty;
            int contadadorColunas = 0;
            bool primeiraPalavra = true;

            foreach (var palavra in palavras)
            {
                if (primeiraPalavra)
                {
                    textoFormatado += palavra;
                    contadadorColunas = palavra.Length;
                    primeiraPalavra = false;
                    continue;
                }

                contadadorColunas += palavra.Length + 1;

                if (contadadorColunas <= Colunas)
                {
                    textoFormatado += " " + palavra;
                }
                else 
                {
                    textoFormatado += "\n" + palavra;
                    contadadorColunas = palavra.Length;
                }
            }

            return textoFormatado;
        }
    }
}
