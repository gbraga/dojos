using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using FluentAssertions;

namespace Anagramas
{
    public class AnagramaTeste
    {
        [Fact]
        public void Deve_retornar_palavra_com_mesmo_tamanho()
        {
            // Arrange
            string palavraBase = "BOLA";
            int tamanhoEsperado = palavraBase.Length;
            Anagrama anagrama = new Anagrama();

            // Act
            string palavraAtual = anagrama.DevolveAnagramas(palavraBase).First();

            // Assert
            Assert.Equal(tamanhoEsperado, palavraAtual.Length);
        }

        [Fact]
        public void Deve_retornar_quantidade_de_anagramas_para_uma_palavra()
        {
            // Arrange
            string palavraBase = "Gabriel";
            int quantidadeEsperada = 7 * 6 * 5 * 4 * 3 * 2 * 1;
            Anagrama anagrama = new Anagrama();

            // Act
            int quantidadeAtual = anagrama.DevolveQuantidade(palavraBase);

            // Assert
            Assert.Equal(quantidadeEsperada, quantidadeAtual);
        }

        [Fact]
        public void Deve_retornar_anagramas_validos()
        {
            // Arange
            string palavraBase = "Gabriel";
            string anagramaEsperado = "Gabriel";
            Anagrama anagrama = new Anagrama();

            // Act
            var anagramas = anagrama.DevolveAnagramas(palavraBase).AsEnumerable<string>();

            // Assert
            anagramas.Should().Contain(anagramaEsperado);
        }
    }
}
