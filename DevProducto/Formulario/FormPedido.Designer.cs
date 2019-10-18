namespace Formulario
{
    partial class FormPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedido));
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.dataGridViewProdPedir = new System.Windows.Forms.DataGridView();
            this.ColumnCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewPrePedido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdPedir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(299, 45);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(101, 31);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "AgregarProducto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(154, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod Productos Pedidos";
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Location = new System.Drawing.Point(219, 316);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(133, 46);
            this.btnConfirmarPedido.TabIndex = 5;
            this.btnConfirmarPedido.Text = "Confirmar Pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            this.btnConfirmarPedido.Click += new System.EventHandler(this.btnConfirmarPedido_Click);
            // 
            // dataGridViewProdPedir
            // 
            this.dataGridViewProdPedir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdPedir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCódigo,
            this.ColumnProducto,
            this.ColumnPrecio});
            this.dataGridViewProdPedir.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewProdPedir.Name = "dataGridViewProdPedir";
            this.dataGridViewProdPedir.Size = new System.Drawing.Size(414, 196);
            this.dataGridViewProdPedir.TabIndex = 6;
            this.dataGridViewProdPedir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdPedir_CellClick);
            // 
            // ColumnCódigo
            // 
            this.ColumnCódigo.HeaderText = "Código";
            this.ColumnCódigo.Name = "ColumnCódigo";
            this.ColumnCódigo.Width = 70;
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            this.ColumnProducto.Width = 200;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // lblTCodigo
            // 
            this.lblTCodigo.AutoSize = true;
            this.lblTCodigo.Location = new System.Drawing.Point(154, 26);
            this.lblTCodigo.Name = "lblTCodigo";
            this.lblTCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblTCodigo.TabIndex = 4;
            this.lblTCodigo.Text = "Codigo";
            this.lblTCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtxtCantidad
            // 
            this.mtxtCantidad.Location = new System.Drawing.Point(234, 54);
            this.mtxtCantidad.Mask = "9999";
            this.mtxtCantidad.Name = "mtxtCantidad";
            this.mtxtCantidad.Size = new System.Drawing.Size(48, 20);
            this.mtxtCantidad.TabIndex = 2;
            this.mtxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewPrePedido
            // 
            this.dataGridViewPrePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewPrePedido.Location = new System.Drawing.Point(432, 98);
            this.dataGridViewPrePedido.Name = "dataGridViewPrePedido";
            this.dataGridViewPrePedido.Size = new System.Drawing.Size(183, 196);
            this.dataGridViewPrePedido.TabIndex = 6;
            this.dataGridViewPrePedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdPedir_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // FormPedido
            // 
            this.AcceptButton = this.btnConfirmarPedido;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 384);
            this.Controls.Add(this.mtxtCantidad);
            this.Controls.Add(this.dataGridViewPrePedido);
            this.Controls.Add(this.dataGridViewProdPedir);
            this.Controls.Add(this.btnConfirmarPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnAgregarProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 401);
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedido";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdPedir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrePedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.DataGridView dataGridViewProdPedir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.Label lblTCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtCantidad;
        private System.Windows.Forms.DataGridView dataGridViewPrePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}