using System;
using System.Threading.Tasks;
namespace TrucoConTruco
{
    public class Sala
    {
        public string nombreDeLaSala;
        public Action<string> mensajesRonda;
        Mazo mazo;
        public Partida partida;

        

        public Sala(string nombreDeLaSala, Mazo mazo)
        {
            this.nombreDeLaSala = nombreDeLaSala;
            this.mazo = mazo;
        }

        public void MostrarPorPantalla(string texto)
        {
            mensajesRonda?.Invoke(texto);
        }


        public async void CrearPartida(Jugador jugadorUno, Jugador jugadorDos)
        {

            jugadorUno.estaJugando = true;
            jugadorDos.estaJugando = true;  
            jugadorUno.MensajeJugador += MostrarPorPantalla;
            jugadorDos.MensajeJugador += MostrarPorPantalla;

            partida = new Partida(jugadorUno, jugadorDos, mazo, MostrarPorPantalla,nombreDeLaSala);
        
            Task tarea1 = Task.Run(() => partida.Jugar());
            
            await tarea1.ConfigureAwait(true);

            if (jugadorUno.puntaje > jugadorDos.puntaje)
            {
                partida.idJugadorGanador = jugadorUno.idJugador;
                partida.idJugadorPerdedor = jugadorDos.idJugador;
            }
            else
            {
                if (jugadorUno.puntaje < jugadorDos.puntaje)
                {
                    partida.idJugadorGanador = jugadorDos.idJugador;
                    partida.idJugadorPerdedor = jugadorUno.idJugador;
                }
            
            }


            if (tarea1.IsCompleted)
            {
                jugadorUno.estaJugando = false;
                jugadorDos.estaJugando = false;
                ConexionABaseDeDatos.GuardarPartidas(partida);
            }

        }

    }
}
