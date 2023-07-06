using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo2.Clases
{
    public class Jugador
    {
        private int id;
        private string nombre;
        private string apellido;
        private string usuario;
        private string contrasenia;
        private int partidasJugadas;
        private int partidasGanadas;
        private int partidasPerdidas;

        public Jugador()
        {

        }
        public Jugador(int id, string nombre, string apellido, string usuario, string contrasenia, int partidasJugadas, int partidasGanadas, int partidasPerdidas)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.partidasJugadas = partidasJugadas;
            this.partidasGanadas = partidasGanadas;
            this.partidasPerdidas = partidasPerdidas;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public int PartidasJugadas
        {
            get { return partidasJugadas; }
            set { partidasJugadas = value; }
        }

        public int PartidasGanadas
        {
            get { return partidasGanadas; }
            set { partidasGanadas = value; }
        }

        public int PartidasPerdidas
        {
            get { return partidasPerdidas; }
            set { partidasPerdidas = value; }
        }

        /// <summary>
        /// Valida si el jugador existe o no.
        /// </summary>
        /// <param name="listaJugadores"></param>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns>Devuelde el jugador si es que existe, sino retorna null</returns>
        static public Jugador ValidarCredenciales(List<Jugador> listaJugadores, string usuario, string clave)
        {

            Jugador jugadorIngresado = null;

            foreach (Jugador item in listaJugadores)
            {
                if (item.usuario == usuario && item.contrasenia == clave)
                {
                    jugadorIngresado = item;
                }

            }

            return jugadorIngresado;
        }

        /// <summary>
        /// Determina el nombre de la persona que gano.
        /// </summary>
        /// <param name="pts1"></param>
        /// <param name="pts2"></param>
        /// <param name="nombreJug1"></param>
        /// <returns>Devuelve el nombre de jugador si gana, Maquina si piede o empate si empata.</returns>
        public static string CalcularGanador(int pts1, int pts2, string nombreJug1)
        {
            string ganador = "Empate";

            if (pts1 > pts2)
            {
                return nombreJug1;
            }
            else
            {
                if (pts1 < pts2)
                {
                    return "Maquina";
                }
             
            }

            return ganador;

        }
        
        /// <summary>
        /// Determina los puntos del ganador de la partida.
        /// </summary>
        /// <param name="pts1"></param>
        /// <param name="pts2"></param>
        /// <returns>Devuelve los puntos del jugador que gano.</returns>
        public static int PuntosGanador(int pts1, int pts2)
        {
            int ptsGanador = pts1;
            
            if (pts1 < pts2)
            {
                ptsGanador = pts2;
            }

            return ptsGanador;
        }

    }
}
