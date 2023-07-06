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
            this.Close();
            this.Hide();

        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxContrasenia_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxContrasenia_Leave(object sender, EventArgs e)
        {

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
                MessageBox.Show("Registrado exitosamente!");
                this.Close();
                this.Hide();

            }
            else { MessageBox.Show("Completar todos los campos"); }

        }

        private void FormularioRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Cancelar la pulsación del caracter
                e.Handled = true;
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Cancelar la pulsación del caracter
                e.Handled = true;
            }
        }
    }
}
