using System;
using System.Collections.Generic;
using System.Linq;

namespace TrucoConTruco
{
    public class Partida
    {
        public Jugador jugadorUno;
        public Jugador jugadorDos;
        Mazo mazo;
        public List<LogicaDeRonda> rondas;
        int puntosJugadorUno;
        int puntosJugadorDos;
        string fechaDePartida;
        int numeroDeRondas = 1;
        Action<string> partidasEnJuego;
        Action<string> mensajesRonda;



        public Partida(Jugador jugadorUno, Jugador jugadorDos, Mazo mazo,/* Action<string> partidasEnJuego*/Action<string>mensajesRonda)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.mazo = mazo;
            fechaDePartida = DateTime.Today.ToString("dd-MMMM-yyyy");
            rondas = new List<LogicaDeRonda>();
            //this.partidasEnJuego = partidasEnJuego;
            this.mensajesRonda = mensajesRonda;
        }


        public void Jugar()
        {
            while (!(jugadorUno.puntaje > 5 || jugadorDos.puntaje > 5))
            {
                Mazo alternativo = new Mazo("Alternativo");
                alternativo.mazoDeCartas = mazo.mazoDeCartas.ToList();
                

                LogicaDeRonda logicaDeRonda = new LogicaDeRonda(jugadorUno,jugadorDos,numeroDeRondas,mensajesRonda,alternativo);

                logicaDeRonda.Jugar();

                numeroDeRondas++;
            }

            //partidasEnJuego.Invoke($"Partida N° 1 {fechaDePartida} terminada");

        }
            









    }
}