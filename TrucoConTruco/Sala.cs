using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrucoConTruco
{
    public class Sala
    {
        List<Partida> partidasActuales;
        public string nombreDeLaSala;
        static int limiteDePartidas;
        //Action<string> partidasEnJuego;
        Action<string> mensajesRonda;
        Mazo mazo;




        static Sala()
        {
            limiteDePartidas = 20;
        }

        public Sala(string nombreDeLaSala, Mazo mazo, Action<string> mensajesRonda)
        {
            this.nombreDeLaSala = nombreDeLaSala;
            this.mazo = mazo;
            this.mensajesRonda = mensajesRonda;
        }

        public void CrearPartida()
        {
            
            Jugador jugadorUno = new Jugador(new Usuario());
            Jugador jugadorDos = new Jugador(new Usuario());
            jugadorUno.MensajeJugador += mensajesRonda;
            jugadorDos.MensajeJugador += mensajesRonda;

            Partida partida = new Partida(jugadorUno, jugadorDos, mazo, /*partidasEnJuego*/mensajesRonda);
            Task jugar = new Task(partida.Jugar);
            jugar.Start();

        }

    }
}
