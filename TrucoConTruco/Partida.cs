using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TrucoConTruco
{
    public class Partida
    {
        public Jugador jugadorUno;
        public Jugador jugadorDos;
        Mazo mazo;
        public List<LogicaDeRonda> rondas;
        string fechaDePartida;
        int numeroDeRondas = 1;
        public Action<string> mensajesRonda;
        public LogicaDeRonda logicaDeRonda;
        bool partidaFinalizada;


        public Partida(Jugador jugadorUno, Jugador jugadorDos, Mazo mazo, Action<string> mensajesRonda)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.mazo = mazo;
            fechaDePartida = DateTime.Today.ToString("dd-MMMM-yyyy");
            rondas = new List<LogicaDeRonda>();
            this.mensajesRonda = mensajesRonda;
        }


        public void Jugar(CancellationToken cts)
        {
            while (!cts.IsCancellationRequested)
            {
                while (!(jugadorUno.puntaje > 5 || jugadorDos.puntaje > 5))
                {
                    Mazo alternativo = new Mazo("Alternativo");
                    alternativo.mazoDeCartas = mazo.mazoDeCartas.ToList();


                    logicaDeRonda = new LogicaDeRonda(jugadorUno, jugadorDos, numeroDeRondas, mensajesRonda, alternativo);
                    logicaDeRonda.Jugar();

                    numeroDeRondas++;
                }

                partidaFinalizada = true;

            }



        }










    }
}