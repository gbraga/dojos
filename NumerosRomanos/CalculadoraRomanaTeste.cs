using FluentAssertions;
using System;
using Xunit;

namespace NumerosRomanos
{
    public class CalculadoraRomanaTeste
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        public void CalculadoraRomana_deve_retornar_letra_romana_correspondente_com_algarismo_arabico(int algarismo, string letraEsperada)
        {
            // Arrange
            var calculadora = new CalculadoraRomana();

            // Act
            var letraAtual = calculadora.ObterNumeralRomano(algarismo);

            // Assert
            letraAtual.Should().Be(letraEsperada);
        }

        [Theory]
        [InlineData(1, 1, "II")]
        [InlineData(1, 2, "III")]
        public void CalculadoraRomano_deve_somar_dois_algarismos(int algarismo1, int algarismo2, string valorEsperado)
        {
            // Arrange
            var calculadora = new CalculadoraRomana();

            // Act
            string valorAtual = calculadora.Somar(algarismo1, algarismo2);

            // Assert
            valorAtual.Should().Be(valorEsperado);

        }
        ////[Fact]
        ////public void CalculadoraRomana_deve_lancar_excecao_se_numeral_romano_for_invalido()
        ////{
        ////    // Arrange
        ////    var calculadora = new CalculadoraRomana();
        ////    var numero = 3;

        ////    // Act
        ////    Action act = () => calculadora.ObterNumeralRomanoComposto(numero);

        ////    // Assert
        ////    act.Should().Throw<FormatException>();
        ////}
    }
}
