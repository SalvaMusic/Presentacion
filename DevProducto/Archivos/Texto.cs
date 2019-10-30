using System;
using System.IO;

namespace Archivos
{
    /// <summary>
    /// Clase que manejará archivo de texto.
    /// </summary>
    public class Texto:IArchivo<string> 
    {
        /// <summary>
        /// Guardará una cadena de string en archivo de texto.
        /// </summary>
        /// <param name="archivo">Nombre del archivo que se guardará</param>
        /// <param name="dato">string a guardar</param>
        public void Guardar(string archivo, string datos)
        {
            try
            {
                string[] partes = archivo.Split(Path.DirectorySeparatorChar);
                string file = partes[partes.Length - 1];
                string folder = partes[partes.Length - 2];

                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                using (StreamWriter sw = new StreamWriter(folder+ "\\" + file, true))
                {
                    sw.WriteLine(datos);
                }   
            }
            catch (Exception ex)
            {
                throw ex;
            }                      
        }

        /// <summary>
        /// Leerá una cadena de string en archivo de texto.
        /// </summary>
        /// <param name="archivo">Nombre del archivo que se leerá</param>
        /// <param name="dato">salida de string leído</param>
        /// <returns></returns>
        public void Leer(string archivo, out string dato)
        {
            try
            {
                StreamReader sr = new StreamReader(archivo);
                dato = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
