namespace Ejemplo___Laboratorio
{
    partial class FormularioEjemplo
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
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.cbEjemplo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(386, 50);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(75, 23);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(23, 55);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.TextChanged += new System.EventHandler(this.lblSaludo_TextChanged);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(23, 124);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 13);
            this.lblCambio.TabIndex = 2;
            // 
            // cbEjemplo
            // 
            this.cbEjemplo.FormattingEnabled = true;
            this.cbEjemplo.Items.AddRange(new object[] {
            "DSP404",
            "SES404",
            "DAW404"});
            this.cbEjemplo.Location = new System.Drawing.Point(340, 116);
            this.cbEjemplo.Name = "cbEjemplo";
            this.cbEjemplo.Size = new System.Drawing.Size(121, 21);
            this.cbEjemplo.TabIndex = 3;
            this.cbEjemplo.SelectedIndexChanged += new System.EventHandler(this.cbEjemplo_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 182);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(53, 227);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 13);
            this.lblTexto.TabIndex = 5;
            // 
            // FormularioEjemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 334);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbEjemplo);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnSaludo);
            this.Name = "FormularioEjemplo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioEjemplo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.ComboBox cbEjemplo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTexto;
    }
}

