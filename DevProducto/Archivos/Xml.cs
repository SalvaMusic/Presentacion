using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T dato)
        {
            try
            {
                string[] partes = archivo.Split(Path.DirectorySeparatorChar);
                string file = partes[partes.Length - 1];
                string folder = partes[partes.Length - 2];

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, dato);


                if (!(writer is null))
                {
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }

        public void Leer(string archivo, out T dato)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(archivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));
           
                dato = (T)ser.Deserialize(reader);
                reader.Close();
            }          
            catch (Exception ex)
            {
                throw ex;
            }
}
    }
}
