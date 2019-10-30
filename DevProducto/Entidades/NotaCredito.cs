using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    #region Clase
    public class NotaCredito
    {
        #region Atributos
        private DateTime fechaEmision;
        private static int nroNotaCredito;
        const int codEmision = 100;
        private Pedido pedido;
        private Letra letra;
        #endregion


        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private NotaCredito() { }

        /// <summary>
        /// Constructor público con parametros 
        /// </summary>
        public NotaCredito(Pedido pedido)
        {
            this.fechaEmision = DateTime.Today;
            NotaCredito.nroNotaCredito++;
            this.pedido = pedido;
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
            switch (pedido.Cliente.CondIva)
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
        /// <returns>Un obj StrinBuilder con los detalles de la nota de crédito</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Fecha: {0}\tNro Nota Credito: {1}\tCod Emision: {2}\tLetra: {3}\nCliente: {4}\n",
                fechaEmision.ToShortDateString(), nroNotaCredito, codEmision, letra, pedido.Cliente.ToString());

            str.AppendFormat("\n<------------------------------------------------------------------------------------------------->\n");
            str.AppendFormat("<------------------------------------> TOTAL: ${0,10:n2} <---------------------------------------->\n\n",
                pedido.TotalBrutoPedido + (pedido.TotalBrutoPedido * pedido.Cliente.Porc) / 100);


            return str.ToString();
        }

        /// <summary>
        /// Prepara la nota de crédito en formato operatoria.
        /// </summary>
        /// <returns>Un Obj StringBuilder con el formato de operatoria del dia.</returns>
        private string formatoOperatoria()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0}-{1}-{2}-{3}-{4}-${5,10:n2}",
                pedido.Cliente.NroCliente.ToString(), pedido.Cliente.TipoDocu.ToString(), letra, codEmision,
                fechaEmision.ToShortDateString(), pedido.TotalBrutoPedido + (pedido.TotalBrutoPedido * pedido.Cliente.Porc) / 100);

            return str.ToString();
        }

        /// <summary>
        /// Guarda la nota de crédito con su Nro de cliente en un archivo txt en una carpeta especifica.
        /// </summary>
        public void GuardarNota()
        {
            Texto texto = new Texto();

            texto.Guardar("Notas_Credito\\Cliente_" + this.pedido.Cliente.NroCliente + ".txt", this.ToString());
        }

        /// <summary>
        /// Guarda el reporte de la nota de credito en un archivo txt en una carpeta especifica.
        /// </summary>
        public void GuardarOperatoria()
        {
            Texto texto = new Texto();
            string opString = String.Format("Reportes\\" + fechaEmision.Day + "-" + fechaEmision.Month + "-" + fechaEmision.Year + ".txt");
            texto.Guardar(opString, this.formatoOperatoria());
        } 
        #endregion


    }
    #endregion
}

