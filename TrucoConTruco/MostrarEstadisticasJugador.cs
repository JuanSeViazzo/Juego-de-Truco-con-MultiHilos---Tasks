using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoConTruco
{
    public class MostrarEstadisticasJugador
    {

        public string nombreDeJugador;
        public string cartaPreferida;
        public int edad;
        public int puntostotales;
        public int partidasganadas;

        public MostrarEstadisticasJugador(string nombreDeJugador, 
            string cartaPreferida, int edad, int puntostotales, int partidasganadas)
        {
            this.nombreDeJugador = nombreDeJugador;
            this.cartaPreferida = cartaPreferida;
            this.edad = edad;
            this.puntostotales = puntostotales;
            this.partidasganadas = partidasganadas;
        }
    }
}
