namespace MundoPequeno
{
    public class Coordenadas
    {
        public int Latitude { get; private set; }
        public int Longitude { get; private set; }

        public Coordenadas() { }

        public Coordenadas(int latitude, int longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}