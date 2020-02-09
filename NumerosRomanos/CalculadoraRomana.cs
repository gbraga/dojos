using System;
using System.Collections.Generic;

namespace NumerosRomanos
{
    internal class CalculadoraRomana
    {
        protected IDictionary<int, string> Dicionario { get; private set; }

        public CalculadoraRomana()
        {
            this.Dicionario = new Dictionary<int, string>()
            {
                { 1, "I" },
                { 5, "V" },
                { 10, "X" },
                { 50, "L" },
                { 100, "C" },
                { 500, "D" },
                { 1000, "M" }
            };
        }

        internal string ObterNumeralRomano(int numero) 
        {
            string letra;

            this.Dicionario.TryGetValue(numero, out letra);

            if (string.IsNullOrEmpty(letra))
            {
                letra = ObterNumeralRomanoComposto(numero);
            }

            return letra;
        }

        internal string ObterNumeralRomanoComposto(int numero)
        {
            throw new NotImplementedException();
        }

        internal string Somar(int fator1, int fator2)
        {
            var numeral1 = this.ObterNumeralRomano(fator1);
            var numeral2 = this.ObterNumeralRomano(fator2);
            string resultado = string.Empty;

            if (fator1 > fator2)
            {
                resultado = string.Concat(numeral1, numeral2);
            }
            else
            {
                resultado = string.Concat(numeral2, numeral1);
            }

            return resultado;
        }
    }
}