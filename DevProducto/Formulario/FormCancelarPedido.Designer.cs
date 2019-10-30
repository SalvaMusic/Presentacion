namespace Formulario
{
    partial class FormCancelarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelarPedido));
            this.dGVCancPedido = new System.Windows.Forms.DataGridView();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblNroPedido = new System.Windows.Forms.Label();
            this.ColumnCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCancPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVCancPedido
            // 
            this.dGVCancPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCancPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCódigo,
            this.ColumnPrecio,
            this.ColumnEstado});
            this.dGVCancPedido.Location = new System.Drawing.Point(25, 30);
            this.dGVCancPedido.Name = "dGVCancPedido";
            this.dGVCancPedido.Size = new System.Drawing.Size(343, 196);
            this.dGVCancPedido.TabIndex = 10;
            this.dGVCancPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCancPedido_CellClick);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(387, 117);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(129, 53);
            this.btnCancelarPedido.TabIndex = 7;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(426, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 13);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Nro Pedido";
            // 
            // lblNroPedido
            // 
            this.lblNroPedido.AutoSize = true;
            this.lblNroPedido.Location = new System.Drawing.Point(448, 72);
            this.lblNroPedido.Name = "lblNroPedido";
            this.lblNroPedido.Size = new System.Drawing.Size(0, 13);
            this.lblNroPedido.TabIndex = 11;
            this.lblNroPedido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ColumnCódigo
            // 
            this.ColumnCódigo.HeaderText = "Nro Pedido";
            this.ColumnCódigo.Name = "ColumnCódigo";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Total";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            // 
            // FormCancelarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 262);
            this.Controls.Add(this.lblNroPedido);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dGVCancPedido);
            this.Controls.Add(this.btnCancelarPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCancelarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCancelarPedido";
            this.Load += new System.EventHandler(this.FormCancelarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCancPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVCancPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblNroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
    }
}