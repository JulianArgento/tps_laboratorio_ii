using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logica
{
    public static class ArchivosTxt<T>
    {

        static string path;

        static ArchivosTxt()
        {


            path = AppDomain.CurrentDomain.BaseDirectory + @"Jason y txt\";
        }

        public static void Escribir(T datos,string nombre)
        {
            

            string nombreArchivo = path + nombre +  ".txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                     
                    
                    sw.WriteLine(datos);
                 

                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }
    }
}
