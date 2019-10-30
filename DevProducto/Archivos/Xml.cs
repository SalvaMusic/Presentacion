using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{

    /// <summary>
    /// Clase que manejará archivos Xml.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Serializará objeto en un archivo Xml.
        /// </summary>
        /// <param name="archivo">Nombre del archivo en el que se guardará</param>
        /// <param name="dato">Objeto a guardar</param>
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

        /// <summary>
        /// Leerá objeto de un archivo Xml
        /// </summary>
        /// <param name="archivo">Nombre del archivo del que se leerá</param>
        /// <param name="dato">Salida de objeto a leído</param>
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
