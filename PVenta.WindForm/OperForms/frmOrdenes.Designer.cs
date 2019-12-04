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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.chkServicio = new System.Windows.Forms.CheckBox();
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
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDividir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColClientePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImpComanda = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColInactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColImpreso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrderHID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDescPorc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescMonto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.pnlResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGeneral.Controls.Add(this.chkServicio);
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
            this.pnlGeneral.TabIndex = 2;
            // 
            // chkServicio
            // 
            this.chkServicio.AutoSize = true;
            this.chkServicio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkServicio.Location = new System.Drawing.Point(608, 67);
            this.chkServicio.Name = "chkServicio";
            this.chkServicio.Size = new System.Drawing.Size(80, 18);
            this.chkServicio.TabIndex = 20;
            this.chkServicio.Text = "Servicio";
            this.chkServicio.UseVisualStyleBackColor = true;
            this.chkServicio.CheckedChanged += new System.EventHandler(this.chkServicio_CheckedChanged);
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
            this.numDescPorc.Validated += new System.EventHandler(this.numDescPorc_Validated);
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
            this.numDescMonto.Size = new System.Drawing.Size(101, 21);
            this.numDescMonto.TabIndex = 6;
            this.numDescMonto.ThousandsSeparator = true;
            this.numDescMonto.Validated += new System.EventHandler(this.numDescMonto_Validated);
            // 
            // chkITBIS
            // 
            this.chkITBIS.AutoSize = true;
            this.chkITBIS.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkITBIS.Location = new System.Drawing.Point(542, 65);
            this.chkITBIS.Name = "chkITBIS";
            this.chkITBIS.Size = new System.Drawing.Size(60, 20);
            this.chkITBIS.TabIndex = 8;
            this.chkITBIS.Text = "Itbis";
            this.chkITBIS.UseVisualStyleBackColor = true;
            this.chkITBIS.CheckedChanged += new System.EventHandler(this.chkITBIS_CheckedChanged);
            // 
            // txtClientePrincipal
            // 
            this.txtClientePrincipal.Location = new System.Drawing.Point(295, 64);
            this.txtClientePrincipal.Name = "txtClientePrincipal";
            this.txtClientePrincipal.Size = new System.Drawing.Size(206, 21);
            this.txtClientePrincipal.TabIndex = 5;
            // 
            // cboMesa
            // 
            this.cboMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cboUsuario.TabStop = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(71, 29);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(154, 21);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.TabStop = false;
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
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.numTotal);
            this.panel1.Controls.Add(this.numPrecio);
            this.panel1.Controls.Add(this.numCant);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 33);
            this.panel1.TabIndex = 1;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(163, 5);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(283, 21);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(345, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 8;
            this.txtID.TabStop = false;
            this.txtID.Visible = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(6, 8);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(58, 16);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(762, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numTotal
            // 
            this.numTotal.DecimalPlaces = 2;
            this.numTotal.Enabled = false;
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
            this.numTotal.TabStop = false;
            this.numTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTotal.ThousandsSeparator = true;
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Enabled = false;
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
            this.numPrecio.TabStop = false;
            this.numPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecio.ThousandsSeparator = true;
            // 
            // numCant
            // 
            this.numCant.Location = new System.Drawing.Point(449, 5);
            this.numCant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(77, 21);
            this.numCant.TabIndex = 2;
            this.numCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCant.ThousandsSeparator = true;
            this.numCant.ValueChanged += new System.EventHandler(this.numCant_ValueChanged);
            this.numCant.Enter += new System.EventHandler(this.numCant_Enter);
            this.numCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCant_KeyPress);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(81, 5);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(77, 21);
            this.txtReferencia.TabIndex = 0;
            this.txtReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReferencia_KeyPress);
            this.txtReferencia.Validated += new System.EventHandler(this.txtReferencia_Validated);
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
            this.ColAgregar,
            this.ColDividir,
            this.ColClientePedido,
            this.ColImpComanda,
            this.ColInactivo,
            this.ColImpreso,
            this.ColOrden,
            this.ColOrderHID,
            this.ColProductoID});
            this.dgvOrderDetail.Location = new System.Drawing.Point(12, 157);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersVisible = false;
            this.dgvOrderDetail.Size = new System.Drawing.Size(817, 281);
            this.dgvOrderDetail.TabIndex = 15;
            this.dgvOrderDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvOrderDetail_KeyPress);
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
            this.ColReferencia.DataPropertyName = "Referencia";
            this.ColReferencia.HeaderText = "Referencia";
            this.ColReferencia.Name = "ColReferencia";
            this.ColReferencia.ReadOnly = true;
            // 
            // ColCant
            // 
            this.ColCant.DataPropertyName = "Cantidad";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.ColCant.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCant.HeaderText = "Cantidad";
            this.ColCant.Name = "ColCant";
            this.ColCant.ReadOnly = true;
            this.ColCant.Width = 90;
            // 
            // ColPrecio
            // 
            this.ColPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.ColPrecio.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "Total";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.ColTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
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
            // ColClientePedido
            // 
            this.ColClientePedido.DataPropertyName = "ClientePedido";
            this.ColClientePedido.HeaderText = "Cliente Pedido";
            this.ColClientePedido.Name = "ColClientePedido";
            this.ColClientePedido.ReadOnly = true;
            this.ColClientePedido.Visible = false;
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
            // ColInactivo
            // 
            this.ColInactivo.DataPropertyName = "Inactivo";
            this.ColInactivo.HeaderText = "Inactivo";
            this.ColInactivo.Name = "ColInactivo";
            this.ColInactivo.ReadOnly = true;
            this.ColInactivo.Visible = false;
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
            // ColOrderHID
            // 
            this.ColOrderHID.DataPropertyName = "OrderHID";
            this.ColOrderHID.HeaderText = "Order Header ID";
            this.ColOrderHID.Name = "ColOrderHID";
            this.ColOrderHID.ReadOnly = true;
            this.ColOrderHID.Visible = false;
            // 
            // ColProductoID
            // 
            this.ColProductoID.DataPropertyName = "ProductoID";
            this.ColProductoID.HeaderText = "Producto ID";
            this.ColProductoID.Name = "ColProductoID";
            this.ColProductoID.ReadOnly = true;
            this.ColProductoID.Visible = false;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResumen.Controls.Add(this.txtServicio);
            this.pnlResumen.Controls.Add(this.lblServicio);
            this.pnlResumen.Controls.Add(this.txtTotal);
            this.pnlResumen.Controls.Add(this.txtITBIS);
            this.pnlResumen.Controls.Add(this.txtDescuento);
            this.pnlResumen.Controls.Add(this.txtSubTotal);
            this.pnlResumen.Controls.Add(this.lblTotal);
            this.pnlResumen.Controls.Add(this.lblITBIS);
            this.pnlResumen.Controls.Add(this.lblDescuento);
            this.pnlResumen.Controls.Add(this.lblSubTotal);
            this.pnlResumen.Location = new System.Drawing.Point(475, 441);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(354, 155);
            this.pnlResumen.TabIndex = 26;
            // 
            // txtServicio
            // 
            this.txtServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicio.Enabled = false;
            this.txtServicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServicio.Location = new System.Drawing.Point(167, 66);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.Size = new System.Drawing.Size(155, 20);
            this.txtServicio.TabIndex = 46;
            this.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblServicio.Location = new System.Drawing.Point(30, 62);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(96, 23);
            this.lblServicio.TabIndex = 45;
            this.lblServicio.Text = "Servicio";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTotal.Location = new System.Drawing.Point(167, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(155, 20);
            this.txtTotal.TabIndex = 44;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtITBIS
            // 
            this.txtITBIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtITBIS.Enabled = false;
            this.txtITBIS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITBIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtITBIS.Location = new System.Drawing.Point(167, 90);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.ReadOnly = true;
            this.txtITBIS.Size = new System.Drawing.Size(155, 20);
            this.txtITBIS.TabIndex = 43;
            this.txtITBIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescuento.Location = new System.Drawing.Point(167, 38);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(155, 20);
            this.txtDescuento.TabIndex = 42;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.Location = new System.Drawing.Point(167, 9);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(155, 20);
            this.txtSubTotal.TabIndex = 41;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(30, 116);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 23);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Total";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblITBIS.Location = new System.Drawing.Point(30, 89);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(71, 23);
            this.lblITBIS.TabIndex = 39;
            this.lblITBIS.Text = "ITBIS";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescuento.Location = new System.Drawing.Point(30, 34);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(124, 23);
            this.lblDescuento.TabIndex = 38;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTotal.Location = new System.Drawing.Point(30, 5);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(106, 23);
            this.lblSubTotal.TabIndex = 37;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 600);
            this.Controls.Add(this.pnlResumen);
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
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
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
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColAgregar;
        private System.Windows.Forms.DataGridViewButtonColumn ColDividir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClientePedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColImpComanda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColInactivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColImpreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrderHID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoID;
        private System.Windows.Forms.CheckBox chkServicio;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubTotal;
    }
}