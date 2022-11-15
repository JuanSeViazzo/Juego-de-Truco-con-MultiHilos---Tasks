using System;

namespace TrucoConTruco
{
    public class Carta
    {
        public int id;
        public string palo;
        public int poderDeCarta;
        public int valor;
        public int valorEnvido;

        public Carta()
        {

        }

        public Carta(int id, string palo, int poderDeCarta, int valor, int valorEnvido)
        {
            this.id = id;
            this.palo = palo;
            this.poderDeCarta = poderDeCarta;
            this.valor = valor;
            this.valorEnvido = valorEnvido; 
        }





    }

    





}
