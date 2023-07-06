using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo2.Clases
{
    public class TiradaDados
    {
        /// <summary>
        /// Genera un array de 5 numeros rendom
        /// </summary>
        /// <returns></returns>
        public static int[] TiradarDados()
        {
            int[] dados = new int[5];
            Random random = new Random();

            for (int i = 0; i < dados.Length; i++)
            {
                dados[i] = random.Next(1, 7);
            }

            return dados;


        }

        //todos los dados iguales
        /// <summary>
        /// Determina si la tirada de dados es generala o no.
        /// </summary>
        /// <param name="tiradaDados"></param>
        /// <returns>Devuelve True si es Generala o False si no lo es</returns>
        public static bool Generala(int[] tiradaDados)
        {
            int primerNumero = tiradaDados[0];

            for (int i = 1; i < tiradaDados.Length; i++)
            {
                if (tiradaDados[i] != primerNumero)
                {
                    return false;
                }
            }
            return true;
        }

        //cuando hay 4 iguales
        /// <summary>
        /// Determina si la tirada es Poker o no.
        /// </summary>
        /// <param name="tiradaDados"></param>
        /// <returns>Devuelve True si es Poker y False si no lo es</returns>
        public static bool Poker(int[] tiradaDados)
        {
            Array.Sort(tiradaDados);

            //si los primeros 4 son iguales o si los ultimos 4 son iguales
            if (tiradaDados[0] == tiradaDados[3] || tiradaDados[1] == tiradaDados[4])
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determina si la tirada es Full o no.
        /// </summary>
        /// <param name="tiradaDados"></param>
        /// <returns>Devuelve True si es Full y False si no lo es</returns>
        public static bool Full(int[] tiradaDados)
        {
            Array.Sort(tiradaDados);

            if ((tiradaDados[0] == tiradaDados[2] && tiradaDados[3] == tiradaDados[4]) || (tiradaDados[0] == tiradaDados[1] && tiradaDados[2] == tiradaDados[4]))
            {
                return true;
            }

            return false;
        }

        //varias mertodos iguales con diferente numero como parametro
        /// <summary>
        /// Metodo que segun el numero que ingrese determina si se repite o no.
        /// </summary>
        /// <param name="tiradaDados"></param>
        /// <param name="numero"></param>
        /// <returns>Devuelve la acumulacion de veces que se repita el numero, si no se repite devuelve cero.</returns>
        public static int Numeros(int[] tiradaDados, int numero)
        {
            int contador = 0;
            int acumulador = 0;
            for (int i = 0; i < tiradaDados.Length; i++)
            {
                if (numero == tiradaDados[i])
                {
                    contador++;
                    acumulador += numero;
                }
            }

            if (contador > 1)
            {
                return acumulador;
            }

            return 0;
        }

        /// <summary>
        /// Determina que imagen corresponde al numero que se le ingrese.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Devuelve la imagen que corresponda al numero</returns>
        public static Image DeterminarDado(int numero)
        {
            Image nuevaImagen = Properties.Resources.dado1;

            switch (numero) 
            {
                case 1:
                    nuevaImagen = Properties.Resources.dado1;
                    break;

                case 2:
                    nuevaImagen = Properties.Resources.dado2;
                    break;

                case 3:
                    nuevaImagen = Properties.Resources.dado3;
                    break;

                case 4:
                    nuevaImagen = Properties.Resources.dado4;
                    break;

                case 5:
                    nuevaImagen = Properties.Resources.dado5;
                    break;

                case 6:
                    nuevaImagen= Properties.Resources.dado6;
                    break;
            }

            return nuevaImagen;
        }

        /// <summary>
        /// Calcula la suma total de puntos de la paritda.
        /// </summary>
        /// <param name="generala"></param>
        /// <param name="poker"></param>
        /// <param name="full"></param>
        /// <param name="uno"></param>
        /// <param name="dos"></param>
        /// <param name="tres"></param>
        /// <param name="cuatro"></param>
        /// <param name="cinco"></param>
        /// <param name="seis"></param>
        /// <returns>Devuelve la suma total de puntos de la partida.</returns>
        public static int CalcularPuntos(int generala, int poker, int full, int uno, int dos, int tres, int cuatro, int cinco, int seis)
        {
            return (generala + poker + full + uno + dos + tres + cuatro + cinco + seis);
        }

    }
}
