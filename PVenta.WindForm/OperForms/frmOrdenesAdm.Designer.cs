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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblMesa = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(3, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(254, 21);
            this.txtFiltro.TabIndex = 0;
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
            this.dgvMesas.Size = new System.Drawing.Size(254, 597);
            this.dgvMesas.TabIndex = 1;
            this.dgvMesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellContentClick);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProducto,
            this.ColReferencia,
            this.ColCant,
            this.ColPrecio,
            this.ColTotal});
            this.dgvOrderDetail.Location = new System.Drawing.Point(263, 12);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersVisible = false;
            this.dgvOrderDetail.Size = new System.Drawing.Size(900, 430);
            this.dgvOrderDetail.TabIndex = 2;
            // 
            // btnNueva
            // 
            this.btnNueva.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNueva.Location = new System.Drawing.Point(1016, 455);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(147, 53);
            this.btnNueva.TabIndex = 19;
            this.btnNueva.Text = "NUEVA";
            this.btnNueva.UseVisualStyleBackColor = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFacturar.Location = new System.Drawing.Point(1016, 520);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(147, 53);
            this.btnFacturar.TabIndex = 20;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnImprimir.Location = new System.Drawing.Point(1016, 579);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 53);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(12, 88);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(65, 23);
            this.lblMesa.TabIndex = 20;
            this.lblMesa.Text = "Mesa";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(107, 16);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(283, 20);
            this.txtFecha.TabIndex = 21;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 51);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(87, 23);
            this.lblCliente.TabIndex = 19;
            this.lblCliente.Text = "Cliente";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(107, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(283, 20);
            this.textBox2.TabIndex = 22;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 14);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(73, 23);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(107, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(283, 20);
            this.textBox3.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.lblMesa);
            this.panel1.Location = new System.Drawing.Point(263, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 173);
            this.panel1.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(9, 125);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 23);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBIS.Location = new System.Drawing.Point(9, 89);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(71, 23);
            this.lblITBIS.TabIndex = 21;
            this.lblITBIS.Text = "ITBIS";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(9, 52);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(124, 23);
            this.lblDescuento.TabIndex = 20;
            this.lblDescuento.Text = "Descuento";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(153, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(135, 20);
            this.textBox5.TabIndex = 24;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(9, 15);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(106, 23);
            this.lblSubtotal.TabIndex = 19;
            this.lblSubtotal.Text = "SubTotal";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(153, 91);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(135, 20);
            this.textBox6.TabIndex = 25;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(153, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox7.Location = new System.Drawing.Point(153, 130);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(135, 20);
            this.textBox7.TabIndex = 26;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.lblSubtotal);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.lblDescuento);
            this.panel2.Controls.Add(this.lblITBIS);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Location = new System.Drawing.Point(694, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 171);
            this.panel2.TabIndex = 18;
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
            this.ColMesa.Width = 250;
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
            // frmOrdenesAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 641);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
    }
}