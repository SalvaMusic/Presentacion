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
        #region Atributos
        List<Cliente> listaClientes;
        Xml<List<Cliente>> xml;
        string pathXml = "Datos\\Clientes.Xml";
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor, inicializa los atributos.
        /// </summary>
        public FormAccesoCliente()
        {
            InitializeComponent();
            listaClientes = new List<Cliente>();
            xml = new Xml<List<Cliente>>();
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Carga los clietes de su base de datos (Xml)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Evento click, Permite acceder a un cliente, comprobando su existencia en la base de datos (Xml).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        this.Close();
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

        /// <summary>
        /// Evento registrarse, abre un nuevo form para registrar un nuevo cliente.
        /// </summary>
        /// <param name="c"></param>
        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            maskTxtDocumento.Text = "";
            maskTxtNCliente.Text = "";
            //this.Hide();
            FormRegistrarse p = new FormRegistrarse();
            p.pasarCliente += new FormRegistrarse.pasar(tomarCliente);
            p.ShowDialog();

        }

        /// <summary>
        /// Toma un cliente del form 'registrarse', lo agrega a la lista de clientes y lo guarda en un Xml. 
        /// </summary>
        private void tomarCliente(Cliente c)
        {
            listaClientes.Add(c);
            guardarXml();
        }

        /// <summary>
        /// Guarda la lista de clientes en un Xml.
        /// </summary>
        private void guardarXml()
        {
            try
            {
                xml.Guardar(pathXml, listaClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga los clientes previamente serializados en el Xml y los agrega a la lista de clientes.
        /// </summary>
        private void cargarCLientesXml()
        {
            if (File.Exists(pathXml))
            {
                xml.Leer(pathXml, out listaClientes);
                if (listaClientes.Count > 0)
                {
                    Cliente.nroCliStatic = listaClientes[listaClientes.Count - 1].NroCliente;
                }

            }
        } 
        #endregion
    }
}
