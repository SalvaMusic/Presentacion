using System;
using System.IO;

namespace Archivos
{
    public class Texto:IArchivo<string> 
    {
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
