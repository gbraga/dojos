namespace MundoPequeno
{
    internal class Amigo
    {
        public Coordenadas Posicao { get; private set; }
        
        public Amigo(Coordenadas posicao)
        {
            this.Posicao = posicao;
        }

    }
}