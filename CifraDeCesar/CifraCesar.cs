using System;

namespace CifraDeCesar
{
    internal class CifraCesar
    {
        private readonly int inicioTabelaAscii;
        private readonly int finalTabelaAscii;
        private readonly int deslocamento;

        public CifraCesar(int deslocamento)
        {
            this.inicioTabelaAscii = 32;
            this.finalTabelaAscii = 126;
            this.deslocamento = deslocamento;
        }

        internal char Cifrar(char input)
        {
            int valorAscii = Char.ToLower(input);

            int valorCifradoAscii = valorAscii + deslocamento;

            if (valorCifradoAscii > finalTabelaAscii)
                valorCifradoAscii = (valorCifradoAscii - finalTabelaAscii) + (inicioTabelaAscii - 1); // -1 para incluir o espaço.

            return (char)valorCifradoAscii;
        }

        internal char Decifrar(char input)
        {
            int valorAscii = Char.ToLower(input);

            int valorCifradoAscii = valorAscii - deslocamento;

            if (valorCifradoAscii < inicioTabelaAscii)
                valorCifradoAscii = (finalTabelaAscii + 1) - (inicioTabelaAscii - valorCifradoAscii); // +1 para incluir o ~.

            return (char)valorCifradoAscii;
        }

        internal string Cifrar(string frase)
        {
            var charArray = frase.ToCharArray();
            var charArrayCifrado = new Char[frase.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                charArrayCifrado[i] = this.Cifrar(charArray[i]);
            }

            return new String(charArrayCifrado);
        }

        internal string Decifrar(string frase)
        {
            var charArray = frase.ToCharArray();
            var charArrayDecifrado = new Char[frase.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                charArrayDecifrado[i] = this.Decifrar(charArray[i]);
            }

            return new String(charArrayDecifrado);
        }
    }
}