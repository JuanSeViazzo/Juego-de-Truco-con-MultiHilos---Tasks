using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
namespace TrucoConTruco
{
    public class Sala
    {
        public string nombreDeLaSala;
        public Action<string> mensajesRonda;
        Mazo mazo;
        public Partida partida;
        private static int contadorSala=0;
        public int numeroDeSala;
        public CancellationTokenSource ctsAja;


        static Sala()
        {
            contadorSala=0;
        }

        public Sala(string nombreDeLaSala, Mazo mazo, CancellationTokenSource cts)
        {
            this.nombreDeLaSala = nombreDeLaSala;
            this.mazo = mazo;
            numeroDeSala += contadorSala++;
            this.ctsAja = cts;
        }

        public void CrearPartida(Jugador jugadorUno, Jugador jugadorDos)
        {
            
          
            jugadorUno.MensajeJugador += mensajesRonda;
            jugadorDos.MensajeJugador += mensajesRonda;
            mensajesRonda?.Invoke($"Numero de Sala: {numeroDeSala}");

            partida = new Partida(jugadorUno, jugadorDos, mazo, mensajesRonda);
            //Task jugar = new Task(partida.Jugar,cts.Token);
            //jugar.Start();
            Task tarea1 = Task.Run(() => partida.Jugar(ctsAja.Token));

            jugadorUno.usuario.historialDePartidas.Add(partida);
            jugadorDos.usuario.historialDePartidas.Add(partida);
            jugadorUno.usuario.historialDePuntos += jugadorUno.puntaje;

        }

    }
}
