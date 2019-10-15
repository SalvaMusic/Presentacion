using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DevProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Estados Unidos 1221", CIva.IVA_Responsable_Inscripto, TDocum.DNI, "39708318");
            List<Producto> productos1 = new List<Producto>();
            productos1.Add(new Producto("2526", "Cuerdas de Guitarra", 150));
            productos1.Add(new Producto("2527", "Puas de Guitarra", 50));
            productos1.Add(new Producto("2528", "Afinador de Guitarra", 500));
            productos1.Add(new Producto("2529", "Bafles de Guitarra", 12000));

            Pedido pedido1 = new Pedido(124, c1, productos1);
            Factura factura = new Factura(pedido1);

            Console.Write(factura.ToString());
            Console.ReadKey();

            Console.Write("\n\n\n");

            Cliente c2 = new Cliente("Belgrano 1005", CIva.Monotrivutista, TDocum.DNI, "XX39708319");
            List<Producto> productos2 = new List<Producto>();
            productos2.Add(new Producto("8526", "Cuerdas de Bajo....", 600));
            productos2.Add(new Producto("8527", "Puas de Bajo.......", 100));
            productos2.Add(new Producto("8528", "Afinador de Bajo...", 5000));
            productos2.Add(new Producto("8529", "Bafles de Bajo.....", 15000));

            Pedido pedido2 = new Pedido(125, c2, productos2);
            Factura factura2 = new Factura(pedido2);

            Console.Write(factura2.ToString());
            Console.ReadKey();

            Console.Write("\n\n\n");

            Cliente c3 = new Cliente("Pedro Agrelo 2050", CIva.IVA_No_Responsable, TDocum.CUIT, "285439708319");
            List<Producto> productos3 = new List<Producto>();
            productos3.Add(new Producto("8526", "Cuerdas de Ukelele", 100));
            productos3.Add(new Producto("8527", "Puas de Ukelele....", 30));
            productos3.Add(new Producto("8528", "Afinador de Ukelele", 300));
            productos3.Add(new Producto("8529", "Bafles de Ukelele", 7000));

            Pedido pedido3 = new Pedido(126, c3, productos3);
            Factura factura3 = new Factura(pedido3);

            Console.Write(factura3.ToString());
            Console.ReadKey();


        }
    }
}
