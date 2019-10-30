namespace Formulario
{
    partial class Menu
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
            this.lblClientea = new System.Windows.Forms.Label();
            this.btnCancelarPedidoMenu = new System.Windows.Forms.Button();
            this.btnCrearPedidoMenu = new System.Windows.Forms.Button();
            this.lblClienteb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClientea
            // 
            this.lblClientea.AutoSize = true;
            this.lblClientea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientea.Location = new System.Drawing.Point(87, 43);
            this.lblClientea.Name = "lblClientea";
            this.lblClientea.Size = new System.Drawing.Size(0, 18);
            this.lblClientea.TabIndex = 0;
            // 
            // btnCancelarPedidoMenu
            // 
            this.btnCancelarPedidoMenu.Location = new System.Drawing.Point(81, 112);
            this.btnCancelarPedidoMenu.Name = "btnCancelarPedidoMenu";
            this.btnCancelarPedidoMenu.Size = new System.Drawing.Size(124, 44);
            this.btnCancelarPedidoMenu.TabIndex = 2;
            this.btnCancelarPedidoMenu.Text = "Cancelar Pedido";
            this.btnCancelarPedidoMenu.UseVisualStyleBackColor = true;
            this.btnCancelarPedidoMenu.Click += new System.EventHandler(this.btnCancelarPedidoMenu_Click);
            // 
            // btnCrearPedidoMenu
            // 
            this.btnCrearPedidoMenu.Location = new System.Drawing.Point(249, 112);
            this.btnCrearPedidoMenu.Name = "btnCrearPedidoMenu";
            this.btnCrearPedidoMenu.Size = new System.Drawing.Size(131, 44);
            this.btnCrearPedidoMenu.TabIndex = 2;
            this.btnCrearPedidoMenu.Text = "Crear Pedido";
            this.btnCrearPedidoMenu.UseVisualStyleBackColor = true;
            this.btnCrearPedidoMenu.Click += new System.EventHandler(this.btnCrearPedidoMenu_Click);
            // 
            // lblClienteb
            // 
            this.lblClienteb.AutoSize = true;
            this.lblClienteb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteb.Location = new System.Drawing.Point(254, 43);
            this.lblClienteb.Name = "lblClienteb";
            this.lblClienteb.Size = new System.Drawing.Size(0, 18);
            this.lblClienteb.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 224);
            this.Controls.Add(this.btnCrearPedidoMenu);
            this.Controls.Add(this.btnCancelarPedidoMenu);
            this.Controls.Add(this.lblClienteb);
            this.Controls.Add(this.lblClientea);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientea;
        private System.Windows.Forms.Button btnCancelarPedidoMenu;
        private System.Windows.Forms.Button btnCrearPedidoMenu;
        private System.Windows.Forms.Label lblClienteb;
    }
}