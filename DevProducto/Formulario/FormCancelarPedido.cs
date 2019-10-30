using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Archivos;

namespace Formulario
{
    public partial class FormCancelarPedido : Form
    {
        #region Atributos
        List<Pedido> listaPedidos;
        List<Pedido> pedidosCliente;
        Cliente cliente;
        Xml<List<Pedido>> xml;
        string pathPedidosXml = "Datos\\Pedidos.Xml";
        string pathNotaCreditoXml = "Datos\\NotaCredito.Xml";
        bool registro = false;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor, inicializa los atributos.
        /// </summary>
        /// <param name="c">Cliente que va acancelar el pedido</param>
        public FormCancelarPedido(Cliente c)
        {
            InitializeComponent();
            listaPedidos = new List<Pedido>();
            pedidosCliente = new List<Pedido>();
            xml = new Xml<List<Pedido>>();
            cliente = c;
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Carga los pedidos de su base de datos (Xml)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCancelarPedido_Load(object sender, EventArgs e)
        {
            cargarPedidosXml();

            if (pedidosXCliente())
            {
                cargaProductosdGVCancPedido();
            }
            else
            {
                MessageBox.Show("Cliente sin Pedidos");
            }

        }

        /// <summary>
        /// Busca los pedidos del Cliente actual y los carga en una sublista (pedidosCLiente).
        /// </summary>
        /// <returns>true si encontro pedidos del cliente, false si el cliente no tiene pedidos</returns>
        private bool pedidosXCliente()
        {
            bool retorno = false;
            foreach (Pedido p in listaPedidos)
            {
                if (p.Cliente.NroDocu == cliente.NroDocu)
                {
                    pedidosCliente.Add(p);
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Busca pedido de la lista general por nroPedido
        /// </summary>
        /// <param name="nroPedido">Numero de pedido</param>
        /// <returns>Objeto Pedido siu lo encuentra, sino retorna null</returns>
        private Pedido PedidoXNroPedido(int nroPedido)
        {
            foreach (Pedido p in listaPedidos)
            {
                if (p.NroPedido == nroPedido)
                {
                    pedidosCliente.Remove(p);
                    return p;
                }
            }
            return null;
        }

        /// <summary>
        /// Carga los pedidos del cliente en el dGVCancPedido
        /// </summary>
        private void cargaProductosdGVCancPedido()
        {
            float total = 0;
            foreach (Pedido p in pedidosCliente)
            {
                if (p.Estado == Estado.Pendiente)
                {
                    total = p.TotalBrutoPedido;
                }
                else
                {
                    total = p.TotalBrutoPedido + (p.TotalBrutoPedido * p.Cliente.Porc);
                }
                dGVCancPedido.Rows.Add(p.NroPedido, total, p.Estado);
            }
        }

        /// <summary>
        /// Muestra en el lblNroPedido en nroPedido de la celda seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGVCancPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1 && n < pedidosCliente.Count)
            {
                lblNroPedido.Text = dGVCancPedido.Rows[n].Cells[0].Value.ToString();
            }
        }

        /// <summary>
        /// Serializa los pedidos de la lista general (listaPedidos) en XML, si hubo registro.
        /// </summary>
        private void guardarPedidosXml()
        {
            if (registro)
            {
                try
                {
                    xml.Guardar(pathPedidosXml, listaPedidos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Carga los pedidos serializados en XML en una lista general de todos los pedidos
        /// </summary>
        private void cargarPedidosXml()
        {
            if (File.Exists(pathPedidosXml))
            {
                xml.Leer(pathPedidosXml, out listaPedidos);
            }
        }

        /// <summary>
        /// Cancela el pedido seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblNroPedido.Text))
            {
                MessageBox.Show("Seleccione Nro Pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Desea Cancelar el pedido " + lblNroPedido.Text, "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (deleteOrNotaCredito(lblNroPedido.Text))
                {
                    registro = true;
                    guardarPedidosXml();
                    this.Close();
                }

            }
        }

        /// <summary>
        /// Elimina el pedido si está en estado Pendiende, si está en estado Facturado genera una nota de credito
        /// </summary>
        /// <param name="strNroPedido">Nro de Pedido</param>
        /// <returns>true si pudo eliminarse, sino false</returns>
        private bool deleteOrNotaCredito(string strNroPedido)
        {
            Pedido p = PedidoXNroPedido(Convert.ToInt16(strNroPedido));

            if (!(p is null))
            {
                listaPedidos.Remove(p);
                pedidosCliente.Remove(p);
                switch (p.Estado)
                {
                    case Estado.Pendiente:
                        MessageBox.Show("Pedido Nro: " + strNroPedido + " ELIMINADO");
                        break;
                    case Estado.Facturado:
                        GeneraNotaCredito(p);
                        p.Estado = Estado.Cancelado;
                        MessageBox.Show("Nota de Credito generada");
                        break;
                }
                return true;
            }
            else
            {
                MessageBox.Show("No se encontro el pedido Pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }

        /// <summary>
        /// Genera una nota de credito en base a un pedido.
        /// </summary>
        /// <param name="p">pedido</param>
        private void GeneraNotaCredito(Pedido p)
        {
            try
            {
                NotaCredito notaCredito = new NotaCredito(p);
                notaCredito.GuardarNota();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion
    } 
    
}
