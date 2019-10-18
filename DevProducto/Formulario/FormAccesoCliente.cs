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
        bool registro = false;
        string pathXml = "Datos\\Clientes.Xml";
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
                cargarCLientesXml();
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
            maskTxtDocumento.Text = "";
            maskTxtNCliente.Text = "";
            //this.Hide();
            FormRegistrarse p = new FormRegistrarse();
            p.pasarCliente += new FormRegistrarse.pasar(tomarCliente);
            p.ShowDialog();

        }

        private void tomarCliente(Cliente c)
        {
            listaClientes.Add(c);
            registro = true;
        }

        private void FormAccesoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (registro)
            {
                try
                {
                    xml.Guardar(pathXml, listaClientes);
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void cargarCLientesXml()
        {
            if (File.Exists(pathXml))
            {
                xml.Leer(pathXml, out listaClientes);
                Cliente.nroCliStatic = listaClientes[listaClientes.Count - 1].NroCliente;
            }
        }
    }
}
