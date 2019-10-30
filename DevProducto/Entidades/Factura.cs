using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    #region Enumeradores
    /// <summary>
    /// Enumerador para Letra de factura
    /// </summary>
    public enum Letra { A, B, X } 
    #endregion


    /// <summary>
    /// Clase Factura, Serializable.
    /// </summary>
    [Serializable]
    public class Factura
    {
        #region Atributos
        private DateTime fechaEmision;
        private static int nroFacStatic;
        private int nroFactura;
        const int codEmision = 211;
        private Letra letra;
        private Pedido detalles;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor Privado por defecto.
        /// </summary>
        private Factura() { }


        /// <summary>
        /// Constructor Público con parametros.
        /// </summary>
        /// <param name="detalles">Objeto de tipo Pedido a ser asignado</param>
        public Factura(Pedido detalles)
        {
            Factura.nroFacStatic++;
            this.detalles = detalles;
            this.fechaEmision = DateTime.Today;
            this.nroFactura = Factura.nroFacStatic;
            this.letra = asignaLetra();
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Asigna letra de factura segun condicion impositiva.
        /// </summary>
        /// <returns>Letra a ser asignada</returns>
        private Letra asignaLetra()
        {
            Letra retorno = Letra.B;
            switch (detalles.Cliente.CondIva)
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

        /// <summary>
        /// Override de método ToString.
        /// </summary>
        /// <returns>Un obj StrinBuilder con los detalles de la factura</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Fecha: {0}\tNro Factura: {1}\t\tCod Emision: {2}\tLetra: {3}\n{4}\n",
                fechaEmision.ToShortDateString(), nroFactura, codEmision, letra, detalles.Cliente.ToString());
            str.AppendFormat("Nro Pedido: {0}", detalles.NroPedido);
            str.AppendFormat("\n<------------------------------------------------------------------------------------------------->\n");

            str.AppendLine(this.detallesString());
            str.AppendFormat("\n<------------------------------------------------------------------------------------------------->\n");
            str.AppendFormat("<------------------------> TOTAL: ${0,10:n2} <----------------------------> TOTAL IVA: ${1,10:n2}\n\n",
               detalles.TotalBrutoPedido, detalles.TotalBrutoPedido + (detalles.TotalBrutoPedido * detalles.Cliente.Porc) / 100);


            return str.ToString();
        }

        /// <summary>
        /// Método que detalla los datos de los productos.
        /// </summary>
        /// <returns>Un obj StrinBuilder con los detalles del pedido</returns>
        private string detallesString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0,6}\t{1,20}\t{2,10} {3,6}  {4}\t {5,10}\t {6,10}\t {7,10}\n",
                "CODIGO", "NOMBRE", "PRECIO", "CANT", "%IVA", "PRE VENTA", "PRE NETO", "MONTO IVA");
            float mIvaProducto = 0, pNetoProducto = 0, pVentaProducto = 0;

            foreach (Producto producto in this.detalles.Detalles)
            {
                mIvaProducto = (producto.Precio * detalles.Cliente.Porc) / 100;
                pNetoProducto = producto.Precio * producto.Cantidad;
                pVentaProducto = pNetoProducto + (mIvaProducto * producto.Cantidad);
                str.AppendFormat("\n{0}{1,6}\t${2,10:n2}\t${3,10:n2}\t${4,10:n2}",
                    producto.ToString(), detalles.Cliente.Porc, pVentaProducto, pNetoProducto, mIvaProducto);
            }

            return str.ToString();
        }

        /// <summary>
        /// Guarda la factura con su Nro de cliente en un archivo txt en una carpeta especifica.
        /// </summary>
        public void GuardarFactura()
        {
            Texto texto = new Texto();

            texto.Guardar("Facturas\\Cliente_" + this.Pedido.Cliente.NroCliente + ".txt", this.ToString());
        }

        /// <summary>
        /// Guarda el reporte de la factura en un archivo txt en una carpeta especifica.
        /// </summary>
        public void GuardarOperatoria()
        {
            Texto texto = new Texto();
            string opString = String.Format("Reportes\\" + fechaEmision.Day + "-" + fechaEmision.Month + "-" + fechaEmision.Year + ".txt");
            texto.Guardar(opString, this.formatoOperatoria());
        }
        
        /// <summary>
        /// Guarda la factura en un archivo Xml para su posterior uso en una carpeta especifica.
        /// </summary>
        public void GuardarXml()
        {
            Xml<Factura> guardar = new Xml<Factura>();
            guardar.Guardar("Datos\\Factura.Xml", this);
        }

        /// <summary>
        /// Lee la factura en un archivo Xml de una carpeta especifica.
        /// </summary>
        public static Factura LeerXml()
        {
            Factura factura = new Factura();
            Xml<Factura> leer = new Xml<Factura>();
            leer.Leer("Datos\\Factura.Xml", out factura);

            return factura;
        }


        /// <summary>
        /// Prepara la factura en formato operatoria.
        /// </summary>
        /// <returns>Un Obj StringBuilder con el formato de operatoria del dia.</returns>
        private string formatoOperatoria()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0}-{1}-{2}-{3}-{4}-${5,10:n2}",
                detalles.Cliente.NroCliente.ToString(), detalles.Cliente.TipoDocu.ToString(), Letra, codEmision,
                fechaEmision.ToShortDateString(), detalles.TotalBrutoPedido + (detalles.TotalBrutoPedido * detalles.Cliente.Porc) / 100);

            return str.ToString();
        }
        #endregion


        #region Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura para el pedido.
        /// </summary>
        public Pedido Pedido
        {
            get { return detalles; }
            set { detalles = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la fecha de emision.
        /// </summary>
        public DateTime FechaEmision
        {
            get { return fechaEmision; }
            set { fechaEmision = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el Numero de factura.
        /// </summary>
        public int NroFactura
        {
            get { return nroFactura; }
            set { nroFactura = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para la letra de la factura
        /// </summary>
        public Letra Letra
        {
            get { return letra; }
            set { letra = value; }
        }

        #endregion


    }
}
