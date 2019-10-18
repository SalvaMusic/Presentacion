namespace Formulario
{
    partial class FormAccesoCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccesoCliente));
            this.labelNroCliente = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.maskTxtNCliente = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNroCliente
            // 
            this.labelNroCliente.AutoSize = true;
            this.labelNroCliente.Location = new System.Drawing.Point(74, 58);
            this.labelNroCliente.Name = "labelNroCliente";
            this.labelNroCliente.Size = new System.Drawing.Size(54, 13);
            this.labelNroCliente.TabIndex = 0;
            this.labelNroCliente.Text = "N° Cliente";
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(74, 96);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(62, 13);
            this.labelDocumento.TabIndex = 0;
            this.labelDocumento.Text = "Documento";
            // 
            // maskTxtNCliente
            // 
            this.maskTxtNCliente.Location = new System.Drawing.Point(147, 56);
            this.maskTxtNCliente.Name = "maskTxtNCliente";
            this.maskTxtNCliente.Size = new System.Drawing.Size(127, 20);
            this.maskTxtNCliente.TabIndex = 0;
            // 
            // maskTxtDocumento
            // 
            this.maskTxtDocumento.Location = new System.Drawing.Point(147, 92);
            this.maskTxtDocumento.Name = "maskTxtDocumento";
            this.maskTxtDocumento.Size = new System.Drawing.Size(127, 20);
            this.maskTxtDocumento.TabIndex = 1;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(184, 131);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 2;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Location = new System.Drawing.Point(86, 131);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrarse.TabIndex = 3;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // FormAccesoCliente
            // 
            this.AcceptButton = this.buttonIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(362, 203);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.maskTxtDocumento);
            this.Controls.Add(this.maskTxtNCliente);
            this.Controls.Add(this.labelDocumento);
            this.Controls.Add(this.labelNroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 242);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(378, 242);
            this.Name = "FormAccesoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceco Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAccesoCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormAccesoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNroCliente;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.MaskedTextBox maskTxtNCliente;
        private System.Windows.Forms.MaskedTextBox maskTxtDocumento;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonRegistrarse;
    }
}

