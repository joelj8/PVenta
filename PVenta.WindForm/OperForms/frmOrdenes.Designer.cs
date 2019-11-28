namespace PVenta.WindForm.OperForms
{
    partial class frmOrdenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.numDescPorc = new System.Windows.Forms.NumericUpDown();
            this.numDescMonto = new System.Windows.Forms.NumericUpDown();
            this.chkITBIS = new System.Windows.Forms.CheckBox();
            this.txtClientePrincipal = new System.Windows.Forms.TextBox();
            this.cboMesa = new System.Windows.Forms.ComboBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblPorcDesc = new System.Windows.Forms.Label();
            this.lblMontDesc = new System.Windows.Forms.Label();
            this.lblClientePrincipal = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImpComanda = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColClientePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImpreso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDividir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDescPorc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescMonto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGeneral.Controls.Add(this.btnGrabar);
            this.pnlGeneral.Controls.Add(this.numDescPorc);
            this.pnlGeneral.Controls.Add(this.numDescMonto);
            this.pnlGeneral.Controls.Add(this.chkITBIS);
            this.pnlGeneral.Controls.Add(this.txtClientePrincipal);
            this.pnlGeneral.Controls.Add(this.cboMesa);
            this.pnlGeneral.Controls.Add(this.cboUsuario);
            this.pnlGeneral.Controls.Add(this.txtFecha);
            this.pnlGeneral.Controls.Add(this.lblPorcDesc);
            this.pnlGeneral.Controls.Add(this.lblMontDesc);
            this.pnlGeneral.Controls.Add(this.lblClientePrincipal);
            this.pnlGeneral.Controls.Add(this.lblMesa);
            this.pnlGeneral.Controls.Add(this.lblUsuario);
            this.pnlGeneral.Controls.Add(this.lblFecha);
            this.pnlGeneral.Location = new System.Drawing.Point(12, 12);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(817, 100);
            this.pnlGeneral.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGrabar.Location = new System.Drawing.Point(701, 0);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(109, 98);
            this.btnGrabar.TabIndex = 19;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // numDescPorc
            // 
            this.numDescPorc.DecimalPlaces = 2;
            this.numDescPorc.Location = new System.Drawing.Point(624, 29);
            this.numDescPorc.Name = "numDescPorc";
            this.numDescPorc.Size = new System.Drawing.Size(64, 21);
            this.numDescPorc.TabIndex = 7;
            // 
            // numDescMonto
            // 
            this.numDescMonto.DecimalPlaces = 2;
            this.numDescMonto.Location = new System.Drawing.Point(501, 29);
            this.numDescMonto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDescMonto.Name = "numDescMonto";
            this.numDescMonto.Size = new System.Drawing.Size(86, 21);
            this.numDescMonto.TabIndex = 6;
            // 
            // chkITBIS
            // 
            this.chkITBIS.AutoSize = true;
            this.chkITBIS.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkITBIS.Location = new System.Drawing.Point(628, 64);
            this.chkITBIS.Name = "chkITBIS";
            this.chkITBIS.Size = new System.Drawing.Size(60, 20);
            this.chkITBIS.TabIndex = 8;
            this.chkITBIS.Text = "Itbis";
            this.chkITBIS.UseVisualStyleBackColor = true;
            // 
            // txtClientePrincipal
            // 
            this.txtClientePrincipal.Location = new System.Drawing.Point(295, 64);
            this.txtClientePrincipal.Name = "txtClientePrincipal";
            this.txtClientePrincipal.Size = new System.Drawing.Size(294, 21);
            this.txtClientePrincipal.TabIndex = 5;
            // 
            // cboMesa
            // 
            this.cboMesa.FormattingEnabled = true;
            this.cboMesa.Location = new System.Drawing.Point(295, 29);
            this.cboMesa.Name = "cboMesa";
            this.cboMesa.Size = new System.Drawing.Size(96, 21);
            this.cboMesa.TabIndex = 4;
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.Enabled = false;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(71, 64);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(154, 21);
            this.cboUsuario.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(71, 29);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(154, 21);
            this.txtFecha.TabIndex = 2;
            // 
            // lblPorcDesc
            // 
            this.lblPorcDesc.AutoSize = true;
            this.lblPorcDesc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcDesc.Location = new System.Drawing.Point(599, 32);
            this.lblPorcDesc.Name = "lblPorcDesc";
            this.lblPorcDesc.Size = new System.Drawing.Size(25, 16);
            this.lblPorcDesc.TabIndex = 18;
            this.lblPorcDesc.Text = "%";
            // 
            // lblMontDesc
            // 
            this.lblMontDesc.AutoSize = true;
            this.lblMontDesc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontDesc.Location = new System.Drawing.Point(403, 34);
            this.lblMontDesc.Name = "lblMontDesc";
            this.lblMontDesc.Size = new System.Drawing.Size(98, 16);
            this.lblMontDesc.TabIndex = 17;
            this.lblMontDesc.Text = "Descuento $";
            // 
            // lblClientePrincipal
            // 
            this.lblClientePrincipal.AutoSize = true;
            this.lblClientePrincipal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientePrincipal.Location = new System.Drawing.Point(234, 69);
            this.lblClientePrincipal.Name = "lblClientePrincipal";
            this.lblClientePrincipal.Size = new System.Drawing.Size(59, 16);
            this.lblClientePrincipal.TabIndex = 16;
            this.lblClientePrincipal.Text = "Cliente";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(234, 34);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(46, 16);
            this.lblMesa.TabIndex = 15;
            this.lblMesa.Text = "Mesa";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(8, 69);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 16);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(8, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 16);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.numTotal);
            this.panel1.Controls.Add(this.numPrecio);
            this.panel1.Controls.Add(this.numCant);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 33);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(762, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // numTotal
            // 
            this.numTotal.DecimalPlaces = 2;
            this.numTotal.Location = new System.Drawing.Point(637, 5);
            this.numTotal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTotal.Name = "numTotal";
            this.numTotal.ReadOnly = true;
            this.numTotal.Size = new System.Drawing.Size(117, 21);
            this.numTotal.TabIndex = 4;
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(532, 5);
            this.numPrecio.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.ReadOnly = true;
            this.numPrecio.Size = new System.Drawing.Size(98, 21);
            this.numPrecio.TabIndex = 3;
            // 
            // numCant
            // 
            this.numCant.Location = new System.Drawing.Point(449, 5);
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(77, 21);
            this.numCant.TabIndex = 2;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(163, 5);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(283, 21);
            this.txtProducto.TabIndex = 1;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(81, 5);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(77, 21);
            this.txtReferencia.TabIndex = 0;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColProducto,
            this.ColReferencia,
            this.ColCant,
            this.ColPrecio,
            this.ColTotal,
            this.ColImpComanda,
            this.ColClientePedido,
            this.ColImpreso,
            this.ColOrden,
            this.ColAgregar,
            this.ColDividir});
            this.dgvOrderDetail.Location = new System.Drawing.Point(12, 157);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersVisible = false;
            this.dgvOrderDetail.Size = new System.Drawing.Size(817, 281);
            this.dgvOrderDetail.TabIndex = 15;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColProducto
            // 
            this.ColProducto.DataPropertyName = "Producto";
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 270;
            // 
            // ColReferencia
            // 
            this.ColReferencia.HeaderText = "Referencia";
            this.ColReferencia.Name = "ColReferencia";
            this.ColReferencia.ReadOnly = true;
            // 
            // ColCant
            // 
            this.ColCant.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.ColCant.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColCant.HeaderText = "Cantidad";
            this.ColCant.Name = "ColCant";
            this.ColCant.ReadOnly = true;
            this.ColCant.Width = 90;
            // 
            // ColPrecio
            // 
            this.ColPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.ColPrecio.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "Total";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.ColTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            // 
            // ColImpComanda
            // 
            this.ColImpComanda.DataPropertyName = "impComanda";
            this.ColImpComanda.HeaderText = "Comanda";
            this.ColImpComanda.Name = "ColImpComanda";
            this.ColImpComanda.ReadOnly = true;
            this.ColImpComanda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColImpComanda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColImpComanda.Visible = false;
            // 
            // ColClientePedido
            // 
            this.ColClientePedido.DataPropertyName = "ClientePedido";
            this.ColClientePedido.HeaderText = "Cliente Pedido";
            this.ColClientePedido.Name = "ColClientePedido";
            this.ColClientePedido.ReadOnly = true;
            this.ColClientePedido.Visible = false;
            // 
            // ColImpreso
            // 
            this.ColImpreso.DataPropertyName = "Impreso";
            this.ColImpreso.HeaderText = "Impreso";
            this.ColImpreso.Name = "ColImpreso";
            this.ColImpreso.ReadOnly = true;
            this.ColImpreso.Visible = false;
            // 
            // ColOrden
            // 
            this.ColOrden.DataPropertyName = "Orden";
            this.ColOrden.HeaderText = "Orden";
            this.ColOrden.Name = "ColOrden";
            this.ColOrden.ReadOnly = true;
            this.ColOrden.Visible = false;
            // 
            // ColAgregar
            // 
            this.ColAgregar.HeaderText = "Agregar";
            this.ColAgregar.Name = "ColAgregar";
            this.ColAgregar.Text = "Def...";
            this.ColAgregar.UseColumnTextForButtonValue = true;
            this.ColAgregar.Width = 75;
            // 
            // ColDividir
            // 
            this.ColDividir.HeaderText = "Dividir";
            this.ColDividir.Name = "ColDividir";
            this.ColDividir.Text = "Div...";
            this.ColDividir.UseColumnTextForButtonValue = true;
            this.ColDividir.Width = 75;
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 449);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGeneral);
            this.Name = "frmOrdenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDescPorc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescMonto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.NumericUpDown numDescPorc;
        private System.Windows.Forms.NumericUpDown numDescMonto;
        private System.Windows.Forms.CheckBox chkITBIS;
        private System.Windows.Forms.TextBox txtClientePrincipal;
        private System.Windows.Forms.ComboBox cboMesa;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblPorcDesc;
        private System.Windows.Forms.Label lblMontDesc;
        private System.Windows.Forms.Label lblClientePrincipal;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColImpComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClientePedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColImpreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrden;
        private System.Windows.Forms.DataGridViewButtonColumn ColAgregar;
        private System.Windows.Forms.DataGridViewButtonColumn ColDividir;
    }
}