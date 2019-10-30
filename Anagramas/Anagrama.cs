using System.Collections.Generic;

namespace Anagramas
{
    internal class Anagrama
    {
        public Anagrama() { }

        internal List<string> DevolveAnagramas(string palavraBase)
        {
            List<string> anagrama = new List<string>();
            int pivo;
            int ultimoIndice = palavraBase.Length - 1;
            int ponteiro = ultimoIndice;
            char[] palavraTemp = palavraBase.ToCharArray();

            for (int i = 0; i < palavraBase.Length; i++)
            {
                // anagrama.Add(ConverteCharrArrayParaString(palavraTemp));
                pivo = 0;

                for (int j = 1; j < palavraBase.Length; j++)
                {
                    if (ponteiro - 1 == pivo)
                    {
                        // Reinicia passo de troca
                        pivo++;
                        ponteiro = ultimoIndice;
                    }
                    else
                    {
                        // Troca letra com a anterior
                        char temp = palavraTemp[ponteiro - 1];
                        palavraTemp[ponteiro - 1] = palavraTemp[ponteiro];
                        palavraTemp[ponteiro] = temp;

                        ponteiro--;
                    }

                    anagrama.Add(ConverteCharrArrayParaString(palavraTemp));
                }
            }

            return anagrama;
        }

        internal int DevolveQuantidade(string palavraBase)
        {
            return CalculaQuantidadeAnagramas(palavraBase.Length);
        }

        private int CalculaQuantidadeAnagramas(int tamanho)
        {
            if (tamanho == 1) return 1;

            return tamanho * CalculaQuantidadeAnagramas(tamanho - 1);
        }

        private string ConverteCharrArrayParaString(char[] charArray)
        {
            string text = string.Empty;

            for (int i = 0; i < charArray.Length; i++)
            {
                text += charArray[i];
            }

            return text;
        }
    }
}