using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TrucoConTruco
{

    public class LogicaDeRonda
    {

        Jugador jugadorUno;
        Jugador jugadorDos;
        Jugador jugadorMano;
        Jugador jugadorPie;
        int numeroDeRonda;
        int resultadoInicial;
        public Action<string> mostrarMensajeMetodo;
        Mazo mazo;
        bool seCantoTruco;
        bool envidoAceptado;
        private Jugador jugadorAux;
        private Jugador jugadorGanador;
        private Jugador jugadorPerdedor;
        public List<Carta> manoAuxMano = new List<Carta>();
        public List<Carta> manoAuxPie = new List<Carta>();
        private int jugada = 1;

        public LogicaDeRonda()
        {

        }

        public int TantosJugadorMano { get => CalcularTantos(jugadorMano.mano); }
        public int TantosJugadorPie { get => CalcularTantos(jugadorPie.mano); }
        public int DecisionjugadorMano { get => jugadorMano.Probabilidad(); }
        public int DecisionjugadorPie { get => jugadorPie.Probabilidad(); }

        public LogicaDeRonda(Jugador jugadorUno, Jugador jugadorDos, int numeroDeRonda, Action<string> mostrarMensajeMetodo, Mazo mazo)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.numeroDeRonda = numeroDeRonda;
            this.mostrarMensajeMetodo = mostrarMensajeMetodo;
            this.mazo = mazo;
        }


        public void Jugar(CancellationToken cts)
        {
            if (!cts.IsCancellationRequested)
            {
                mostrarMensajeMetodo("Jugando Partida");
                mostrarMensajeMetodo($"\n----COMIENZO DE LA RONDA N° {numeroDeRonda}------\n");

                try
                {
                    RepartirCartas();
                    MostrarCartasDeCadaJugador();
                    while (jugada < 4 && !cts.IsCancellationRequested)
                    {
                        this.JugarJugada(1);
                        Thread.Sleep(1000);
                        jugada++;
                    }
                }
                catch (ExcepcionFinDeRonda ex)
                {
                    SumarPuntosJugada(jugadorGanador, 1);
                    mostrarMensajeMetodo($"\nPuntaje del jugador N° 1: {jugadorUno.puntaje}\n");
                    mostrarMensajeMetodo($"\nPuntaje del jugador N° 2: {jugadorDos.puntaje}\n");
                    mostrarMensajeMetodo($"\n----FIN DE LA RONDA------\n");
                    mostrarMensajeMetodo(ex.Message);
                }
                catch (Exception ex)
                {
                    mostrarMensajeMetodo(ex.Message);
                }
            }
            else
            {
                throw new ExcepcionFinDePartida("Partida finalizada");
            }


        }

        private void RepartirCartas()
        {
            Thread.Sleep(1000);

            if ((numeroDeRonda % 2) != 0)
            {

                jugadorMano = jugadorUno;
                jugadorPie = jugadorDos;
                Thread.Sleep(1000);
                mostrarMensajeMetodo($"\nEl jugador {jugadorUno.nombreDeUsuario} es Mano\n");
                Thread.Sleep(1000);
                mostrarMensajeMetodo($"El jugador {jugadorDos.nombreDeUsuario} es Pie\n");
            }
            else
            {
                jugadorMano = jugadorDos;
                jugadorPie = jugadorUno;
                Thread.Sleep(1000);
                mostrarMensajeMetodo($"\nEl jugador {jugadorUno.nombreDeUsuario} es Pie\n");
                Thread.Sleep(1000);
                mostrarMensajeMetodo($"El jugador {jugadorDos.nombreDeUsuario} es Mano\n");
            }
            jugadorMano.manoOPie = "Mano";
            jugadorPie.manoOPie = "Pie";
            jugadorPie.Mezclar(mazo);
            jugadorPie.RepartirCartas(mazo, jugadorMano, jugadorPie);

        }

        private void MostrarCartasDeCadaJugador()
        {
            Thread.Sleep(1000);
            mostrarMensajeMetodo($"\nCartas jugador Mano: \n");
            foreach (var item in jugadorMano.mano)
            {
                mostrarMensajeMetodo($"{item.valor} {item.palo}\n");
            }
            Thread.Sleep(1000);
            mostrarMensajeMetodo($"\nCartas jugador Pie: \n");

            foreach (var item in jugadorPie.mano)
            {
                mostrarMensajeMetodo($"{item.valor} {item.palo}\n");
            }
            Thread.Sleep(1000);

            mostrarMensajeMetodo($"\nTantos jugador Mano: {TantosJugadorMano}: \n");
            Thread.Sleep(1000);

            mostrarMensajeMetodo($"\nTantos jugador Pie: {TantosJugadorPie}: \n");
        }

        public void JugarJugada(int numeroDeJugada)
        {
            try
            {
                if (numeroDeJugada == 1)
                {
                    jugadorGanador = jugadorMano;
                    jugadorPerdedor = jugadorPie;
                    Thread.Sleep(1000);

                    if (jugadorGanador.JugarEnvido())
                    {
                        Thread.Sleep(1000);

                        mostrarMensajeMetodo($" canto el jugador {jugadorGanador.manoOPie}\n");
                        if (jugadorPerdedor.AceptarTrucoOEnvido())
                        {
                            Thread.Sleep(1000);

                            mostrarMensajeMetodo($" canto el jugador {jugadorPerdedor.manoOPie}\n");
                            ResolverResultadoDeEnvido(jugadorGanador, jugadorPerdedor);
                        }
                        else
                        {
                            Thread.Sleep(1000);

                            SumarPuntosJugada(jugadorGanador, 3);
                        }
                    }
                }
                if (seCantoTruco == false || numeroDeJugada != 1)
                {
                    Thread.Sleep(1000);

                    JugadaDeTruco(jugadorGanador, jugadorPerdedor);

                    if (seCantoTruco == false)
                    {
                        Thread.Sleep(1000);

                        JugadaDeTruco(jugadorPerdedor, jugadorGanador);
                    }

                    resultadoInicial = ValidarGanadorDeJugada(jugadorGanador, jugadorPerdedor, numeroDeJugada);
                    if (resultadoInicial == 2)
                    {
                        Thread.Sleep(1000);

                        jugadorAux = jugadorGanador;
                        jugadorPerdedor = jugadorGanador;
                        jugadorGanador = jugadorAux;
                    }
                }
                Thread.Sleep(1000);

                VerificarFinDePartida(jugadorUno, jugadorDos);
            }
            
            catch (Exception ex)
            {
                Thread.Sleep(1000);
                mostrarMensajeMetodo(ex.Message);
                throw;
            }
        }

        private void VerificarFinDePartida(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (jugadorUno.jugadasGanas >= 1)
            {
                if (jugada == 3)
                {
                    SumarPuntosJugada(jugadorUno, 2);
                }
               throw new ExcepcionFinDeRonda($"\nGano el jugador {jugadorUno.manoOPie}\n");

            }

            if (jugadorDos.jugadasGanas >= 1)
            {
                if (jugada == 3)
                {
                    SumarPuntosJugada(jugadorDos, 2);
                }
                throw new ExcepcionFinDeRonda($"\nGano el jugador {jugadorDos.manoOPie}\n");
            }
        }

        /// <summary>
        /// aca sumo el puntaje que le paso por parametor al jugador, puse en todos 2 para que la ronda se termine antes.
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="puntaje"></param>
        private void SumarPuntosJugada(Jugador jugador, int puntaje)
        {
            jugador.puntaje += puntaje;
        }
        public int CalcularTantos(List<Carta> mano)
        {
            List<int> tantos = new List<int>();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j < mano.Count; j++)
                {
                    if (mano[i].palo == mano[j].palo && mano[i] != mano[j])
                    {
                        tantos.Add(20 + mano[i].valorEnvido + mano[j].valorEnvido);
                    }
                }
            }
            tantos.Add(mano.Max(item => item.valorEnvido));

            return tantos.Max();
        }
        private void JugadaDeTruco(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (jugadorUno.JugarTruco())
            {
                Thread.Sleep(1000);

                mostrarMensajeMetodo($" canto el jugador {jugadorUno.manoOPie}");
                seCantoTruco = true;

                if (jugadorDos.AceptarTrucoOEnvido())
                {
                    Thread.Sleep(1000);

                    mostrarMensajeMetodo($" canto el jugador {jugadorDos.manoOPie}");
                    Thread.Sleep(1000);

                    mostrarMensajeMetodo($"\nEl jugador {jugadorUno.manoOPie} juega: ");
                    jugadorUno.ultimaCartaJugada = jugadorUno.JugarCarta();
                    Thread.Sleep(1000);

                    mostrarMensajeMetodo($"\nEl jugador {jugadorDos.manoOPie} juega: ");
                    jugadorDos.ultimaCartaJugada = jugadorDos.JugarCarta();
                }
                else
                {
                    Thread.Sleep(1000);

                    mostrarMensajeMetodo($" canto el jugador {jugadorDos.manoOPie}");
                    SumarPuntosJugada(jugadorUno, 2);
                    Thread.Sleep(1000);

                    throw new Exception($"\nEl jugador {jugadorDos.manoOPie} pierde la ronda\n");
                }
            }
            else
            {
                Thread.Sleep(1000);

                mostrarMensajeMetodo($"\nEl jugador {jugadorUno.manoOPie} juega: ");
                jugadorUno.ultimaCartaJugada = jugadorUno.JugarCarta();
            }
        }

        private void ResolverResultadoDeEnvido(Jugador ganador, Jugador perdedor)
        {
            int tantosGanador = CalcularTantos(ganador.mano);
            int tantosPerdedor = CalcularTantos(perdedor.mano);
            Thread.Sleep(1000);

            if (tantosGanador >= tantosPerdedor)
            {
                mostrarMensajeMetodo($"\nGana el envido el jugador {jugadorGanador.manoOPie}\n");
                SumarPuntosJugada(jugadorGanador, 4);
            }
            else
            {
                mostrarMensajeMetodo($"\nGana el envido el jugador {jugadorPerdedor.manoOPie}\n");
                SumarPuntosJugada(jugadorPerdedor, 4);
                Thread.Sleep(1000);

            }
        }

        private int ValidarGanadorDeJugada(Jugador jugadorUno, Jugador jugadorDos, int numeroDeJugada)
        {

            if (jugadorUno.ultimaCartaJugada.poderDeCarta < jugadorDos.ultimaCartaJugada.poderDeCarta)
            {
                Thread.Sleep(1000);

                mostrarMensajeMetodo($"\nGana la jugada N° {numeroDeJugada} jugador : {jugadorUno.manoOPie}\n");
                jugadorUno.jugadasGanas += 1;
                return 1;
            }
            else
            {
                Thread.Sleep(1000);

                mostrarMensajeMetodo($"\nGana la jugada N° {numeroDeJugada} jugador : {jugadorDos.manoOPie}\n");
                jugadorDos.jugadasGanas += 1;
                return jugadorUno.ultimaCartaJugada.poderDeCarta > jugadorDos.ultimaCartaJugada.poderDeCarta ? 2 : 0;
            }


        }

       
    }















}
