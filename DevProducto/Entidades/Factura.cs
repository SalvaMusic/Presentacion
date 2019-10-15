using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    enum Letra { A, B, X }
    enum Estado { Pendiente, Facturado }
    public class Factura
    {
        private DateTime fechaEmision;
        private static int nroFactura;
        const int codEmision = 211;
        private Letra letra;
        private Pedido detalles;
        private Estado estado;

        private Factura()
        {
            //this.detalles = new List<Pedido>();
        }

        public Factura(Pedido detalles) // : this()
        {
            this.detalles = detalles;
            this.fechaEmision = DateTime.Today;
            Factura.nroFactura++;
            this.letra = asignaLetra();

        }

        private Letra asignaLetra()
        {
            Letra retorno = Letra.B;
            switch(detalles.Cliente.CondIva)
            {
                case CIva.IVA_No_Responsable:
                    retorno = Letra.X;
                    break;
                case CIva.IVA_Responsable_Inscripto:
                    retorno = Letra.A;
                    break;
            }
            return retorno;
        }
        

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            float porc = 70, mIvaProducto = 0, mIvatotal =0, pNetoProducto = 0, pNetoTotal = 0, pVentaProducto = 0, pVentaTotal = 0; 
            int cantidad = 1;
            str.AppendFormat("Fecha: {0}\tNro Factura: {1}\tCod Emision: {2}\tLetra: {3}\nCliente: {4}\n",
                fechaEmision.ToShortDateString(), nroFactura, codEmision, letra, detalles.Cliente.ToString());
            str.AppendFormat("Nro Pedido: {0}", detalles.NroPedido);
            str.AppendFormat("\n<------------------------------------------------------------------------------------------------->\n");
            str.AppendFormat("{0,6}\t{1,20}\t{2,10} {3,6}  {4}\t {5,10}\t {6,10}\t {7,10}\n",
                "CODIGO", "NOMBRE", "PRECIO", "%IVA", "CANT", "PRE VENTA","PRE NETO", "MONTO IVA");

            switch (detalles.Cliente.CondIva)
            {
                case CIva.IVA_Responsable_Inscripto:
                    porc = (float)10.05;
                    break;
                case CIva.Monotrivutista:
                    porc = 21;
                    break;
            }

            foreach (Producto producto in this.detalles.Detalles)
            {

                mIvaProducto = producto.Precio * (porc / 100);
                pNetoProducto = producto.Precio * cantidad;
                pVentaProducto = pNetoProducto + mIvaProducto;
                mIvatotal += mIvaProducto;
                pNetoTotal += pNetoProducto;
                pVentaTotal += pVentaProducto;
                str.AppendFormat("\n{0}{1,6}{2,3}\t${3,10:n2}\t${4,10:n2}\t${5,10:n2}", producto.ToString(), porc, cantidad, pVentaProducto, pNetoProducto, mIvaProducto);
            }
            
            str.AppendFormat("\n<------------------------------------------------------------------------------------------------->\n");
            str.AppendFormat("<------------------------> TOTAL: ${0,10:n2} <----------------------------> TOTAL IVA: ${1,10:n2}", 
               pNetoTotal, pVentaTotal);


            return str.ToString();
        }

        

        
    }
}
