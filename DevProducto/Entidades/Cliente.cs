using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public enum TDocum { DNI, CUIT }
    public enum CIva { Monotrivutista, IVA_Responsable_Inscripto, IVA_No_Responsable }
    [Serializable]
    public class Cliente
    {
        public static int nroCliStatic;
        private int nroCliente;
        private string domicilio;
        private CIva condIva;
        private TDocum tipoDocu;
        private string nroDocu;

        private Cliente() { }

        public Cliente(string domicilio, CIva condIva, TDocum tipoDocu, string nroDocu)
        {
            this.nroCliente = Cliente.nroCliStatic++;
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

        private float calcularPorcentaje()
        {
            float porc = 70;
            switch (this.CondIva)
            {
                case CIva.IVA_Responsable_Inscripto:
                    porc = (float)10.05;
                    break;
                case CIva.Monotrivutista:
                    porc = 21;
                    break;
            }
            return porc;
        }


        public float Porc
        {
            get { return calcularPorcentaje(); }
        }

        public int NroCliente
        {
            get { return nroCliente; }
            set { nroCliente = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public CIva CondIva
        {
            get { return condIva; }
            set { condIva = value; }
        }
        public TDocum TipoDocu
        {
            get { return tipoDocu; }
            set { tipoDocu = value; }
        }
        public string NroDocu
        {
            get { return nroDocu; }
            set { nroDocu = value; }
        }

    }
}
