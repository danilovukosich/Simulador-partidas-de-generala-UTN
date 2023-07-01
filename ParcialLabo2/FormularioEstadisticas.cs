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
    public partial class FormularioEstadisticas : Form
    {
        List<Partida> listaPartidas = new List<Partida>();
        string rutaArchivoPartidas;
        Jugador jugador = new Jugador();

        public FormularioEstadisticas(Jugador jugadorIngresado)
        {
            InitializeComponent();
            jugador = jugadorIngresado;
            rutaArchivoPartidas = Path.Combine(Directory.GetCurrentDirectory(), "Partidas.json");
            listaPartidas = SerializacionJson.DeserializarJson<List<Partida>>(rutaArchivoPartidas);
        }

        private void FormularioEstadisticas_Load(object sender, EventArgs e)
        {
            labelPartidasJugadas.Text = jugador.PartidasJugadas.ToString();
            labelPartidasGanadas.Text = jugador.PartidasGanadas.ToString();
            labelPartidasPerdidas.Text = jugador.PartidasPerdidas.ToString();

            dataGridView1.Rows.Clear();

            foreach (Partida item in listaPartidas)
            {
                if(item.JugadorUno == jugador.Usuario)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells[0].Value = item.JugadorUno;
                    row.Cells[1].Value = item.PuntosJugadorUno.ToString();
                    row.Cells[2].Value = item.JugadorDos;
                    row.Cells[3].Value = item.PuntosJugadorDos.ToString();
                    row.Cells[4].Value = item.Ganador;
                }
                 
            }

        }

        private void FormularioEstadisticas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPantallaPrincipal form = new FormPantallaPrincipal(jugador);
            this.Hide();
            form.Show();
        }
    }
}
