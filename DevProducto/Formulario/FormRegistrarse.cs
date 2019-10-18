using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class FormRegistrarse : Form
    {
        public delegate void pasar(Cliente c);
        public event pasar pasarCliente;
        public FormRegistrarse()
        {
            InitializeComponent();
        }

        private void FormRegistrarse_Load(object sender, EventArgs e)
        {
            cmbBoxTipoDocumento.DataSource = Enum.GetValues(typeof(TDocum));
            cmbBoxCondIva.DataSource = Enum.GetValues(typeof(CIva));

        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            TDocum TDocumento = TDocum.DNI;
            CIva CondIva = CIva.IVA_Responsable_Inscripto;

            if (cmbBoxTipoDocumento.Text == "CUIT") {
                TDocumento = TDocum.CUIT ;
            }

            if (cmbBoxCondIva.Text == "IVA_No_Responsable") {
                CondIva = CIva.IVA_No_Responsable;
            } else if (cmbBoxCondIva.Text == "Monotrivutista") {
                CondIva = CIva.Monotrivutista;
            }
                         
            Cliente c1 = new Cliente(textBoxDomicilio.Text, CondIva, TDocumento, maskTxtDocuRegistrarse.Text);
            
            MessageBox.Show("N° Cliente: " + c1.NroCliente);
            pasarCliente(c1);
            this.Dispose();

        }
    }
}
