using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TDocum { DNI, CUIT }
    public enum CIva { Monotrivutista, IVA_Responsable_Inscripto, IVA_No_Responsable }

    public class Cliente
    {
        protected static int nroCliente;
        protected string domicilio;
        protected CIva condIva;
        protected TDocum tipoDocu;
        protected string nroDocu;

        public Cliente(string domicilio, CIva condIva, TDocum tipoDocu, string nroDocu)
        {
            Cliente.nroCliente++;
            this.domicilio = domicilio;
            this.condIva = condIva;
            this.tipoDocu = tipoDocu;
            this.nroDocu = nroDocu;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("N° Cliente: {0}\tDomicilio: {1}\t{3}: {4}\nCondicion Impositiva: {2}", NroCliente, Domicilio, CondIva.ToString(), TipoDocu, NroDocu);

            return str.ToString();
        }

        public int NroCliente
        {
            get { return nroCliente; }
        }
        public string Domicilio
        {
            get { return domicilio; }
        }
        public CIva CondIva
        {
            get { return condIva; }
        }
        public TDocum TipoDocu
        {
            get { return tipoDocu; }
        }
        public string NroDocu
        {
            get { return nroDocu; }
        }

    }
}
