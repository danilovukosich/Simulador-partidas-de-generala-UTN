using ParcialLabo2.AccesoDatosSQL;
using ParcialLabo2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        public FormularioPartida(Jugador jugador)
        {
            InitializeComponent();
            jugadorIngresado = jugador;
            rutaArchivoPartidas = Path.Combine(Directory.GetCurrentDirectory(), "Partidas.json");
            
            
            listaPartidas = SerializacionJson.DeserializarJson<List<Partida>>(rutaArchivoPartidas);
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
            int tres = 0;
            int cuatro = 0;
            int cinco = 0;
            int seis = 0;
            int puntuacionJugadorUno = 0;
            


            for (int i = 0; i < 5; i++)
            {
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
                await Task.Delay(1000);
            }

            //PUNTAJE JUGADOR 1
            for (int i = 0; i < tiradasJugadorUno.Length; i++)
            {

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

                if (cinco == 0)
                {
                    cinco = TiradaDados.Numeros(tiradasJugadorUno[i], 5);
                }

                if (cuatro == 0)
                {
                    cuatro = TiradaDados.Numeros(tiradasJugadorUno[i], 4);
                }

                if (tres == 0)
                {
                    tres = TiradaDados.Numeros(tiradasJugadorUno[i], 3);
                }

                if (dos == 0)
                {
                    dos = TiradaDados.Numeros(tiradasJugadorUno[i], 2);
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
            bool full2=false;
            bool flagFull2=false;
            int puntosFull2 = 0;
            int uno2 = 0;
            int dos2 = 0;
            int tres2 = 0;
            int cuatro2 = 0;
            int cinco2 = 0;
            int seis2 = 0;
            int puntuacionJugadorDos = 0;





            for (int i = 0; i < tiradasJugadorDos.Length; i++)
            {

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

                if (cinco2 == 0)
                {
                    cinco2 = TiradaDados.Numeros(tiradasJugadorDos[i], 5);
                }

                if (cuatro2 == 0)
                {
                    cuatro2 = TiradaDados.Numeros(tiradasJugadorDos[i], 4);
                }

                if (tres2 == 0)
                {
                    tres2 = TiradaDados.Numeros(tiradasJugadorDos[i], 3);
                }

                if (dos2 == 0)
                {
                    dos2 = TiradaDados.Numeros(tiradasJugadorDos[i], 2);
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
            labelCuatroJug2.Text+= cuatro2;
            labeltresJug2.Text+= tres2;
            labelDosJug2.Text+= dos2;
            labelUnoJug2.Text+= uno2;

            //modificar datos de jugador.

            int partidasJugadasJugadorUno = jugadorIngresado.PartidasJugadas++;
            
            if(puntuacionJugadorUno > puntuacionJugadorDos) 
            {
                jugadorIngresado.PartidasGanadas++;
            }
            else { jugadorIngresado.PartidasPerdidas++;}

            AccesoDatosJugador.ModificarDatosJugador(jugadorIngresado);

            nuevaPartida.JugadorUno = jugadorIngresado.Usuario;
            nuevaPartida.JugadorDos = "Maquina";

            nuevaPartida.PuntosJugadorUno = puntuacionJugadorUno;
            nuevaPartida.PuntosJugadorDos = puntuacionJugadorDos;
            nuevaPartida.Ganador = "ganador";

            //acceso datos paritdas// serializar?
            listaPartidas.Add(nuevaPartida);

            SerializacionJson.SerializarAJson<List<Partida>>(rutaArchivoPartidas, listaPartidas);

            //terminar task
        }

        private void buttonCrearPartida_Click(object sender, EventArgs e)
        {
            
        }
    }
}
