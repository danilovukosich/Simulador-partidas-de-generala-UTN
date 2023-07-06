using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo2.Clases
{
    public class ExcepcionAccesoDatos : Exception
    {
        public ExcepcionAccesoDatos(string mensaje): this(mensaje, null) 
        {

        }

        public ExcepcionAccesoDatos(string mensaje, Exception inner): base(mensaje, inner)
        {

        }
    }
}
