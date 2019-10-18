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
using Archivos;
using System.IO;

namespace Formulario
{
    public partial class FormAccesoCliente : Form
    {
        List<Cliente> listaClientes;
        Xml<List<Cliente>> xml;
        public FormAccesoCliente()
        {
            InitializeComponent();
            listaClientes = new List<Cliente>();
            xml = new Xml<List<Cliente>>();
        }

        private void FormAccesoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Datos\\Clientes.Xml"))
                {
                    xml.Leer("Datos\\Clientes.Xml", out listaClientes);
                    Cliente.nroCliStatic = listaClientes.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            bool accede = false;
            try
            {
                foreach (Cliente c in listaClientes)
                {
                    if (c.NroDocu == maskTxtDocumento.Text && c.NroCliente.ToString() == maskTxtNCliente.Text)
                    {
                        accede = true;
                        MessageBox.Show("Accedio Correctamente!");
                        this.Hide();
                        Menu m = new Menu(c);
                        m.ShowDialog();
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (!accede)
            {
                if (maskTxtDocumento.Text == "" || maskTxtNCliente.Text == "")
                {
                    MessageBox.Show("Ingrese los datos");
                }
                else
                {
                    MessageBox.Show("Cliente no registrado!");
                }
            }
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
            listaClientes.Add(c);
        }

        private void FormAccesoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            xml.Guardar("Datos\\Clientes.Xml", listaClientes);
        }
    }
}
