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
    public partial class FormAccesoCliente : Form
    {
        List<Cliente> listaCLientes;
        public FormAccesoCliente()
        {
            InitializeComponent();
            listaCLientes = new List<Cliente>();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            
            bool accede = false;
            try
            {
                foreach(Cliente c in listaCLientes)
                {
                    if (c.NroDocu == maskTxtDocumento.Text && c.NroCliente.ToString() == maskTxtNCliente.Text)
                    {
                        accede = true;
                        MessageBox.Show("Accedio Correctamente!");
                        break;
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (accede)
            {
                this.Hide();
                FormPedido p = new FormPedido();
                p.ShowDialog();
            }else if (maskTxtDocumento.Text == "" || maskTxtNCliente.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }else
            {
                MessageBox.Show("Cliente no registrado!");
            }
        }

        private void FormAccesoCliente_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
                      
            //this.Hide();
            FormRegistrarse p = new FormRegistrarse();
            p.pasarCliente += new FormRegistrarse.pasar(tomarCliente);
            p.ShowDialog();
            
        }

        private void tomarCliente(Cliente c)
        {
            listaCLientes.Add(c);
        }

        
    }
}
