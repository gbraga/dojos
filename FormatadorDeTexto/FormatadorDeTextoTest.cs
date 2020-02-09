using System;
using Xunit;

namespace FormatadorDeTexto
{
    public class FormatadorDeTextoTest
    {
        [Fact]
        public void FimDeLinha_deve_retonar_texto_com_quebra_de_linha()
        {
            // Arrange
            int colunas = 20;
            var texto = "O rato roeu a roupa do rei de roma, e o rei de roma mandou soltar os tigres tristes para capturá-lo.";
            var textoEsperado = "O rato roeu a roupa\ndo rei de roma, e o\nrei de roma mandou\nsoltar os tigres\ntristes para\ncapturá-lo.";
            var formatadorDeTexto = new FormatadorDeTexto(texto, colunas);

            // Act
            var textoAtual = formatadorDeTexto.Formatar();

            // Assert
            Assert.Equal(textoEsperado, textoAtual);
        }
    }
}
