using ParcialLabo2.AccesoDatosSQL;
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
    public partial class FormularioRegistro : Form
    {
        public FormularioRegistro()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicioSesion formInicio = new FormInicioSesion();
            formInicio.ShowDialog();
        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Nombre")
            {
                textBoxNombre.Text = "";
                textBoxNombre.ForeColor = Color.Gray;
            }
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                textBoxNombre.Text = "Nombre";
                textBoxNombre.ForeColor = Color.Gray;
            }
        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {
            if (textBoxApellido.Text == "Apellido")
            {
                textBoxApellido.Text = "";
                textBoxApellido.ForeColor = Color.Gray;
            }
        }

        private void textBoxApellido_Leave(object sender, EventArgs e)
        {
            if (textBoxApellido.Text == "")
            {
                textBoxApellido.Text = "Apellido";
                textBoxApellido.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Usuario")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Usuario";
                textBoxUsuario.ForeColor = Color.Gray;
            }
        }

        private void textBoxContrasenia_Enter(object sender, EventArgs e)
        {
            if (textBoxContrasenia.Text == "Contraseña")
            {
                textBoxContrasenia.Text = "";
                textBoxContrasenia.ForeColor = Color.Gray;
            }
        }

        private void textBoxContrasenia_Leave(object sender, EventArgs e)
        {
            if (textBoxContrasenia.Text == "")
            {
                textBoxContrasenia.Text = "Contraseña";
                textBoxContrasenia.ForeColor = Color.Gray;
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            Jugador jugadorNuevo = new Jugador();

            jugadorNuevo.Nombre = textBoxNombre.Text;
            jugadorNuevo.Apellido = textBoxApellido.Text;
            jugadorNuevo.Usuario = textBoxUsuario.Text;
            jugadorNuevo.Contrasenia = textBoxContrasenia.Text;
            jugadorNuevo.PartidasJugadas = 0;
            jugadorNuevo.PartidasGanadas = 0;
            jugadorNuevo.PartidasPerdidas = 0;


            if (jugadorNuevo.Nombre != "" && jugadorNuevo.Apellido != "" && jugadorNuevo.Usuario != "" && jugadorNuevo.Contrasenia != "")
            {
                AccesoDatosJugador.EscribirDatosJugador(jugadorNuevo);
                MessageBox.Show("Agregado exitosamente!");

            }
            else { MessageBox.Show("Completar todos los campos"); }

        }

        private void FormularioRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicioSesion formInicio = new FormInicioSesion();
            formInicio.ShowDialog();
        }
    }
}
