
namespace Archivos
{
    /// <summary>
    /// Interfaz genérica para guardar objetos
    /// </summary>
    /// <typeparam name="T">Variable del Tipo genérico</typeparam>
    public interface IArchivo<T>
    {
        /// <summary>
        /// Guardará objeto
        /// </summary>
        /// <param name="archivo">Nombre del archivo que se guardará</param>
        /// <param name="dato">Objeto a guardar</param>
        void Guardar(string archivo, T dato);

        /// <summary>
        /// Leerá objeto
        /// </summary>
        /// <param name="archivo">Nombre del archivo que se leerá</param>
        /// <param name="dato">Objeto a leer</param>
        void Leer(string archivo, out T dato);
    }
}
