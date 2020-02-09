using ExpectedObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace MundoPequeno
{
    public class MapaAmigosTest
    {
        [Fact]
        public void AdicionarAmigo_deve_adicionar_amigo_na_lista_de_amizades()
        {
            // Arrange
            var coordenadas = new Mock<Coordenadas>().Object;
            
            var posicaoAmigo = new Coordenadas(45, 50);
            var amigo = new Amigo(posicaoAmigo);
            var mapa = new MapaAmigos(coordenadas);

            var mapaEsperado = new MapaAmigos(
                coordenadas,
                new List<Amigo>
                {
                    new Amigo(posicaoAmigo)
                }).ToExpectedObject();

            // Act
            mapa.AdicionarAmigo(amigo);

            // Assert
            mapaEsperado.ShouldEqual(mapa);
        }

        [Fact]
        public void ObterPosicaoAtual_deve_retornar_posicao_atual_do_usuario()
        {
            // Arrange
            var coordenadas = new Coordenadas(50, 50);
            var mapa = new MapaAmigos(coordenadas);
            var posicaoEsperada = new Coordenadas(50, 50);

            // Act
            Coordenadas posicaoAtual = mapa.ObterPosicaoAtual();

            // Assert
            posicaoAtual.Should().BeEquivalentTo(posicaoEsperada);
        }

        [Fact]
        public void LocalizarAmigoProximo_deve_retornar_o_amigo_mais_proximo_de_sua_localizacao_atual()
        {
            // Arrange
            var coordenadas = new Coordenadas(50, 50);
            var amigoEsperado = new Amigo(new Coordenadas(48, 50));
            var amigos = new List<Amigo>()
            {
                new Amigo(new Coordenadas(10, 20)),
                new Amigo(new Coordenadas(45, 50)),
                amigoEsperado,
                new Amigo(new Coordenadas(40, 50)),
            };

            var mapa = new MapaAmigos(coordenadas, amigos);

            // Act
            Amigo amigoEncontrado = mapa.LocalizarAmigoProximo();

            // Assert
            amigoEncontrado.Should().Be(amigoEsperado);
        }
    }
}
