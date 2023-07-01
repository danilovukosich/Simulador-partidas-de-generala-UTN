using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo2.Clases
{
    public class Partida
    {
        string jugadorUno;
        string jugadorDos;
        int puntosJugadorUno;
        int puntosJugadorDos;
        string ganador;

        public Partida()
        {

        }

        public Partida(int id, string jugadorUno, string jugadorDos, int puntosJugadorUno, int puntosJugadorDos, string ganador)
        {
            
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.puntosJugadorUno = puntosJugadorUno;
            this.puntosJugadorDos = puntosJugadorDos;
            this.ganador = ganador;
        }

       

        public string JugadorUno 
        {
            get {  return jugadorUno; } 
            set {  jugadorUno = value; } 
        }
        public string JugadorDos 
        {
            get { return jugadorDos; }
            set { jugadorDos = value; }
        }

        public int PuntosJugadorUno
        {
            get { return puntosJugadorUno; }
            set { puntosJugadorUno = value; }
        }

        public int PuntosJugadorDos
        {
            get { return puntosJugadorDos; }
            set { puntosJugadorDos = value; }
        }

        public string Ganador
        {
            get { return ganador; } 
            set { ganador = value; }
        }

    }


}
