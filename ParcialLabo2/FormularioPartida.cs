using ParcialLabo2.AccesoDatosSQL;
using ParcialLabo2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialLabo2
{
    public partial class FormularioPartida : Form
    {
        Jugador jugadorIngresado = new Jugador();
        List<Partida> listaPartidas = new List<Partida>();
        string rutaArchivoPartidas;
        public CancellationToken cancellationToken;
        public CancellationTokenSource cancellationTokenSource;
        bool flagPartida = false;
        SerializacionJson serializarDatos = new SerializacionJson();

        public FormularioPartida(Jugador jugador)
        {
            InitializeComponent();
            jugadorIngresado = jugador;
            rutaArchivoPartidas = Path.Combine(Directory.GetCurrentDirectory(), "Partidas.json");

            this.cancellationTokenSource = new CancellationTokenSource();
            this.cancellationToken = this.cancellationTokenSource.Token;

            listaPartidas = serializarDatos.DeserializarJson<List<Partida>>(rutaArchivoPartidas);
        }

        private void FormularioPartida_Load(object sender, EventArgs e)
        {
            labelJugador1.Text = jugadorIngresado.Usuario;
            labelJugador2.Text = "Maquina";
            JugarPartida();


        }

        private void FormularioPartida_Shown(object sender, EventArgs e)
        {

        }

        private void buttonComenzarPartida_Click(object sender, EventArgs e)
        {


        }


        /// <summary>
        /// Metodo en el cual se realizan la tiradas de dados,
        /// se calculan los resultados al finalizar y se guardan 
        /// los datos de los jugadores en base de datos y las partidas 
        /// en SerializacioJson
        /// </summary>
        public async void JugarPartida()
        {
            Partida nuevaPartida = new Partida();


            int[][] tiradasJugadorUno = new int[5][];
            int[][] tiradasJugadorDos = new int[5][];

            bool generala = false;
            bool flagGenerala = false;
            int puntosGenerala = 0;
            bool poker = false;
            int puntosPoker = 0;
            bool flagPoker = false;
            bool full = false;
            int puntosFull = 0;
            bool flagFull = false;
            int uno = 0;
            int dos = 0;
            bool flagDos = false;
            int tres = 0;
            bool flagTres = false;
            int cuatro = 0;
            bool flagCuatro = false;
            int cinco = 0;
            bool flagCinco = false;
            int seis = 0;
            bool flagSeis = false;
            int puntuacionJugadorUno = 0;



            for (int i = 0; i < 5; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }
                tiradasJugadorUno[i] = TiradaDados.TiradarDados();
                tiradasJugadorDos[i] = TiradaDados.TiradarDados();
                pictureBox1.Image = TiradaDados.DeterminarDado(tiradasJugadorUno[i][0]);
                pictureBox1.Refresh();
                pictureBox2.Image = TiradaDados.DeterminarDado(tiradasJugadorUno[i][1]);
                pictureBox2.Refresh();
                pictureBox3.Image = TiradaDados.DeterminarDado(tiradasJugadorUno[i][2]);
                pictureBox3.Refresh();
                pictureBox4.Image = TiradaDados.DeterminarDado(tiradasJugadorUno[i][3]);
                pictureBox4.Refresh();
                pictureBox5.Image = TiradaDados.DeterminarDado(tiradasJugadorUno[i][4]);
                pictureBox5.Refresh();

                pictureBox6.Image = TiradaDados.DeterminarDado(tiradasJugadorDos[i][0]);
                pictureBox6.Refresh();
                pictureBox7.Image = TiradaDados.DeterminarDado(tiradasJugadorDos[i][1]);
                pictureBox7.Refresh();
                pictureBox8.Image = TiradaDados.DeterminarDado(tiradasJugadorDos[i][2]);
                pictureBox8.Refresh();
                pictureBox9.Image = TiradaDados.DeterminarDado(tiradasJugadorDos[i][3]);
                pictureBox9.Refresh();
                pictureBox10.Image = TiradaDados.DeterminarDado(tiradasJugadorDos[i][4]);
                pictureBox10.Refresh();
                //Thread.Sleep(1000);
                await Task.Delay(1500);
            }

            //PUNTAJE JUGADOR 1
            for (int i = 0; i < tiradasJugadorUno.Length; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }
                if (generala == false)
                {
                    generala = TiradaDados.Generala(tiradasJugadorUno[i]);
                }
                if (generala == true)
                {
                    if (flagGenerala == false)
                    {
                        //puntaje genrala=50;
                        flagGenerala = true;
                        puntosGenerala = 50;
                        continue;
                    }
                }


                if (poker == false)
                {
                    poker = TiradaDados.Poker(tiradasJugadorUno[i]);
                }
                if (poker == true)
                {
                    if (flagPoker == false)
                    {
                        //40
                        flagPoker = true;
                        puntosPoker = 40;
                        continue;
                    }
                }

                if (full == false)
                {
                    full = TiradaDados.Full(tiradasJugadorUno[i]);
                }
                if (full == true)
                {
                    if (flagFull == false)
                    {
                        //30
                        flagFull = true;
                        puntosFull = 30;
                        continue;
                    }
                }


                if (seis == 0)
                {
                    seis = TiradaDados.Numeros(tiradasJugadorUno[i], 6);
                }
                if (seis > 0)
                {
                    if (flagSeis == false)
                    {
                        flagSeis = true;
                        continue;
                    }
                }

                if (cinco == 0)
                {
                    cinco = TiradaDados.Numeros(tiradasJugadorUno[i], 5);
                }
                if (cinco > 0)
                {
                    if (flagCinco == false)
                    {
                        flagCinco = true;
                        continue;
                    }
                }

                if (cuatro == 0)
                {
                    cuatro = TiradaDados.Numeros(tiradasJugadorUno[i], 4);
                }
                if (cuatro > 0)
                {
                    if (flagCuatro == false)
                    {
                        flagCuatro = true;
                        continue;
                    }
                }

                if (tres == 0)
                {
                    tres = TiradaDados.Numeros(tiradasJugadorUno[i], 3);
                }
                if (tres > 0)
                {
                    if (flagTres == false)
                    {
                        flagTres = true;
                        continue;
                    }
                }

                if (dos == 0)
                {
                    dos = TiradaDados.Numeros(tiradasJugadorUno[i], 2);
                }
                if (dos > 0)
                {
                    if (flagDos == false)
                    {
                        flagDos = true;
                        continue;
                    }
                }

                if (uno == 0)
                {
                    uno = TiradaDados.Numeros(tiradasJugadorUno[i], 1);
                }

            }

            puntuacionJugadorUno = TiradaDados.CalcularPuntos(puntosGenerala, puntosPoker, puntosFull, uno, dos, tres, cuatro, cinco, seis);

            labelPuntosJugador1.Text = $"{labelPuntosJugador1.Text} {puntuacionJugadorUno}";
            labelGeneralaJug1.Text = $"{labelGeneralaJug1.Text} {puntosGenerala}";
            labelPokerJug1.Text = $"{labelPokerJug1.Text} {puntosPoker}";
            labelFullJug1.Text = $"{labelFullJug1.Text} {puntosFull}";
            labelUnoJug1.Text = labelUnoJug1.Text + uno;
            labelDosJug1.Text = labelDosJug1.Text + dos;
            labelTresJug1.Text = labelTresJug1.Text + tres;
            labelCuatroJug1.Text = labelCuatroJug1.Text + cuatro;
            labelCincoJug1.Text = labelCincoJug1.Text + cinco;
            labelSeisJug1.Text = labelSeisJug1.Text + seis;

            puntuacionJugadorUno = TiradaDados.CalcularPuntos(puntosGenerala, puntosPoker, puntosFull, uno, dos, tres, cuatro, cinco, seis);
            //PUNTAJE JUGADOR 2

            bool generala2 = false;
            bool flagGenerala2 = false;
            int puntosGeneral2 = 0;
            bool poker2 = false;
            bool flagPoker2 = false;
            int puntosPoker2 = 0;
            bool full2 = false;
            bool flagFull2 = false;
            int puntosFull2 = 0;
            int uno2 = 0;
            int dos2 = 0;
            bool flagDos2 = false;
            int tres2 = 0;
            bool flagTres2 = false;
            int cuatro2 = 0;
            bool flagCuatro2 = false;
            int cinco2 = 0;
            bool flagCinco2 = false;
            int seis2 = 0;
            bool flagSeis2 = false;
            int puntuacionJugadorDos = 0;


            for (int i = 0; i < tiradasJugadorDos.Length; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }
                if (generala2 == false)
                {
                    generala2 = TiradaDados.Generala(tiradasJugadorDos[i]);
                }
                if (generala2 == true)
                {
                    if (flagGenerala2 == false)
                    {
                        //puntaje genrala=50;
                        flagGenerala2 = true;
                        puntosGeneral2 = 50;
                        continue;
                    }
                }


                if (poker2 == false)
                {
                    poker2 = TiradaDados.Poker(tiradasJugadorDos[i]);
                }
                if (poker2 == true)
                {
                    if (flagPoker2 == false)
                    {
                        //40
                        flagPoker2 = true;
                        puntosPoker2 = 40;
                        continue;
                    }
                }

                if (full2 == false)
                {
                    full2 = TiradaDados.Full(tiradasJugadorDos[i]);
                }
                if (full2 == true)
                {
                    if (flagFull2 == false)
                    {
                        //30
                        flagFull2 = true;
                        puntosFull2 = 30;
                        continue;
                    }
                }


                if (seis2 == 0)
                {
                    seis2 = TiradaDados.Numeros(tiradasJugadorDos[i], 6);
                }
                if (seis2 > 0)
                {
                    if (flagSeis2 == false)
                    {
                        flagSeis2 = true;
                        continue;
                    }
                }

                if (cinco2 == 0)
                {
                    cinco2 = TiradaDados.Numeros(tiradasJugadorDos[i], 5);
                }
                if (cinco2 > 0)
                {
                    if (flagCinco2 == false)
                    {
                        flagCinco2 = true;
                        continue;
                    }
                }

                if (cuatro2 == 0)
                {
                    cuatro2 = TiradaDados.Numeros(tiradasJugadorDos[i], 4);
                }
                if (cuatro2 > 0)
                {
                    if (flagCuatro2 == false)
                    {
                        flagCuatro2 = true;
                        continue;
                    }
                }

                if (tres2 == 0)
                {
                    tres2 = TiradaDados.Numeros(tiradasJugadorDos[i], 3);
                }
                if (tres2 > 0)
                {
                    if (flagTres2 == false)
                    {
                        flagTres2 = true;
                        continue;
                    }
                }


                if (dos2 == 0)
                {
                    dos2 = TiradaDados.Numeros(tiradasJugadorDos[i], 2);
                }
                if (dos2 > 0)
                {
                    if (flagDos2 == false)
                    {
                        flagDos2 = true;
                        continue;
                    }
                }

                if (uno2 == 0)
                {
                    uno2 = TiradaDados.Numeros(tiradasJugadorDos[i], 1);
                }

            }

            puntuacionJugadorDos = TiradaDados.CalcularPuntos(puntosGeneral2, puntosPoker2, puntosFull2, uno2, dos2, tres2, cuatro2, cinco2, seis2);
            labelPuntosJugador2.Text = $"{labelPuntosJugador2.Text} {puntuacionJugadorDos}";
            labelGeneralaJug2.Text = labelGeneralaJug2.Text + puntosGeneral2;
            labelPokerJug2.Text += puntosGeneral2;
            labelFullJug2.Text += puntosFull2;
            labelSeisJug2.Text += seis2;
            labelCincoJug2.Text += cinco2;
            labelCuatroJug2.Text += cuatro2;
            labeltresJug2.Text += tres2;
            labelDosJug2.Text += dos2;
            labelUnoJug2.Text += uno2;

            //modificar datos de jugador.



            nuevaPartida.JugadorUno = jugadorIngresado.Usuario;
            nuevaPartida.JugadorDos = "Maquina";

            nuevaPartida.PuntosJugadorUno = puntuacionJugadorUno;
            nuevaPartida.PuntosJugadorDos = puntuacionJugadorDos;

            //PUNTOS

            nuevaPartida.Ganador = Jugador.CalcularGanador(puntuacionJugadorUno, puntuacionJugadorDos, jugadorIngresado.Nombre);


            //acceso datos paritdas// serializar
            if (!cancellationToken.IsCancellationRequested)
            {
                flagPartida = true;

                labelEstadoPartida.Text = "PARTIDA FINALIZADA";

                jugadorIngresado.PartidasJugadas++;

                if (puntuacionJugadorUno > puntuacionJugadorDos)
                {
                    jugadorIngresado.PartidasGanadas++;
                }
                else { jugadorIngresado.PartidasPerdidas++; }

                listaPartidas = serializarDatos.DeserializarJson<List<Partida>>(rutaArchivoPartidas);
                listaPartidas.Add(nuevaPartida);


                serializarDatos.SerializarAJson<List<Partida>>(rutaArchivoPartidas, listaPartidas);

                AccesoDatosJugador.ModificarDatosJugador(jugadorIngresado);


                FormularioGanador form = new FormularioGanador(puntuacionJugadorUno, puntuacionJugadorDos, jugadorIngresado.Nombre);

                form.ShowDialog();

            }

            //terminar task
        }

        //CANCELAR
        private void buttonCrearPartida_Click(object sender, EventArgs e)
        {
            if (flagPartida == false)
            {
                flagPartida = true;
                cancellationTokenSource.Cancel();
                labelEstadoPartida.Text = "PARTIDA CANCELADA";
                
            }
            else { MessageBox.Show("No se puede cancelar una partida ya terminada!"); }

        }

        private void FormularioPartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flagPartida)
            {
                MessageBox.Show("PARTIDA EN CURSO! \nCancelar o esperar a que termine.");
                e.Cancel = true;
            }
        }
    }
}
