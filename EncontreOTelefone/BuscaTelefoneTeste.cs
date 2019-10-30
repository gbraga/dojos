using System;
using Xunit;
using ExpectedObjects;

namespace EncontreOTelefone
{
    public class BuscaTelefoneTeste
    {
        [Fact]
        public void Deve_criar_o_telefone()
        {
            // Arrange
            var telefoneEsperado = new Telefone().ToExpectedObject();

            // Act
            var telefoneAtual = new Telefone();

            // Assert
            telefoneEsperado.ShouldEqual(telefoneAtual);
        }

        [Theory]
        [InlineData("-", "-")]
        [InlineData("1", "1")]
        [InlineData("A", "2")]
        [InlineData("B", "2")]
        [InlineData("C", "2")]
        [InlineData("D", "3")]
        [InlineData("E", "3")]
        [InlineData("F", "3")]
        [InlineData("G", "4")]
        [InlineData("H", "4")]
        [InlineData("I", "4")]
        [InlineData("J", "5")]
        [InlineData("K", "5")]
        [InlineData("L", "5")]
        [InlineData("M", "6")]
        [InlineData("N", "6")]
        [InlineData("O", "6")]
        [InlineData("P", "7")]
        [InlineData("Q", "7")]
        [InlineData("R", "7")]
        [InlineData("S", "7")]
        [InlineData("T", "8")]
        [InlineData("U", "8")]
        [InlineData("V", "8")]
        [InlineData("W", "9")]
        [InlineData("X", "9")]
        [InlineData("Y", "9")]
        [InlineData("Z", "9")]
        public void Deve_retornar_numero_correspondente_a_letra(string letra, string numeroEsperado)
        {
            // Arrange
            var telefone = new Telefone();

            // Act
            string numeroAtual = telefone.ConverteLetraParaNumero(letra);

            // Assert
            Assert.Equal(numeroEsperado, numeroAtual);
        }

        [Theory]
        [InlineData("1-HOME-SWEET-HOME", "1-4663-79338-4663")]
        [InlineData("MY-MISERABLE-JOB", "69-647372253-562")]
        public void Deve_converter_expressao_para_numero_de_telefone(string expressao, string telefoneEsperado)
        {
            // Arrange
            var telefone = new Telefone();

            // Act
            string telefoneAtual = telefone.ConverteExpressaoParaNumeroDeTelefone(expressao);

            // Assert
            Assert.Equal(telefoneEsperado, telefoneAtual);
        }
    }
}
