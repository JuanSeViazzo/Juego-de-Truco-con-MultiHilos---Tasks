using System.Collections.Generic;

namespace TrucoConTruco
{
    public class Usuario
    {
        public string nombre;
        public bool estaJugando;
        public int historialDePuntos;
        public List<Partida> historialDePartidas;

        public Usuario(string nombre, bool estaJugando)
        {
            this.nombre = nombre;
            this.estaJugando = estaJugando;
            historialDePartidas = new List<Partida>();
        }
    }
}