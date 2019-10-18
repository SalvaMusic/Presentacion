using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Archivos;

namespace DevProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Estados Unidos 1221", CIva.IVA_Responsable_Inscripto, TDocum.DNI, "39708318");
            List<Producto> productos1 = new List<Producto>();
            productos1.Add(new Producto("2526", "Cuerdas de Guitarra", 150, 10));
            productos1.Add(new Producto("2527", "Puas de Guitarra", 50, 50));
            productos1.Add(new Producto("2528", "Afinador de Guitarra", 500, 10));
            productos1.Add(new Producto("2529", "Bafles de Guitarra", 12000, 5));

            Pedido pedido1 = new Pedido(c1, productos1);
            Factura factura = new Factura(pedido1);

           /* Console.Write(factura.ToString());
            Console.ReadKey();
            
            Console.Write("\n\n\n");*/

            Cliente c2 = new Cliente("Belgrano 1005", CIva.Monotrivutista, TDocum.DNI, "XX39708319");
            List<Producto> productos2 = new List<Producto>();
            productos2.Add(new Producto("8526", "Cuerdas de Bajo....", 600, 8));
            productos2.Add(new Producto("8527", "Puas de Bajo.......", 100, 50));
            productos2.Add(new Producto("8528", "Afinador de Bajo...", 5000, 15));
            productos2.Add(new Producto("8529", "Bafles de Bajo.....", 15000, 8));

            Pedido pedido2 = new Pedido(c2, productos2);
            Factura factura2 = new Factura(pedido2);

            /*Console.Write(factura2.ToString());
            Console.ReadKey();

            Console.Write("\n\n\n");*/

            Cliente c3 = new Cliente("Pedro Agrelo 2050", CIva.IVA_No_Responsable, TDocum.CUIT, "285439708319");
            List<Producto> productos3 = new List<Producto>();
            productos3.Add(new Producto("8526", "Cuerdas de Ukelele", 100, 25));
            productos3.Add(new Producto("8527", "Puas de Ukelele....", 30, 100));
            productos3.Add(new Producto("8528", "Afinador de Ukelele", 300, 9));
            productos3.Add(new Producto("8529", "Bafles de Ukelele", 7000, 12));

            Pedido pedido3 = new Pedido(c3, productos3);
            Factura factura3 = new Factura(pedido3);

            /*Console.Write(factura3.ToString());
            Console.ReadKey();

            Console.Write("\n\n\n");

            Console.Write(factura.ToString());
            Console.ReadKey();

            Console.Write("\n\n\n");*/

            NotaCredito nota = new NotaCredito(factura3);

            List<Factura> listaFac = new List<Factura>();
            listaFac.Add(factura);
            listaFac.Add(factura3);
            listaFac.Add(factura2);
            Xml<List<Factura>> guardar = new Xml<List<Factura>>();
            guardar.Guardar("Datos\\Factura.Xml", listaFac);


            List<Factura> listaFac2 = new List<Factura>();
            Xml<List<Factura>> leer = new Xml<List<Factura>>();
            leer.Leer("Datos\\Factura.Xml", out listaFac2);


            Console.WriteLine("Factura extraida del Xml\n");
            foreach (Factura fac in listaFac2)
            {
                Console.WriteLine(fac.ToString());
                Console.WriteLine("\n");
            }
            /*factura3.GuardarFactura();
            nota.GuardarNota();
            nota.GuardarOperatoria();
            factura.GuardarOperatoria();
            factura3.GuardarOperatoria();*/

            
            Console.ReadKey();




        }
    }
}
