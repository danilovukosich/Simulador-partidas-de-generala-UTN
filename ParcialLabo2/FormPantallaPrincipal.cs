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
    public partial class FormPantallaPrincipal : Form
    {
        Jugador jugadorIngresado = new Jugador();

        public FormPantallaPrincipal(Jugador jugador)
        {
            InitializeComponent();
            jugadorIngresado = jugador;
        }

        private void FormPantallaPrincipal_Load(object sender, EventArgs e)
        {
            labelBienvenido.Text = $"Bienvenido, {jugadorIngresado.Nombre} {jugadorIngresado.Apellido}";
        }

        private void buttonEstadisticas_Click(object sender, EventArgs e)
        {
            FormularioEstadisticas formEstadisticas = new FormularioEstadisticas(jugadorIngresado);
            this.Hide();
            formEstadisticas.ShowDialog();
        }

        private void buttonCrearPartida_Click(object sender, EventArgs e)
        {
            Task.Run(() => { AbrirJuego(); });
        }

        public void AbrirJuego()
        {
            FormularioPartida form = new FormularioPartida(jugadorIngresado);
            form.ShowDialog();
        }

        private void FormPantallaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInicioSesion form = new FormInicioSesion();
            this.Hide();
            form.ShowDialog();
        }
    }
}
