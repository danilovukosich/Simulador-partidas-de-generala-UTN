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
            conexionStirng = @"Data Source =.;Database = GENERALA_DB;Trusted_Connection = True;User ID=sa;Password=alumno;";
            comando = new SqlCommand();
            conexion = new SqlConnection(conexionStirng);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        
        }

        /// <summary>
        /// Lee y devuelve los jugadores de una base de datos
        /// </summary>
        /// <returns>Lista de jugadores</returns>
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
            catch (Exception e)
            {
                MessageBox.Show("Error en la lectura de datos" + e.Message);
                return null;
            }
            finally 
            { 
                conexion.Close(); 
            }
            
           
        }

        /// <summary>
        /// Escribe un nuevo jugador en la base de datos.
        /// </summary>
        /// <param name="jugador"></param>
        public static void EscribirDatosJugador(Jugador jugador)
        {
            try 
            {
                if(jugador!=null)
                {
                    comando.Parameters.Clear();
                    conexion.Open();
                    comando.CommandText = "INSERT INTO TABLA_JUGADORES (NOMBRE, APELLIDO, USUARIO, CONTRASENIA, PARTIDAS_JUGADAS, PARTIDAS_GANADAS, PARTIDAS_PERDIDAS)" +
                                            $" VALUES ('{jugador.Nombre}', '{jugador.Apellido}', '{jugador.Usuario}', '{jugador.Contrasenia}', {jugador.PartidasJugadas.ToString()}, {jugador.PartidasGanadas.ToString()}, {jugador.PartidasPerdidas.ToString()});";

                    comando.ExecuteNonQuery();
                }
                else
                {
                    throw new ExcepcionAccesoDatos("Error al escribir datos (El jugador es null)!");
                }
            }
            catch (ExcepcionAccesoDatos e) 
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Modifica las partidas jugadas, las paritdas perdida y las partidas ganadas
        /// en la base de datos segun el id del jugador ingresado
        /// </summary>
        /// <param name="jugador"></param>
        public static void ModificarDatosJugador(Jugador jugador)
        {
            try
            {
                if(jugador!=null)
                {
                    comando.Parameters.Clear();
                    conexion.Open();
                    comando.CommandText = $"UPDATE TABLA_JUGADORES SET PARTIDAS_JUGADAS = {jugador.PartidasJugadas.ToString()}, PARTIDAS_GANADAS = {jugador.PartidasGanadas.ToString()}, PARTIDAS_PERDIDAS = {jugador.PartidasPerdidas.ToString()}" +
                        $" WHERE ID = {jugador.Id};";

                    comando.ExecuteNonQuery();

                }
                else
                {
                    throw new ExcepcionAccesoDatos("\"Erro al modificar datos (El jugador es null)!\"");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally 
            { 
                conexion.Close(); 
            }
        }


    }
}
