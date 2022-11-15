using System;
using System.Collections.Generic;
using System.Linq;
namespace TrucoConTruco
{

    public class Jugador
    {
        public event Action<string> MensajeJugador;

        public Usuario usuario;
        public int puntaje;
        public bool repartidor;
        public bool esMano;
        public List<Carta> mano = new List<Carta>();
        public string manoOPie;
        public Carta ultimaCartaJugada;
        public int jugadasGanas;


        public Jugador(Usuario usuario)
        {
            this.usuario = usuario;

        }

        /// <summary>
        /// Utilizo operador lambda y el delegado que recibe OrderBy para ordenar la lista de forma random
        /// </summary>
        /// <param name="mazo"></param>
        /// <returns></returns>
        public Mazo Mezclar(Mazo mazo)
        {
            Random rnd = new Random();

            //operador lambda
            List<Carta> cartas = mazo.mazoDeCartas.OrderBy(item => rnd.Next()).ToList();

            mazo.mazoDeCartas = cartas;

            return mazo;

        }

        public void RepartirCartas(Mazo mazo, Jugador jugadorUno, Jugador jugadorDos)
        {
            jugadorUno.mano.Clear();
            jugadorDos.mano.Clear();

            List<Carta> cartasjugadorMano = jugadorUno.mano;
            List<Carta> cartasJugadorPie = jugadorDos.mano;



            cartasjugadorMano.Add(mazo.mazoDeCartas[0]);
            cartasjugadorMano.Add(mazo.mazoDeCartas[1]);
            cartasjugadorMano.Add(mazo.mazoDeCartas[2]);
            cartasJugadorPie.Add(mazo.mazoDeCartas[3]);
            cartasJugadorPie.Add(mazo.mazoDeCartas[4]);
            cartasJugadorPie.Add(mazo.mazoDeCartas[5]);

        }


        public string CantarTruco()
        {
            return "\nTruco";
        }

        public string Aceptar()
        {
            return "\nQuiero";
        }

        public string IrseAlMazo()
        {
            return "\nMe voy al Mazo";
        }

        public string ElEnvidoEstaPrimero()
        {
            return "El envido esta Primero\n";
        }

        public string CantarEnvido()
        {
            return "\nEnvido";
        }

        public string NoQuiero()
        {
            return "\nNo Quiero";
        }



        public int Probabilidad()
        {
            Random decision = new Random();

            int numero = decision.Next(0, 100);

            return (numero);

        }
        public Carta JugarCarta()
        {
            Random rnd = new Random();
            int orden = rnd.Next(0, mano.Count);
            Carta carta = new Carta();

             if (mano.Count > 0)
            {

                if (mano[orden] is not null)
                {
                    carta = mano[orden];
                }

            }
            else
            {
                throw new Exception("No hay mas cartas");
            }

            MensajeJugador.Invoke($" {carta.valor}, {carta.palo}\n");

            mano.Remove(mano[orden]);
            return carta;

        }


        public bool JugarTruco()
        {
            if (Probabilidad() > 70)
            {
                MensajeJugador.Invoke(CantarTruco());
                return true;
            }


            return false;
        }
        public bool JugarEnvido()
        {
            if (Probabilidad() > 80)
            {
                MensajeJugador.Invoke(CantarEnvido());
                return true;
            }
            return false;
        }
        public bool AceptarTrucoOEnvido()
        {
            if (Probabilidad() > 50)
            {
                MensajeJugador.Invoke(Aceptar());
                return true;
            }
            else
            {
                MensajeJugador.Invoke(NoQuiero());
                return false;
            }
        }












    }
}