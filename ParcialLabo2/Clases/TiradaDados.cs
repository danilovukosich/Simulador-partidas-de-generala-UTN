using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo2.Clases
{
    public class TiradaDados
    {
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

        public static int CalcularPuntos(int generala, int poker, int full, int uno, int dos, int tres, int cuatro, int cinco, int seis)
        {
            return (generala + poker + full + uno + dos + tres + cuatro + cinco + seis);
        }

    }
}
