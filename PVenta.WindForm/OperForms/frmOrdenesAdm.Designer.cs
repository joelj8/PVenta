namespace PVenta.WindForm.OperForms
{
    partial class frmOrdenesAdm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalORG = new System.Windows.Forms.TextBox();
            this.lblTotalORG = new System.Windows.Forms.Label();
            this.txtPagado = new System.Windows.Forms.TextBox();
            this.lblPagado = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.lblNoOrden = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprimir.Location = new System.Drawing.Point(1016, 552);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 64);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.Maroon;
            this.btnFacturar.Location = new System.Drawing.Point(1016, 489);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(147, 64);
            this.btnFacturar.TabIndex = 20;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnNueva
            // 
            this.btnNueva.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNueva.Location = new System.Drawing.Point(1016, 363);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(147, 64);
            this.btnNueva.TabIndex = 19;
            this.btnNueva.Text = "NUEVA";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtTotalORG);
            this.panel2.Controls.Add(this.lblTotalORG);
            this.panel2.Controls.Add(this.txtPagado);
            this.panel2.Controls.Add(this.lblPagado);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtSubTotal);
            this.panel2.Controls.Add(this.txtITBIS);
            this.panel2.Controls.Add(this.lblSubtotal);
            this.panel2.Controls.Add(this.txtDescuento);
            this.panel2.Controls.Add(this.lblDescuento);
            this.panel2.Controls.Add(this.lblITBIS);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Location = new System.Drawing.Point(694, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 253);
            this.panel2.TabIndex = 18;
            // 
            // txtTotalORG
            // 
            this.txtTotalORG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalORG.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalORG.ForeColor = System.Drawing.Color.Green;
            this.txtTotalORG.Location = new System.Drawing.Point(153, 191);
            this.txtTotalORG.Name = "txtTotalORG";
            this.txtTotalORG.ReadOnly = true;
            this.txtTotalORG.Size = new System.Drawing.Size(135, 20);
            this.txtTotalORG.TabIndex = 30;
            this.txtTotalORG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalORG.Visible = false;
            // 
            // lblTotalORG
            // 
            this.lblTotalORG.AutoSize = true;
            this.lblTotalORG.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalORG.ForeColor = System.Drawing.Color.Green;
            this.lblTotalORG.Location = new System.Drawing.Point(9, 195);
            this.lblTotalORG.Name = "lblTotalORG";
            this.lblTotalORG.Size = new System.Drawing.Size(125, 23);
            this.lblTotalORG.TabIndex = 29;
            this.lblTotalORG.Text = "Total ORG.";
            this.lblTotalORG.Visible = false;
            // 
            // txtPagado
            // 
            this.txtPagado.BackColor = System.Drawing.SystemColors.Control;
            this.txtPagado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagado.ForeColor = System.Drawing.Color.Red;
            this.txtPagado.Location = new System.Drawing.Point(153, 154);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.ReadOnly = true;
            this.txtPagado.Size = new System.Drawing.Size(135, 20);
            this.txtPagado.TabIndex = 28;
            this.txtPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagado.Visible = false;
            // 
            // lblPagado
            // 
            this.lblPagado.AutoSize = true;
            this.lblPagado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagado.ForeColor = System.Drawing.Color.Red;
            this.lblPagado.Location = new System.Drawing.Point(9, 151);
            this.lblPagado.Name = "lblPagado";
            this.lblPagado.Size = new System.Drawing.Size(89, 23);
            this.lblPagado.TabIndex = 27;
            this.lblPagado.Text = "Pagado";
            this.lblPagado.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTotal.Location = new System.Drawing.Point(153, 117);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(135, 20);
            this.txtTotal.TabIndex = 26;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(153, 12);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(135, 20);
            this.txtSubTotal.TabIndex = 23;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtITBIS
            // 
            this.txtITBIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtITBIS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITBIS.Location = new System.Drawing.Point(153, 81);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.ReadOnly = true;
            this.txtITBIS.Size = new System.Drawing.Size(135, 20);
            this.txtITBIS.TabIndex = 25;
            this.txtITBIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtotal.Location = new System.Drawing.Point(9, 9);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(106, 23);
            this.lblSubtotal.TabIndex = 19;
            this.lblSubtotal.Text = "SubTotal";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(153, 46);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(135, 20);
            this.txtDescuento.TabIndex = 24;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescuento.Location = new System.Drawing.Point(9, 43);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(124, 23);
            this.lblDescuento.TabIndex = 20;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblITBIS.Location = new System.Drawing.Point(9, 78);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(71, 23);
            this.lblITBIS.TabIndex = 21;
            this.lblITBIS.Text = "ITBIS";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(9, 114);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 23);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNoOrden);
            this.panel1.Controls.Add(this.lblNoOrden);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.txtMesa);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.lblMesa);
            this.panel1.Location = new System.Drawing.Point(263, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 253);
            this.panel1.TabIndex = 17;
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoOrden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOrden.Location = new System.Drawing.Point(107, 11);
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.ReadOnly = true;
            this.txtNoOrden.Size = new System.Drawing.Size(283, 20);
            this.txtNoOrden.TabIndex = 26;
            // 
            // lblNoOrden
            // 
            this.lblNoOrden.AutoSize = true;
            this.lblNoOrden.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNoOrden.Location = new System.Drawing.Point(12, 9);
            this.lblNoOrden.Name = "lblNoOrden";
            this.lblNoOrden.Size = new System.Drawing.Size(75, 23);
            this.lblNoOrden.TabIndex = 25;
            this.lblNoOrden.Text = "Orden";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(13, 229);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(34, 13);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Info";
            this.lblInfo.Visible = false;
            // 
            // txtMesa
            // 
            this.txtMesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMesa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.Location = new System.Drawing.Point(107, 117);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.ReadOnly = true;
            this.txtMesa.Size = new System.Drawing.Size(283, 20);
            this.txtMesa.TabIndex = 23;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFecha.Location = new System.Drawing.Point(12, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(73, 23);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(107, 81);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(283, 20);
            this.txtCliente.TabIndex = 22;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCliente.Location = new System.Drawing.Point(12, 78);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(87, 23);
            this.lblCliente.TabIndex = 19;
            this.lblCliente.Text = "Cliente";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(107, 46);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(283, 20);
            this.txtFecha.TabIndex = 21;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMesa.Location = new System.Drawing.Point(12, 114);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(65, 23);
            this.lblMesa.TabIndex = 20;
            this.lblMesa.Text = "Mesa";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProducto,
            this.ColReferencia,
            this.ColOrden,
            this.ColCant,
            this.ColPrecio,
            this.ColTotal,
            this.colIDGrid});
            this.dgvOrderDetail.Location = new System.Drawing.Point(263, 12);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersVisible = false;
            this.dgvOrderDetail.Size = new System.Drawing.Size(900, 349);
            this.dgvOrderDetail.TabIndex = 2;
            this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellClick);
            this.dgvOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellContentClick);
            // 
            // ColProducto
            // 
            this.ColProducto.DataPropertyName = "Producto";
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 350;
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
            // ColCant
            // 
            this.ColCant.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.ColCant.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColCant.HeaderText = "Cantidad";
            this.ColCant.Name = "ColCant";
            this.ColCant.ReadOnly = true;
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
            this.ColPrecio.Width = 110;
            // 
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "Total";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.ColTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            this.ColTotal.Width = 130;
            // 
            // colIDGrid
            // 
            this.colIDGrid.DataPropertyName = "ID";
            this.colIDGrid.HeaderText = "ID";
            this.colIDGrid.Name = "colIDGrid";
            this.colIDGrid.ReadOnly = true;
            this.colIDGrid.Visible = false;
            // 
            // dgvMesas
            // 
            this.dgvMesas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColMesa});
            this.dgvMesas.Location = new System.Drawing.Point(3, 35);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.Size = new System.Drawing.Size(254, 581);
            this.dgvMesas.TabIndex = 1;
            this.dgvMesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellClick);
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColID.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.ColMesa.Width = 250;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(3, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(254, 21);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.Enter += new System.EventHandler(this.txtFiltro_Enter);
            this.txtFiltro.Leave += new System.EventHandler(this.txtFiltro_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(1016, 426);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 64);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmOrdenesAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 624);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.txtFiltro);
            this.Name = "frmOrdenesAdm";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.frmOrdenesAdm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMesa;
        private System.Windows.Forms.TextBox txtPagado;
        private System.Windows.Forms.Label lblPagado;
        private System.Windows.Forms.TextBox txtTotalORG;
        private System.Windows.Forms.Label lblTotalORG;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDGrid;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.Label lblNoOrden;
    }
}