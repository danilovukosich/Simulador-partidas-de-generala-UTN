using ParcialLabo2.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo2.AccesoDatosSQL
{
    public static class AccesoDatosJugador
    {
        static string conexionStirng;
        static SqlCommand comando;
        static SqlConnection conexion;

        static AccesoDatosJugador()
        {
            conexionStirng = @"Data Source =.;Database = GENERALA_DB;Trusted_Connection = True;"; 
            comando = new SqlCommand();
            conexion = new SqlConnection(conexionStirng);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        
        }

        public static List<Jugador> LeerDatosJugador()
        {
            List<Jugador> listaJugadores = new List<Jugador>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM TABLA_JUGADORES";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read()) 
                {
                    Jugador jugadorAux = new Jugador();

                    jugadorAux.Id = (int)dataReader["ID"];
                    jugadorAux.Nombre = dataReader["NOMBRE"].ToString();
                    jugadorAux.Apellido = dataReader["APELLIDO"].ToString();
                    jugadorAux.Usuario = dataReader["USUARIO"].ToString();
                    jugadorAux.Contrasenia = dataReader["CONTRASENIA"].ToString();
                    jugadorAux.PartidasJugadas = (int)dataReader["PARTIDAS_JUGADAS"];
                    jugadorAux.PartidasGanadas = (int)dataReader["PARTIDAS_GANADAS"];
                    jugadorAux.PartidasPerdidas = (int)dataReader["PARTIDAS_PERDIDAS"];

                    listaJugadores.Add(jugadorAux);
                    
                }

                return listaJugadores;

            }
            catch (Exception)
            {
                throw;
            }
            finally 
            { 
                conexion.Close(); 
            }
            
           
        }


        public static void EscribirDatosJugador(Jugador jugador)
        {
            try 
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO TABLA_JUGADORES (NOMBRE, APELLIDO, USUARIO, CONTRASENIA, PARTIDAS_JUGADAS, PARTIDAS_GANADAS, PARTIDAS_PERDIDAS)" +
                                     $" VALUES ('{jugador.Nombre}', '{jugador.Apellido}', '{jugador.Usuario}', '{jugador.Contrasenia}', {jugador.PartidasJugadas.ToString()}, {jugador.PartidasGanadas.ToString()}, {jugador.PartidasPerdidas.ToString()});";

                comando.ExecuteNonQuery();
            }
            catch (Exception) 
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void ModificarDatosJugador(Jugador jugador)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE TABLA_JUGADORES SET PARTIDAS_JUGADAS = {jugador.PartidasJugadas.ToString()}, PARTIDAS_GANADAS = {jugador.PartidasGanadas.ToString()}, PARTIDAS_PERDIDAS = {jugador.PartidasPerdidas.ToString()}" +
                    $" WHERE ID = {jugador.Id};";

                comando.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally 
            { 
                conexion.Close(); 
            }
        }


    }
}
