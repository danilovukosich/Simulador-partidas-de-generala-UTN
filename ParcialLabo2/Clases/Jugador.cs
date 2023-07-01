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

    }
}
