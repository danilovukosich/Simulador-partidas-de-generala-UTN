using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLabo2.Clases
{
    internal interface InterfaceSerializacionJson
    {
        public void SerializarAJson<T>(string ruta, T objeto);
        public  T DeserializarJson<T>(string ruta);
    }
}
