namespace PVenta.WindForm.OperForms
{
    partial class frmFacturasAdm
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
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFacturaDetail = new System.Windows.Forms.DataGridView();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNoFactura = new System.Windows.Forms.Label();
            this.pnlCalculo = new System.Windows.Forms.Panel();
            this.txtTotalORG = new System.Windows.Forms.TextBox();
            this.txtPagado = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotalORG = new System.Windows.Forms.Label();
            this.lblPagado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDRelaciona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaDetail)).BeginInit();
            this.pnlResumen.SuspendLayout();
            this.pnlCalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaIni.Location = new System.Drawing.Point(12, 12);
            this.dtpFechaIni.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaIni.TabIndex = 0;
            this.dtpFechaIni.ValueChanged += new System.EventHandler(this.dtpFechaIni_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaFin.Location = new System.Drawing.Point(135, 12);
            this.dtpFechaFin.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaFin.TabIndex = 1;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 35);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(240, 21);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvMesas
            // 
            this.dgvMesas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColMesa});
            this.dgvMesas.Location = new System.Drawing.Point(12, 59);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.Size = new System.Drawing.Size(240, 561);
            this.dgvMesas.TabIndex = 3;
            this.dgvMesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellClick);
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColMesa
            // 
            this.ColMesa.DataPropertyName = "Mesa";
            this.ColMesa.HeaderText = "Mesa";
            this.ColMesa.Name = "ColMesa";
            this.ColMesa.ReadOnly = true;
            this.ColMesa.Width = 235;
            // 
            // dgvFacturaDetail
            // 
            this.dgvFacturaDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFacturaDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProducto,
            this.ColProductoID,
            this.ColReferencia,
            this.ColOrden,
            this.ColCantidad,
            this.ColPrecio,
            this.ColTotal,
            this.ColIDFactura,
            this.ColIDRelaciona});
            this.dgvFacturaDetail.Location = new System.Drawing.Point(258, 12);
            this.dgvFacturaDetail.Name = "dgvFacturaDetail";
            this.dgvFacturaDetail.RowHeadersVisible = false;
            this.dgvFacturaDetail.Size = new System.Drawing.Size(900, 349);
            this.dgvFacturaDetail.TabIndex = 4;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResumen.Controls.Add(this.txtMesa);
            this.pnlResumen.Controls.Add(this.txtCliente);
            this.pnlResumen.Controls.Add(this.txtFecha);
            this.pnlResumen.Controls.Add(this.txtNoFactura);
            this.pnlResumen.Controls.Add(this.lblMesa);
            this.pnlResumen.Controls.Add(this.lblCliente);
            this.pnlResumen.Controls.Add(this.lblFecha);
            this.pnlResumen.Controls.Add(this.lblNoFactura);
            this.pnlResumen.Location = new System.Drawing.Point(258, 367);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(415, 253);
            this.pnlResumen.TabIndex = 5;
            // 
            // txtMesa
            // 
            this.txtMesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMesa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.Location = new System.Drawing.Point(150, 142);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.ReadOnly = true;
            this.txtMesa.Size = new System.Drawing.Size(240, 20);
            this.txtMesa.TabIndex = 7;
            this.txtMesa.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(150, 101);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(240, 20);
            this.txtCliente.TabIndex = 6;
            this.txtCliente.TabStop = false;
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(150, 60);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(240, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.TabStop = false;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoFactura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoFactura.Location = new System.Drawing.Point(150, 19);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.ReadOnly = true;
            this.txtNoFactura.Size = new System.Drawing.Size(240, 20);
            this.txtNoFactura.TabIndex = 4;
            this.txtNoFactura.TabStop = false;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMesa.Location = new System.Drawing.Point(25, 139);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(65, 23);
            this.lblMesa.TabIndex = 3;
            this.lblMesa.Text = "Mesa";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCliente.Location = new System.Drawing.Point(25, 98);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(87, 23);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFecha.Location = new System.Drawing.Point(25, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(73, 23);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNoFactura.Location = new System.Drawing.Point(25, 16);
            this.lblNoFactura.Name = "lblNoFactura";
            this.lblNoFactura.Size = new System.Drawing.Size(91, 23);
            this.lblNoFactura.TabIndex = 0;
            this.lblNoFactura.Text = "Factura";
            // 
            // pnlCalculo
            // 
            this.pnlCalculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCalculo.Controls.Add(this.txtTotalORG);
            this.pnlCalculo.Controls.Add(this.txtPagado);
            this.pnlCalculo.Controls.Add(this.txtTotal);
            this.pnlCalculo.Controls.Add(this.txtITBIS);
            this.pnlCalculo.Controls.Add(this.txtDescuento);
            this.pnlCalculo.Controls.Add(this.txtSubTotal);
            this.pnlCalculo.Controls.Add(this.lblTotalORG);
            this.pnlCalculo.Controls.Add(this.lblPagado);
            this.pnlCalculo.Controls.Add(this.lblTotal);
            this.pnlCalculo.Controls.Add(this.lblITBIS);
            this.pnlCalculo.Controls.Add(this.lblDescuento);
            this.pnlCalculo.Controls.Add(this.lblSubtotal);
            this.pnlCalculo.Location = new System.Drawing.Point(679, 367);
            this.pnlCalculo.Name = "pnlCalculo";
            this.pnlCalculo.Size = new System.Drawing.Size(306, 253);
            this.pnlCalculo.TabIndex = 6;
            // 
            // txtTotalORG
            // 
            this.txtTotalORG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalORG.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalORG.Location = new System.Drawing.Point(144, 218);
            this.txtTotalORG.Name = "txtTotalORG";
            this.txtTotalORG.ReadOnly = true;
            this.txtTotalORG.Size = new System.Drawing.Size(149, 20);
            this.txtTotalORG.TabIndex = 11;
            this.txtTotalORG.TabStop = false;
            this.txtTotalORG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPagado
            // 
            this.txtPagado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagado.Location = new System.Drawing.Point(144, 180);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.ReadOnly = true;
            this.txtPagado.Size = new System.Drawing.Size(149, 20);
            this.txtPagado.TabIndex = 10;
            this.txtPagado.TabStop = false;
            this.txtPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(144, 142);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(149, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtITBIS
            // 
            this.txtITBIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtITBIS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITBIS.Location = new System.Drawing.Point(144, 101);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.ReadOnly = true;
            this.txtITBIS.Size = new System.Drawing.Size(149, 20);
            this.txtITBIS.TabIndex = 8;
            this.txtITBIS.TabStop = false;
            this.txtITBIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(144, 60);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(149, 20);
            this.txtDescuento.TabIndex = 7;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(144, 19);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(149, 20);
            this.txtSubTotal.TabIndex = 6;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalORG
            // 
            this.lblTotalORG.AutoSize = true;
            this.lblTotalORG.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalORG.ForeColor = System.Drawing.Color.Green;
            this.lblTotalORG.Location = new System.Drawing.Point(9, 215);
            this.lblTotalORG.Name = "lblTotalORG";
            this.lblTotalORG.Size = new System.Drawing.Size(125, 23);
            this.lblTotalORG.TabIndex = 5;
            this.lblTotalORG.Text = "Total ORG.";
            // 
            // lblPagado
            // 
            this.lblPagado.AutoSize = true;
            this.lblPagado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagado.ForeColor = System.Drawing.Color.Red;
            this.lblPagado.Location = new System.Drawing.Point(10, 177);
            this.lblPagado.Name = "lblPagado";
            this.lblPagado.Size = new System.Drawing.Size(89, 23);
            this.lblPagado.TabIndex = 4;
            this.lblPagado.Text = "Pagado";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(10, 139);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 23);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblITBIS.Location = new System.Drawing.Point(10, 98);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(71, 23);
            this.lblITBIS.TabIndex = 2;
            this.lblITBIS.Text = "ITBIS";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescuento.Location = new System.Drawing.Point(10, 57);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(124, 23);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtotal.Location = new System.Drawing.Point(10, 16);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(106, 23);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "SubTotal";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(1011, 430);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 64);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprimir.Location = new System.Drawing.Point(1011, 556);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 64);
            this.btnImprimir.TabIndex = 25;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.Maroon;
            this.btnPagar.Location = new System.Drawing.Point(1011, 493);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(147, 64);
            this.btnPagar.TabIndex = 24;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnNueva
            // 
            this.btnNueva.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNueva.Location = new System.Drawing.Point(1011, 367);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(147, 64);
            this.btnNueva.TabIndex = 23;
            this.btnNueva.Text = "NUEVA";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // ColProducto
            // 
            this.ColProducto.DataPropertyName = "Producto";
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 350;
            // 
            // ColProductoID
            // 
            this.ColProductoID.DataPropertyName = "ProductoID";
            this.ColProductoID.HeaderText = "Producto ID";
            this.ColProductoID.Name = "ColProductoID";
            this.ColProductoID.ReadOnly = true;
            this.ColProductoID.Visible = false;
            // 
            // ColReferencia
            // 
            this.ColReferencia.DataPropertyName = "Referencia";
            this.ColReferencia.HeaderText = "Referencia";
            this.ColReferencia.Name = "ColReferencia";
            this.ColReferencia.ReadOnly = true;
            this.ColReferencia.Width = 200;
            // 
            // ColOrden
            // 
            this.ColOrden.DataPropertyName = "Orden";
            this.ColOrden.HeaderText = "Orden";
            this.ColOrden.Name = "ColOrden";
            this.ColOrden.ReadOnly = true;
            this.ColOrden.Visible = false;
            // 
            // ColCantidad
            // 
            this.ColCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.ColCantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColPrecio
            // 
            this.ColPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.ColPrecio.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 110;
            // 
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.ColTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            this.ColTotal.Width = 130;
            // 
            // ColIDFactura
            // 
            this.ColIDFactura.DataPropertyName = "ID";
            this.ColIDFactura.HeaderText = "ID";
            this.ColIDFactura.Name = "ColIDFactura";
            this.ColIDFactura.ReadOnly = true;
            this.ColIDFactura.Visible = false;
            // 
            // ColIDRelaciona
            // 
            this.ColIDRelaciona.DataPropertyName = "IDRelaciona";
            this.ColIDRelaciona.HeaderText = "ID Relaciona";
            this.ColIDRelaciona.Name = "ColIDRelaciona";
            this.ColIDRelaciona.ReadOnly = true;
            this.ColIDRelaciona.Visible = false;
            // 
            // frmFacturasAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 624);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.pnlCalculo);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.dgvFacturaDetail);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaIni);
            this.Name = "frmFacturasAdm";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturasAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaDetail)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.pnlCalculo.ResumeLayout(false);
            this.pnlCalculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.DataGridView dgvFacturaDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMesa;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblNoFactura;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Panel pnlCalculo;
        private System.Windows.Forms.Label lblTotalORG;
        private System.Windows.Forms.Label lblPagado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtTotalORG;
        private System.Windows.Forms.TextBox txtPagado;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDRelaciona;
    }
}