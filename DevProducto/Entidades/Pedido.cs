using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    [Serializable]
    public class Pedido
    {
        public static int nroPedStatic;
        private int nroPedido;
        private Cliente cliente;
        private List<Producto> detalles;
        private Estado estado;

        public Pedido() { }

        public Pedido(Cliente cliente, List<Producto> detalles)
        {
            this.nroPedido = Pedido.nroPedStatic++;
            this.cliente = cliente;
            this.detalles = detalles;
        }

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int NroPedido
        {
            get { return nroPedido; }
            set { nroPedido = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public List<Producto> Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }

       
        
        public float TotalBrutoPedido
        {
            get { return calcularBrutoPedido(); }
        }     
        
        private float calcularBrutoPedido()
        {
            float bruto = 0;
            foreach(Producto p in this.detalles)
            {
                bruto += p.Precio  * p.Cantidad;
            }

            return bruto;
        }

        public void GuardarXml()
        {
            Xml<Pedido> guardar = new Xml<Pedido>();
            guardar.Guardar("Datos\\Pedido.Xml", this);
        }

        public static Pedido LeerXml()
        {
            Pedido pedido;
            Xml<Pedido> leer = new Xml<Pedido>();
            leer.Leer("Datos\\Pedido.Xml", out pedido);

            return pedido;
        }

    }

    public enum Estado {EnCurso , Pendiente, Facturado }
}
