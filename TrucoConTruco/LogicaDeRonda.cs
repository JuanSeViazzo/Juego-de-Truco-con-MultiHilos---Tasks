using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TrucoConTruco
{
    public delegate string Mensaje();

    public class LogicaDeRonda
    {

        Jugador jugadorUno;
        Jugador jugadorDos;
        Jugador jugadorMano;
        Jugador jugadorPie;
        int numeroDeRonda;
        int resultadoInicial;
        Action<string> mensajesRonda;
        Mazo mazo;
        bool seCantoTruco;
        bool envidoAceptado;
        private Jugador jugadorAux;
        private Jugador jugadorGanador;
        private Jugador jugadorPerdedor;
        public List<Carta> manoAuxMano = new List<Carta>();
        public List<Carta> manoAuxPie = new List<Carta>();


        public int TantosJugadorMano { get => CalcularTantos(jugadorMano.mano); }
        public int TantosJugadorPie { get => CalcularTantos(jugadorPie.mano); }
        public int DecisionjugadorMano { get => jugadorMano.Probabilidad(); }
        public int DecisionjugadorPie { get => jugadorPie.Probabilidad(); }

        public LogicaDeRonda(Jugador jugadorUno, Jugador jugadorDos, int numeroDeRonda, Action<string> mensajesRonda, Mazo mazo)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.numeroDeRonda = numeroDeRonda;
            this.mensajesRonda = mensajesRonda;
            this.mazo = mazo;
        }


        public void Jugar()
        {
            mensajesRonda.Invoke($"\n----COMIENZO DE LA RONDA N° {numeroDeRonda}------\n");

            try
            {
                RepartirCartas();
                MostrarCartasDeCadaJugador();
                this.JugarJugada(1);
                Thread.Sleep(3000);
                this.JugarJugada(2);
                Thread.Sleep(3000);
                this.JugarJugada(3);
                Thread.Sleep(3000);

            }
            catch (ExcepcionFinDeRonda ex)
            {
                mensajesRonda.Invoke($"\nPuntaje del jugador N° 1: {jugadorUno.puntaje}\n");
                mensajesRonda.Invoke($"\nPuntaje del jugador N° 2: {jugadorDos.puntaje}\n");
                mensajesRonda.Invoke($"\n----FIN DE LA RONDA------\n");
                mensajesRonda.Invoke(ex.Message);
            }

        }

        private void RepartirCartas()
        {
            if ((numeroDeRonda % 2) != 0)
            {
                jugadorMano = jugadorUno;
                jugadorPie = jugadorDos;
                mensajesRonda.Invoke($"\nEl jugador 1° es Mano\n");
                mensajesRonda.Invoke($"El jugador 2° es Pie\n");
            }
            else
            {
                jugadorMano = jugadorDos;
                jugadorPie = jugadorUno;
                mensajesRonda.Invoke($"\nEl jugador 1° es Pie\n");
                mensajesRonda.Invoke($"El jugador 2° es Mano\n");
            }
            jugadorMano.manoOPie = "Mano";
            jugadorPie.manoOPie = "Pie";
            jugadorPie.Mezclar(mazo);
            jugadorPie.RepartirCartas(mazo, jugadorMano, jugadorPie);

        }

        private void MostrarCartasDeCadaJugador()
        {
            Thread.Sleep(3000);
            mensajesRonda.Invoke($"\nCartas jugador Mano: \n");
            foreach (var item in jugadorMano.mano)
            {
                mensajesRonda.Invoke($"{item.valor} {item.palo}\n");
            }
            Thread.Sleep(3000);
            mensajesRonda.Invoke($"\nCartas jugador Pie: \n");

            foreach (var item in jugadorPie.mano)
            {
                mensajesRonda.Invoke($"{item.valor} {item.palo}\n");
            }
            Thread.Sleep(3000);

            mensajesRonda.Invoke($"\nTantos jugador Mano: {TantosJugadorMano}: \n");
            Thread.Sleep(3000);

            mensajesRonda.Invoke($"\nTantos jugador Pie: {TantosJugadorPie}: \n");
        }

        public void JugarJugada(int numeroDeJugada)
        {
            try
            {
                if (numeroDeJugada == 1)
                {
                    jugadorGanador = jugadorMano;
                    jugadorPerdedor = jugadorPie;
                    Thread.Sleep(3000);

                    if (jugadorGanador.JugarEnvido())
                    {
                        Thread.Sleep(3000);

                        mensajesRonda($" canto el jugador {jugadorGanador.manoOPie}\n");
                        if (jugadorPerdedor.AceptarTrucoOEnvido())
                        {
                            Thread.Sleep(3000);

                            mensajesRonda($" canto el jugador {jugadorPerdedor.manoOPie}\n");
                            ResolverResultadoDeEnvido(jugadorGanador, jugadorPerdedor);
                        }
                        else
                        {
                            Thread.Sleep(3000);

                            SumarPuntosJugada(jugadorGanador, 1);
                        }
                    }
                }
                if (seCantoTruco == false)
                {
                    Thread.Sleep(3000);

                    JugadaDeTruco(jugadorGanador, jugadorPerdedor);

                    if (seCantoTruco == false)
                    {
                        Thread.Sleep(3000);

                        JugadaDeTruco(jugadorPerdedor, jugadorGanador);
                    }

                    resultadoInicial = ValidarGanadorDeJugada(jugadorGanador, jugadorPerdedor, numeroDeJugada);
                    if (resultadoInicial == 2)
                    {
                        Thread.Sleep(3000);

                        jugadorAux = jugadorGanador;
                        jugadorPerdedor = jugadorGanador;
                        jugadorGanador = jugadorAux;
                    }
                }
                Thread.Sleep(3000);

                verificarFinDePartida(jugadorUno, jugadorDos);
            }

            catch (Exception ex)
            {
                Thread.Sleep(3000);

                mensajesRonda.Invoke(ex.Message);
            }
        }

        private void verificarFinDePartida(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (jugadorUno.jugadasGanas == 2)
            {
                throw new ExcepcionFinDeRonda($"\nGano el jugador {jugadorUno.manoOPie}\n");
            }

            if (jugadorDos.jugadasGanas == 2)
            {
                throw new ExcepcionFinDeRonda($"\nGano el jugador {jugadorDos.manoOPie}\n");
            }
        }

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
                Thread.Sleep(3000);

                mensajesRonda($" canto el jugador {jugadorUno.manoOPie}");
                seCantoTruco = true;

                if (jugadorDos.AceptarTrucoOEnvido())
                {
                    Thread.Sleep(3000);

                    mensajesRonda($" canto el jugador {jugadorDos.manoOPie}");
                    Thread.Sleep(3000);

                    mensajesRonda.Invoke($"\nEl jugador {jugadorUno.manoOPie} juega: ");
                    jugadorUno.ultimaCartaJugada = jugadorUno.JugarCarta();
                    Thread.Sleep(3000);

                    mensajesRonda.Invoke($"\nEl jugador {jugadorDos.manoOPie} juega: ");
                    jugadorDos.ultimaCartaJugada = jugadorDos.JugarCarta();
                }
                else
                {
                    Thread.Sleep(3000);

                    mensajesRonda($" canto el jugador {jugadorDos.manoOPie}");
                    SumarPuntosJugada(jugadorUno, 1);
                    Thread.Sleep(3000);

                    throw new Exception($"\nEl jugador {jugadorDos.manoOPie} pierde la ronda\n");
                }
            }
            else
            {
                Thread.Sleep(3000);

                mensajesRonda.Invoke($"\nEl jugador {jugadorUno.manoOPie} juega: ");
                jugadorUno.ultimaCartaJugada = jugadorUno.JugarCarta();
            }
        }

        private void ResolverResultadoDeEnvido(Jugador ganador, Jugador perdedor)
        {
            int tantosGanador = CalcularTantos(ganador.mano);
            int tantosPerdedor = CalcularTantos(perdedor.mano);
            Thread.Sleep(3000);

            if (tantosGanador >= tantosPerdedor)
            {
                mensajesRonda.Invoke($"\nGana el envido el jugador {jugadorGanador.manoOPie}\n");
                SumarPuntosJugada(jugadorGanador, 2);
            }
            else
            {
                mensajesRonda.Invoke($"\nGana el envido el jugador {jugadorPerdedor.manoOPie}\n");
                SumarPuntosJugada(jugadorPerdedor, 2);
                Thread.Sleep(3000);

            }
        }

        private int ValidarGanadorDeJugada(Jugador jugadorUno, Jugador jugadorDos, int numeroDeJugada)
        {

            if (jugadorUno.ultimaCartaJugada.poderDeCarta < jugadorDos.ultimaCartaJugada.poderDeCarta)
            {
                Thread.Sleep(3000);

                mensajesRonda.Invoke($"\nGana la jugada N° {numeroDeJugada} jugador : {jugadorUno.manoOPie}\n");
                jugadorUno.jugadasGanas += 1;
                return 1;
            }
            else
            {
                Thread.Sleep(3000);

                mensajesRonda.Invoke($"\nGana la jugada N° {numeroDeJugada} jugador : {jugadorDos.manoOPie}\n");
                jugadorDos.jugadasGanas += 1;
                return jugadorUno.ultimaCartaJugada.poderDeCarta > jugadorDos.ultimaCartaJugada.poderDeCarta ? 2 : 0;
            }


        }

        public void VerificarGanadorDelEnvido(List<Carta> manoUno, List<Carta> manoDos)
        {
            if (envidoAceptado == false)
            {
                Thread.Sleep(3000);

                return;
            }
            int tantosJ1 = CalcularTantos(manoUno);
            int tantosJ2 = CalcularTantos(manoDos);

            if (tantosJ1 == tantosJ2 || tantosJ1 > tantosJ2)
            {
                Thread.Sleep(3000);

                mensajesRonda($"\nGana envido el jugador {jugadorUno.manoOPie}\n");
            }
            else
            {
                Thread.Sleep(3000);

                mensajesRonda($"\nGana envido el jugador {jugadorDos.manoOPie}\n");
            }

        }
    }















}
