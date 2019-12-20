namespace PVenta.WindForm.MantForms
{
    partial class frmFormaPagos
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblAceptaCambio = new System.Windows.Forms.Label();
            this.chkAceptaCambio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(24, 28);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 20);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 21);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(271, 74);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblAceptaCambio
            // 
            this.lblAceptaCambio.AutoSize = true;
            this.lblAceptaCambio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceptaCambio.Location = new System.Drawing.Point(24, 65);
            this.lblAceptaCambio.Name = "lblAceptaCambio";
            this.lblAceptaCambio.Size = new System.Drawing.Size(104, 13);
            this.lblAceptaCambio.TabIndex = 3;
            this.lblAceptaCambio.Text = "Acepta Cambio";
            // 
            // chkAceptaCambio
            // 
            this.chkAceptaCambio.AutoSize = true;
            this.chkAceptaCambio.Location = new System.Drawing.Point(147, 61);
            this.chkAceptaCambio.Name = "chkAceptaCambio";
            this.chkAceptaCambio.Size = new System.Drawing.Size(15, 14);
            this.chkAceptaCambio.TabIndex = 4;
            this.chkAceptaCambio.UseVisualStyleBackColor = true;
            // 
            // frmFormaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 112);
            this.Controls.Add(this.chkAceptaCambio);
            this.Controls.Add(this.lblAceptaCambio);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmFormaPagos";
            this.Text = "Forma Pagos";
            this.Load += new System.EventHandler(this.frmFormaPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblAceptaCambio;
        private System.Windows.Forms.CheckBox chkAceptaCambio;
    }
}