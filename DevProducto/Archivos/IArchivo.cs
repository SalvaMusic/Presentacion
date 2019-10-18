
namespace Archivos
{
    public interface IArchivo<T>
    {
        void Guardar(string archivo, T dato);
        void Leer(string archivo, out T dato);
    }
}
