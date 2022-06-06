using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Logica
{
    public static class ClaseSerializadoraJson<T>
    {

        static string path;

        static ClaseSerializadoraJson()
        {


            path = AppDomain.CurrentDomain.BaseDirectory + @"Jason y txt\";
        }

        public static void EscribirArchivo(string nombre, T data)
        {

            
            string nombreArchivo = path + nombre + ".json";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(data));

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }


        public static T LeerArchivo(string nombre)
        {
            string archivo = "";
            T datosLeidos = default;
            try
            {

                if (Directory.Exists(path))
                {
                    
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        datosLeidos = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }

                return datosLeidos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }


    }
}
