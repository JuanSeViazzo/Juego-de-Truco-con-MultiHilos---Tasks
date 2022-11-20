using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TrucoConTruco
{
    public class Serializadora<T> : ISerializar<T> where T :  class, new()
    {
        static string ruta;

        static Serializadora()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;//Conseguir la ruta desde cualquier PC
            ruta += @"/Archivos-SerializacionJson"; //Crea una carpeta         }
        }
            public void EscribirSerializadora(T objeto)
            {
            try
            {
                //string rutaCompleta = ruta + @"/" + nombreArchivo + $"{DateTime.Now.ToString("dd-MM-yy HH-mm-ss")}.json";
                string rutaCompleta = ruta + @"/" + DateTime.Now.ToString("dddd-MM-yyyy")  + ".json";

                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string objetoJson = JsonSerializer.Serialize(objeto);

                try
                {
                    File.AppendAllText(rutaCompleta, objetoJson);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al intentar leer o escribir el archivo. {ex.Message}");

                }

            }
            catch (PathTooLongException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T LeerSerializadora(string archivo)
        {
            T? datos = default;
            string rutaCompleta = ruta + @"/" + archivo + ".json";

            string archivoJson = File.ReadAllText(rutaCompleta);

            datos = JsonSerializer.Deserialize<T>(archivoJson);

            return datos;
        }



    }
}
