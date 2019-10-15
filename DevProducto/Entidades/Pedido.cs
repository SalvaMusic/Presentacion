using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        protected int nroPedido;
        protected Cliente cliente;
        protected List<Producto> detalles;

        public Pedido(int nroPedido, Cliente cliente, List<Producto> detalles)
        {
            this.nroPedido = nroPedido;
            this.cliente = cliente;
            this.detalles = detalles;
        }

        public int NroPedido
        {
            get { return nroPedido; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
        }

        public List<Producto> Detalles
        {
            get { return detalles; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            
            return str.ToString();
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
                bruto += p.Precio;
            }

            return bruto;
        }
    }
}
