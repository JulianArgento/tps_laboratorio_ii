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
        /// <summary>
        /// Escribo un .txt con los datos ingresados en datos , le agrego el nombre recibido por nombre y lo guardo en el path AppDomain.CurrentDomain.BaseDirectory + @"Jason y txt\"
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombre"></param>
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
