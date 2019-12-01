using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace CifraDeCesar
{
    public class AlgoritimoCifraCesarTeste
    {
        private static readonly int _deslocamento10 = 10;
        private static readonly int _deslocamento15 = 15;
        
        public AlgoritimoCifraCesarTeste() { }

        [Theory]
        [MemberData(nameof(DataCifras10))]
        [MemberData(nameof(DataCifras15))]
        public void Deve_retornar_letra_cifrada(char input, char letraEsperada, int deslocamento)
        {
            // Arrange
            var cifrador = new CifraCesar(deslocamento);

            // Act
            char letraAtual = cifrador.Cifrar(input);

            // Assert
            letraAtual.Should().Be(letraEsperada);
        }

        [Theory]
        [MemberData(nameof(DataDecifras10))]
        [MemberData(nameof(DataDecifras15))]
        public void Deve_retornar_letra_decifrada(char input, char letraEsperada, int deslocamento)
        {
            // Arrange
            var cifrador = new CifraCesar(deslocamento);

            // Act
            char letraAtual = cifrador.Decifrar(input);

            // Assert
            letraAtual.Should().Be(letraEsperada);
        }

        [Fact]
        public void Deve_retornar_frase_cifrada()
        {
            // Arrange
            string frase = "E ninguem cala esse nosso amor!";
            string fraseEsperada = "o*xsxq ow*mkvk*o}}o*xy}}y*kwy|+";
            var cifrador = new CifraCesar(10);

            // Act
            string fraseAtual = cifrador.Cifrar(frase);

            // Assert
            fraseAtual.Should().Be(fraseEsperada);
        }


        [Fact]
        public void Deve_retornar_frase_decifrada()
        {
            // Arrange
            string frase = "o*xsxq ow*mkvk*o}}o*xy}}y*kwy|+";
            string fraseEsperada = "E ninguem cala esse nosso amor!";
            var cifrador = new CifraCesar(10);

            // Act
            string fraseAtual = cifrador.Decifrar(frase);

            // Assert
            fraseAtual.Should().Be(fraseEsperada.ToLower());
        }

        public static IEnumerable<object[]> DataCifras10 =>
            new List<object[]>
            {
                new object[] { 'A', 'k', _deslocamento10 },
                new object[] { 'a', 'k', _deslocamento10 },
                new object[] { 'T', '~', _deslocamento10 },
                new object[] { 'v', '!', _deslocamento10 },
                new object[] { 'z', '%', _deslocamento10 },
            };

        public static IEnumerable<object[]> DataCifras15 =>
            new List<object[]>
            {
                new object[] { 'A', 'p', _deslocamento15 },
                new object[] { 'a', 'p', _deslocamento15 },
                new object[] { 'T', '$', _deslocamento15 },
                new object[] { 'v', '&', _deslocamento15 },
                new object[] { 'z', '*', _deslocamento15 },
            };

        public static IEnumerable<object[]> DataDecifras10 =>
            new List<object[]>
            {
                new object[] { 'k', 'a', _deslocamento10 },
                new object[] { '~', 't', _deslocamento10 },
                new object[] { '!', 'v', _deslocamento10 },
                new object[] { '%', 'z', _deslocamento10 },
            };

        public static IEnumerable<object[]> DataDecifras15 =>
            new List<object[]>
            {
                new object[] { 'p', 'a', _deslocamento15 },
                new object[] { '$', 't', _deslocamento15 },
                new object[] { '&', 'v', _deslocamento15 },
                new object[] { '*', 'z', _deslocamento15 },
            };
    }
}
