using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public class NotaCredito
    {
        private DateTime fechaEmision;
        private static int nroNotaCredito;
        const int codEmision = 100;
        private Factura factura;
   

        public NotaCredito(Factura factura)
        {
            this.fechaEmision = DateTime.Today;
            NotaCredito.nroNotaCredito++;
            this.factura = factura;
        }

        
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            
            str.AppendFormat("Fecha: {0}\tNro Nota Credito: {1}\tCod Emision: {2}\tLetra: {3}\nCliente: {4}\n",
                fechaEmision.ToShortDateString(), nroNotaCredito, codEmision, factura.Letra, factura.Pedido.Cliente.ToString());

            str.AppendFormat("\n<------------------------------------------------------------------------------------------------->\n");
            str.AppendFormat("<------------------------------------> TOTAL: ${0,10:n2} <---------------------------------------->\n\n",
                factura.Pedido.TotalBrutoPedido + (factura.Pedido.TotalBrutoPedido * factura.Pedido.Cliente.Porc) / 100);


            return str.ToString();
        }

        private string formatoOperatoria()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0}-{1}-{2}-{3}-{4}-${5,10:n2}",
                factura.Pedido.Cliente.NroCliente.ToString(), factura.Pedido.Cliente.TipoDocu.ToString(), factura.Letra, codEmision, 
                fechaEmision.ToShortDateString(), factura.Pedido.TotalBrutoPedido + (factura.Pedido.TotalBrutoPedido * factura.Pedido.Cliente.Porc) / 100);
            
            return str.ToString();
        }

        public void GuardarNota()
        {
            Texto texto = new Texto();

            texto.Guardar("Notas_Credito\\Cliente_" + this.Factura.Pedido.Cliente.NroCliente + ".txt", this.ToString());
        }

        public void GuardarOperatoria()
        {
            Texto texto = new Texto();
            string opString = String.Format("Reportes\\" + fechaEmision.Day + "-" + fechaEmision.Month + "-" + fechaEmision.Year + ".txt");
            texto.Guardar(opString, this.formatoOperatoria());
        }

        public Factura Factura
        {
            get { return factura; }
        }

    }
}

