using System;
using System.Collections.Generic;

namespace MundoPequeno
{
    internal class MapaAmigos
    {
        public List<Amigo> Amigos { get; private set; }

        public Coordenadas PosicaoAtual { get; private set; }


        public MapaAmigos(Coordenadas posicaoInicial, List<Amigo> amigos = null)
        {
            this.Amigos = new List<Amigo>();
            this.PosicaoAtual = posicaoInicial;
            this.Amigos = amigos ?? new List<Amigo>();
        }

        public void AdicionarAmigo(Amigo amigo)
        {
            this.Amigos.Add(amigo);
        }

        public Coordenadas ObterPosicaoAtual() => this.PosicaoAtual;

        public Amigo LocalizarAmigoProximo()
        {
            Amigo amigoMaisProximo = null;
            double distancia;
            double distanciaTemp = 99999;

            foreach (var amigo in Amigos)
            {
                var x1 = this.PosicaoAtual.Latitude;
                var x2 = amigo.Posicao.Latitude;

                var y1 = this.PosicaoAtual.Longitude;
                var y2 = amigo.Posicao.Longitude;

                distancia = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

                if (distancia < distanciaTemp)
                {
                    amigoMaisProximo = amigo;
                    distanciaTemp = distancia;
                }
            }

            return amigoMaisProximo;
        }
    }
}