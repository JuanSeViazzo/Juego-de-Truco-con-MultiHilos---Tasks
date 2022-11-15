//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace TrucoConTruco
//{
//    public delegate string Mensaje();
//    internal class Ronda
//    {

//        Mensaje mensajeJugada;
//        Jugador jugadorUno;
//        Jugador jugadorDos;
//        Jugador jugadorMano;
//        Jugador jugadorPie;
//        int numeroDeRonda;
//        int numeroDeJugadas;
//        Carta cartajugadorMano;
//        Carta cartajugadorPie;
//        int primerResultado;
//        int segundoResultado;
//        int tercerResultado;
//        Action<string> mensajesRonda;
//        Mazo mazo;

//        bool trucoPrimerMano;
//        bool trucoSegundaMano;
//        bool seCantoEnvido;
//        bool esPrimerMano;
//        bool esSegundaMano;

//        public int TantosJugadorMano { get => CalcularTantos(jugadorMano.mano); }
//        public int TantosJugadorPie { get => CalcularTantos(jugadorPie.mano); }
//        public int DecisionjugadorMano { get => jugadorMano.TomarDecision(); }
//        public int DecisionjugadorPie { get => jugadorPie.TomarDecision(); }


//        public Ronda(Jugador jugadorUno, Jugador jugadorDos, int numeroDeRonda, Action<string> mensajesRonda, Mazo mazo)
//        {
//            this.jugadorUno = jugadorUno;
//            this.jugadorDos = jugadorDos;
//            this.numeroDeRonda = numeroDeRonda;
//            this.mensajesRonda = mensajesRonda;
//            this.mazo = mazo;
//        }

//        public void Jugar()
//        {
//            var num = 1;
//            //hay ganador cierro la ronda
//            while (num == 1)
//            {
//                mensajesRonda.Invoke($"\n----COMIENZO DE LA RONDA N° {numeroDeRonda}------\n");

//                repartirCartas();
//                MostrarCartasDeCadaJugador();



//                mensajesRonda.Invoke($"\nPuntaje del jugador N° 1: {jugadorUno.puntaje}\n");
//                mensajesRonda.Invoke($"\nPuntaje del jugador N° 2: {jugadorDos.puntaje}\n");
//                mensajesRonda.Invoke($"\n----FIN DE LA RONDA------\n");

//                num = 2;
//            }



            










//                }
//                catch (Exception)
//                {

//                    throw;
//                }







//            }





//        }



