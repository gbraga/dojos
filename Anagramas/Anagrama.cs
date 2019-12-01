using System.Collections.Generic;

namespace Anagramas
{
    internal class Anagrama
    {
        public Anagrama() { }

        internal List<string> DevolveAnagramas(string palavraBase)
        {
            List<string> anagrama = new List<string>();
            int pivo, anterior;
            int ultimoIndice = palavraBase.Length - 1;
            int ponteiro = ultimoIndice;
            char[] palavraTemp = palavraBase.ToCharArray();
            string palavraChave;

            for (int i = 0; i < palavraBase.Length; i++)
            {
                pivo = 0;
                palavraChave = ConverteCharArrayParaString(palavraTemp);
                anagrama.Add(ConverteCharArrayParaString(palavraTemp));

                int j = 0;
                do
                {
                    anterior = ponteiro - 1;

                    if (anterior == pivo)
                    {
                        // Reinicia passo de troca
                        j++;
                        ponteiro = ultimoIndice;
                    }
                    else
                    {
                        // Troca letra com a anterior
                        TrocaLetras(palavraTemp, anterior, ponteiro);

                        ponteiro--;

                        if (palavraChave.Equals(ConverteCharArrayParaString(palavraTemp)))
                        {
                            TrocaLetras(palavraTemp, 0, i + 1);

                            break;
                        }

                        anagrama.Add(ConverteCharArrayParaString(palavraTemp));
                    } 
                } while (j < palavraBase.Length);
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

        private void TrocaLetras(char[] palavra, int indiceLetra1, int indiceLetra2)
        {
            if (indiceLetra2 < palavra.Length)
            {
                char temp = palavra[indiceLetra1];
                palavra[indiceLetra1] = palavra[indiceLetra2];
                palavra[indiceLetra2] = temp;
            }
        }

        private string ConverteCharArrayParaString(char[] charArray)
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