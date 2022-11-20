using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;



namespace TrucoConTruco
{
    public static class ConexionABaseDeDatos
    {


         static string connectionString;
         static SqlCommand command;
         static SqlConnection connection;

        static ConexionABaseDeDatos()
        {
            connectionString = @"Server = DESKTOP-0M76TDD ; Database = MiTruco; Trusted_Connection = True; TrustServerCertificate = True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }


        public static List<Jugador> LeerJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * from Jugadores";

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            Jugador jugador = new Jugador(reader["nombre_de_jugador"].ToString(),Convert.ToInt32(reader["id_jugador"]),
                                reader["carta_preferida"].ToString(), Convert.ToInt32(reader["edad"]));

                            jugadores.Add(jugador);

                        }
                        catch (Exception)
                        {

                            throw new Exception("Hubo problemas al leer los registros");
                        }


                    }
                    return jugadores;

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

        }

        public static void GuardarJugadores(Jugador jugador)
        {

            try
            {
                connection.Open();
                command.CommandText = $"Insert INTO Jugadores (nombre_de_jugador,edad,carta_preferida) " +
                    "values (@nombreUsuario,@edad,@cartaPreferida)";


                command.Parameters.AddWithValue("@nombreUsuario",jugador.nombreDeUsuario);
                command.Parameters.AddWithValue("@edad", jugador.edad);
                command.Parameters.AddWithValue("@cartaPreferida", jugador.cartaPreferida);

                command.ExecuteNonQuery();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }



        }
        public static List<Partida> LeerPartidas()
        {
            List<Partida> partidas = new List<Partida>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * from Partidas";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            Partida partida = new Partida(reader["nombre_de_partida"].ToString(), Convert.ToInt32(reader["puntosJugadorUno"]), Convert.ToInt32(reader["puntosJugadorDos"])
                              , reader["fecha_de_partida"].ToString(), Convert.ToInt32(reader["idJugadorGanador"]), 
                                Convert.ToInt32(reader["idJugadorPerdedor"]));

                            partidas.Add(partida);

                        }
                        catch (Exception ex)
                        {

                            throw;
                        }


                    }
                    return partidas;

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

        }



        public static void GuardarPartidas(Partida partida)
        {

            try
            {
                connection.Open();
                command.CommandText = $"Insert INTO Partidas (nombre_de_partida,puntosJugadorUno,puntosJugadorDos," +
                    $"fecha_de_partida,idJugadorGanador,idJugadorPerdedor)" +
                    " values (@nombreDePartida,@jugadorUnoPuntaje,@jugadorDosPuntaje," +
                    "@fechaDePartida,@idJugadorGanador,@idJugadorPerdedor)";


                command.Parameters.AddWithValue("@nombreDePartida", partida.nombreDePartida);
                command.Parameters.AddWithValue("@jugadorUnoPuntaje", partida.jugadorUno.puntaje);
                command.Parameters.AddWithValue("@jugadorDosPuntaje", partida.jugadorDos.puntaje);
                command.Parameters.AddWithValue("@numeroDePartida", partida.numeroDePartida);
                command.Parameters.AddWithValue("@fechaDePartida", partida.fechaDePartida);
                command.Parameters.AddWithValue("@idJugadorGanador", partida.idJugadorGanador);
                command.Parameters.AddWithValue("@idJugadorPerdedor", partida.idJugadorPerdedor);
   

                command.ExecuteNonQuery();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                command.Parameters.Clear();
            }



        }






        public static List<MostrarEstadisticasJugador> leerEstadisticasDeJugadores()
        {
            List<MostrarEstadisticasJugador> resultadosJugadores= new List<MostrarEstadisticasJugador>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT Jugadores.nombre_de_jugador, Jugadores.carta_preferida, edad, SUM(puntosJugadorUno) " +
                    $"as puntostotales, COUNT(*) as PartidasGanadas " +
                    $"FROM Jugadores INNER JOIN partidas ON jugadores.id_jugador = Partidas.idJugadorGanador Group by " +
                    $"Jugadores.nombre_de_jugador, Jugadores.carta_preferida, edad, partidas.puntosJugadorUno";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            MostrarEstadisticasJugador estadisticaJugador = new MostrarEstadisticasJugador(reader["nombre_de_jugador"].ToString(),
                                reader["carta_preferida"].ToString(), Convert.ToInt32(reader["edad"]),
                               Convert.ToInt32(reader["puntostotales"]),Convert.ToInt32(reader["PartidasGanadas"]));

                            resultadosJugadores.Add(estadisticaJugador);

                        }
                        catch (Exception)
                        {

                            throw new Exception("Hubo problemas al leer los registros");
                        }


                    }
                    return resultadosJugadores;

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

        }






    }
}
