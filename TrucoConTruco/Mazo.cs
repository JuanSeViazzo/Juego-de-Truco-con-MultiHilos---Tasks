using System.Collections.Generic;

namespace TrucoConTruco
{
    public class Mazo
    {
        private string nombre;
        public List<Carta> mazoDeCartas;

        public Mazo()
        {

        }
        public Mazo(string nombre) 
        {
            this.nombre = nombre;
            mazoDeCartas = new List<Carta>();

        }


    }
}