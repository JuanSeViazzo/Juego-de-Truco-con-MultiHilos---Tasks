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
        public int puntajeJugadorUno;
        public int puntajeJugadorDos;
        public int idJugadorGanador;
        public int idJugadorPerdedor;
        Mazo mazo;
        public List<LogicaDeRonda> rondas;
        public string fechaDePartida;
        public int numeroDeRondas;
        public Action<string> mostrarMensajeMetodo;
        public LogicaDeRonda logicaDeRonda;
        bool partidaFinalizada;
        public CancellationTokenSource cts;
        public int numeroDePartida;
        private static int contadorPartida = 0;
        public string nombreDePartida;
        static Partida()
        {
            contadorPartida = 0;
        }


        public Partida(Jugador jugadorUno, Jugador jugadorDos, Mazo mazo, Action<string> mostrarMensajeMetodo, string nombreDePartida)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            //this.idJugadorGanador = jugadorUno.idJugador;
            //this.idJugadorPerdedor = jugadorDos.idJugador;
            this.mazo = mazo;
            fechaDePartida = DateTime.Today.ToString("dd-MM-yy");
            rondas = new List<LogicaDeRonda>();
            this.mostrarMensajeMetodo = mostrarMensajeMetodo;
            cts = new CancellationTokenSource();
            numeroDePartida += contadorPartida++;
            this.nombreDePartida = nombreDePartida;
        }

        public Partida(string nombreDePartida,int puntosJugadorUno, int PuntosJugadorDos, string fechaDePartida,int idJugadorGanador, int idJugadorPerdedor)
        {
            this.nombreDePartida = nombreDePartida;
            this.puntajeJugadorUno = puntosJugadorUno;
            this.puntajeJugadorDos = PuntosJugadorDos;
            this.fechaDePartida = fechaDePartida;
            this.idJugadorGanador = idJugadorGanador;
            this.idJugadorPerdedor= idJugadorPerdedor;


        }



        public void Jugar()
        {
            try
            {
                while (!(jugadorUno.puntaje > 5 || jugadorDos.puntaje > 5))
                {
                    Mazo alternativo = new Mazo("Alternativo");
                    alternativo.mazoDeCartas = mazo.mazoDeCartas.ToList();


                    logicaDeRonda = new LogicaDeRonda(jugadorUno, jugadorDos, numeroDeRondas, mostrarMensajeMetodo, alternativo);
                    logicaDeRonda.Jugar(cts.Token);

                    numeroDeRondas++;
                }

                if (jugadorUno.puntaje > jugadorDos.puntaje)
                {
                    mostrarMensajeMetodo?.Invoke($"El Jugador {jugadorUno.nombreDeUsuario} gana la partida");
                }
                else
                {
                    if (jugadorUno.puntaje < jugadorDos.puntaje)
                    {
                    mostrarMensajeMetodo?.Invoke($"El Jugador {jugadorDos.nombreDeUsuario} gana la partida");
;
                    }
                    else
                        mostrarMensajeMetodo?.Invoke($"Han empatado la partida");

                }
               // ConexionABaseDeDatos.GuardarPartidas(this);

            }
            catch (ExcepcionFinDePartida ex)
            {
                mostrarMensajeMetodo(ex.Message);
                partidaFinalizada = true;
                return;
            }








        }










    }
}