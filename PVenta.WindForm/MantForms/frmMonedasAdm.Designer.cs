namespace PVenta.WindForm.MantForms
{
    partial class frmMonedasAdm
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvMonedas = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(475, 21);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.Enter += new System.EventHandler(this.txtFiltro_Enter);
            this.txtFiltro.Leave += new System.EventHandler(this.txtFiltro_Leave);
            // 
            // dgvMonedas
            // 
            this.dgvMonedas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonedas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDescripcion,
            this.ColValor,
            this.ColInactivo,
            this.ColEditar,
            this.ColEliminar});
            this.dgvMonedas.Location = new System.Drawing.Point(12, 34);
            this.dgvMonedas.Name = "dgvMonedas";
            this.dgvMonedas.RowHeadersVisible = false;
            this.dgvMonedas.Size = new System.Drawing.Size(475, 225);
            this.dgvMonedas.TabIndex = 1;
            this.dgvMonedas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonedas_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.DataPropertyName = "Descripcion";
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 250;
            // 
            // ColValor
            // 
            this.ColValor.DataPropertyName = "valor";
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            this.ColValor.Width = 80;
            // 
            // ColInactivo
            // 
            this.ColInactivo.DataPropertyName = "inactivo";
            this.ColInactivo.HeaderText = "Inactivo";
            this.ColInactivo.Name = "ColInactivo";
            this.ColInactivo.ReadOnly = true;
            this.ColInactivo.Visible = false;
            // 
            // ColEditar
            // 
            this.ColEditar.HeaderText = "Editar";
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.ReadOnly = true;
            this.ColEditar.Text = "Editar...";
            this.ColEditar.UseColumnTextForButtonValue = true;
            this.ColEditar.Width = 70;
            // 
            // ColEliminar
            // 
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Text = "Eliminar...";
            this.ColEliminar.UseColumnTextForButtonValue = true;
            this.ColEliminar.Width = 70;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(412, 265);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmMonedasAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 291);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMonedas);
            this.Controls.Add(this.txtFiltro);
            this.Name = "frmMonedasAdm";
            this.Text = "Monedas";
            this.Load += new System.EventHandler(this.frmMonedasAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvMonedas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColInactivo;
        private System.Windows.Forms.DataGridViewButtonColumn ColEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}