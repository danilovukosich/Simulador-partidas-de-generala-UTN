using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ParcialLabo2.Clases
{
    public class SerializacionJson
    {
        //Uso de Generics
        public static void SerializarAJson<T>(string ruta, T objeto)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;//Para que se vea deintado 

            string objetoJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);
            //Console.WriteLine(objetoJson);
            File.WriteAllText(ruta, objetoJson);//lo guardo en el archivo
        }

        public static T DeserializarJson<T>(string ruta)
        {
            string objetoJson = File.ReadAllText(ruta);

            T objeto = JsonSerializer.Deserialize<T>(objetoJson);

            return objeto;
        }
    }
}
