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
    /// Enumerador para el estado del pedido
    /// </summary>
    public enum Estado { EnCurso, Pendiente, Facturado, Cancelado }
    #endregion

    /// <summary>
    /// Clase Pedido, Serializable
    /// </summary>
    [Serializable]
    public class Pedido
    {
        #region Atributos
        public static int nroPedStatic;
        private int nroPedido;
        private Cliente cliente;
        private List<Producto> detalles;
        private Estado estado;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Pedido() { }

        /// <summary>
        /// Constructor público, con parámetros
        /// </summary>
        public Pedido(Cliente cliente, List<Producto> detalles)
        {
            Pedido.nroPedStatic++;
            this.nroPedido = Pedido.nroPedStatic;
            this.cliente = cliente;
            this.detalles = detalles;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura y escritura para el Estado del pedido.
        /// </summary>
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el Numero del pedido.
        /// </summary>
        public int NroPedido
        {
            get { return nroPedido; }
            set { nroPedido = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para el Cliente del pedido.
        /// </summary>
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        /// <summary>
        /// Propiedad de lectura y escritura para los detalles del pedido (Lista de productos).
        /// </summary>
        public List<Producto> Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }

        /// <summary>
        /// Propiedad de lectura para el total bruto del pedido.
        /// </summary>
        public float TotalBrutoPedido
        {
            get { return calcularBrutoPedido(); }
        }
        #endregion
        
        
        #region Métodos

        /// <summary>
        /// Calcula el bruto total del prdido.
        /// </summary>
        /// <returns>El bruto calculado</returns>
        private float calcularBrutoPedido()
        {
            float bruto = 0;
            foreach (Producto p in this.detalles)
            {
                bruto += p.Precio * p.Cantidad;
            }

            return bruto;
        }

        /// <summary>
        /// Guarda el pedido en un archivo Xml para su posterior uso en una carpeta especifica.
        /// </summary>
        public void GuardarXml()
        {
            Xml<Pedido> guardar = new Xml<Pedido>();
            guardar.Guardar("Datos\\Pedido.Xml", this);
        }

        /// <summary>
        /// Lee el Pedido en un archivo Xml de una carpeta especifica.
        /// </summary>
        public static Pedido LeerXml()
        {
            Pedido pedido;
            Xml<Pedido> leer = new Xml<Pedido>();
            leer.Leer("Datos\\Pedido.Xml", out pedido);

            return pedido;
        } 
        #endregion

    }

    
    
}
