using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TrucoConTruco;

namespace TrucoConTruco
{
    public class XmlSerializadora<T> where T : class, new() 
    {

        static string ruta;

        static XmlSerializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Conseguir la ruta desde cualquier PC
            ruta += @"/Archivos-Serializacion"; //Crea una carpeta 
        }


        public static void EscribirArchivoXML(T objeto)
        {
            //asi se va a nombrar el archivo
            string rutaCompleta = ruta + @"/Serializacion_" + DateTime.Now.ToString("HH-mm-ss") + ".xml";

            try
            {
                if (!Directory.Exists(ruta)) // validar si la carpeta existe
                {
                    Directory.CreateDirectory(ruta); //aca creo la carpeta, (no el archivo)
                }


                using (StreamWriter escribirSerializacion = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(escribirSerializacion, objeto);    
                }



            }
            catch (Exception)
            {

                throw new Exception($"Error en ruta {rutaCompleta}");
            }


        }

        public static T LeerArchivoXML(string rutaPasada)
        {
            string rutaCompleta = rutaPasada;

            Mazo objecto = null;

            try
            {
                if (!Directory.Exists(ruta)) // Si la carpeta no existe
                {
                    throw new Exception("La ruta no existe");

                }

                using (StreamReader leerSerializacion = new StreamReader(rutaCompleta))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T)); 

                    if (serializer.Deserialize(leerSerializacion) is T objeto)
                    {
                        return objeto;
                    }

                    throw new Exception("El objeto a deserializar no es del tipo de dato esperado.");

                }




            }
            catch (Exception)
            {

                throw;
            }



        }






    }
}
