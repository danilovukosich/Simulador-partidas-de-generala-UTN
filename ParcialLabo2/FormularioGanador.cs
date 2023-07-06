using ParcialLabo2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialLabo2
{
    public delegate void InformarGanador(int pts1, int pts2, string nombreJug1);
    public delegate void InformarPuuntosGanador(int pts1, int pts2);

    public partial class FormularioGanador : Form
    {

        public event InformarGanador InformarResultado;
        public event InformarPuuntosGanador InformarPuntos;
        int ptsJugador1;
        int ptsJugador2;
        string nombreJugador1;

        public FormularioGanador(int puntJug1, int puntJug2, string nombreJug1)
        {
            InitializeComponent();
            ptsJugador1=puntJug1;
            ptsJugador2=puntJug2;
            nombreJugador1=nombreJug1;

            InformarResultado += MostrarGanador;
            InformarPuntos += MostrarPuntosGanador;
            
        }

        public void MostrarGanador(int pts1, int pts2, string nombreJug1)
        {
            label2.Text += Jugador.CalcularGanador(pts1, pts2, nombreJug1);

        }

        public void MostrarPuntosGanador(int pts1, int pts2)
        {
            label3.Text += Jugador.PuntosGanador(pts1, pts2);
        }

        private void FormularioGanador_Load(object sender, EventArgs e)
        {
            InformarResultado(ptsJugador1, ptsJugador2, nombreJugador1);
            InformarPuntos(ptsJugador1, ptsJugador2);
        }
    }
}
