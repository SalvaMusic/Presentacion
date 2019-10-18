namespace Formulario
{
    partial class FormRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarse));
            this.labelTDocumento = new System.Windows.Forms.Label();
            this.labelNDocumento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.maskTxtDocuRegistrarse = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxCondIva = new System.Windows.Forms.ComboBox();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTDocumento
            // 
            this.labelTDocumento.AutoSize = true;
            this.labelTDocumento.Location = new System.Drawing.Point(68, 66);
            this.labelTDocumento.Name = "labelTDocumento";
            this.labelTDocumento.Size = new System.Drawing.Size(86, 13);
            this.labelTDocumento.TabIndex = 0;
            this.labelTDocumento.Text = "Tipo Documento";
            this.labelTDocumento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNDocumento
            // 
            this.labelNDocumento.AutoSize = true;
            this.labelNDocumento.Location = new System.Drawing.Point(68, 97);
            this.labelNDocumento.Name = "labelNDocumento";
            this.labelNDocumento.Size = new System.Drawing.Size(77, 13);
            this.labelNDocumento.TabIndex = 0;
            this.labelNDocumento.Text = "N° Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condición impositiva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Domicilio";
            // 
            // cmbBoxTipoDocumento
            // 
            this.cmbBoxTipoDocumento.FormattingEnabled = true;
            this.cmbBoxTipoDocumento.Location = new System.Drawing.Point(191, 63);
            this.cmbBoxTipoDocumento.Name = "cmbBoxTipoDocumento";
            this.cmbBoxTipoDocumento.Size = new System.Drawing.Size(159, 21);
            this.cmbBoxTipoDocumento.TabIndex = 1;
            // 
            // maskTxtDocuRegistrarse
            // 
            this.maskTxtDocuRegistrarse.Location = new System.Drawing.Point(191, 94);
            this.maskTxtDocuRegistrarse.Name = "maskTxtDocuRegistrarse";
            this.maskTxtDocuRegistrarse.Size = new System.Drawing.Size(159, 20);
            this.maskTxtDocuRegistrarse.TabIndex = 2;
            // 
            // cmbBoxCondIva
            // 
            this.cmbBoxCondIva.FormattingEnabled = true;
            this.cmbBoxCondIva.Location = new System.Drawing.Point(191, 122);
            this.cmbBoxCondIva.Name = "cmbBoxCondIva";
            this.cmbBoxCondIva.Size = new System.Drawing.Size(159, 21);
            this.cmbBoxCondIva.TabIndex = 3;
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Location = new System.Drawing.Point(191, 150);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(159, 20);
            this.textBoxDomicilio.TabIndex = 4;
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Location = new System.Drawing.Point(142, 187);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(120, 33);
            this.buttonRegistrarse.TabIndex = 5;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // FormRegistrarse
            // 
            this.AcceptButton = this.buttonRegistrarse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 246);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.cmbBoxCondIva);
            this.Controls.Add(this.maskTxtDocuRegistrarse);
            this.Controls.Add(this.cmbBoxTipoDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNDocumento);
            this.Controls.Add(this.labelTDocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(441, 285);
            this.Name = "FormRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.FormRegistrarse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTDocumento;
        private System.Windows.Forms.Label labelNDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxTipoDocumento;
        private System.Windows.Forms.MaskedTextBox maskTxtDocuRegistrarse;
        private System.Windows.Forms.ComboBox cmbBoxCondIva;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.Button buttonRegistrarse;
    }
}