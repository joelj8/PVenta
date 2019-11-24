namespace PVenta.WindForm.MantForms
{
    partial class frmCategorias
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
            this.chkImpComanda = new System.Windows.Forms.CheckBox();
            this.lblImpComanda = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 25);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(140, 17);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(234, 21);
            this.txtDescripcion.TabIndex = 1;
            // 
            // chkImpComanda
            // 
            this.chkImpComanda.AutoSize = true;
            this.chkImpComanda.Location = new System.Drawing.Point(140, 58);
            this.chkImpComanda.Name = "chkImpComanda";
            this.chkImpComanda.Size = new System.Drawing.Size(15, 14);
            this.chkImpComanda.TabIndex = 2;
            this.chkImpComanda.UseVisualStyleBackColor = true;
            // 
            // lblImpComanda
            // 
            this.lblImpComanda.AutoSize = true;
            this.lblImpComanda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpComanda.Location = new System.Drawing.Point(9, 58);
            this.lblImpComanda.Name = "lblImpComanda";
            this.lblImpComanda.Size = new System.Drawing.Size(129, 13);
            this.lblImpComanda.TabIndex = 3;
            this.lblImpComanda.Text = "Imprimir Comanda";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(299, 77);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 112);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblImpComanda);
            this.Controls.Add(this.chkImpComanda);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkImpComanda;
        private System.Windows.Forms.Label lblImpComanda;
        private System.Windows.Forms.Button btnGrabar;
    }
}