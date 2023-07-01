using ParcialLabo2.Clases;

namespace ParcialLabo2
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            comboBoxInicioSesionRapido.Items.Add("Danilo");

            comboBoxInicioSesionRapido.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {


            List<Jugador> listaJugadores = AccesoDatosSQL.AccesoDatosJugador.LeerDatosJugador();
            string usuario = textBoxUsuario.Text;
            string contrasenia = textBoxContrasenia.Text;

            Jugador jugador = Jugador.ValidarCredenciales(listaJugadores, usuario, contrasenia);

            if (jugador != null)
            {
                FormPantallaPrincipal formPantallaPrincipal = new FormPantallaPrincipal(jugador);
                this.Hide();
                formPantallaPrincipal.ShowDialog();
            }
            else { DialogResult resultado = MessageBox.Show($"No existe el usuario"); }


        }

        //registrarse
        private void button2_Click(object sender, EventArgs e)
        {
            FormularioRegistro formularioRegistro = new FormularioRegistro();
            this.Hide();
            formularioRegistro.ShowDialog();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                textBoxContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void textBoxContrasenia_Leave(object sender, EventArgs e)
        {
            if (textBoxContrasenia.Text == "")
            {
                textBoxContrasenia.Text = "Contraseña";
                textBoxContrasenia.ForeColor = Color.Gray;
                textBoxContrasenia.UseSystemPasswordChar = false;
            }
        }

        private void comboBoxInicioSesionRapido_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxContrasenia.UseSystemPasswordChar = true;

            switch (comboBoxInicioSesionRapido.Text)//switch por si tengo que agregar mas
            {
                case "Danilo":
                    textBoxUsuario.Text = "DaniloVukosich";
                    textBoxContrasenia.Text = "12345";
                    break;
            }

        }

        private void FormInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}