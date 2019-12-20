namespace PVenta.WindForm.OperForms
{
    partial class frmFacturaPayment
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
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.pnlPago = new System.Windows.Forms.Panel();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.numMontPago = new System.Windows.Forms.NumericUpDown();
            this.txtInfoPago = new System.Windows.Forms.TextBox();
            this.dgvFacturaPagos = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.ColFormaPagoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInfoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMontoDevolver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDevolver = new System.Windows.Forms.TextBox();
            this.lblDevolver = new System.Windows.Forms.Label();
            this.pnlResumen.SuspendLayout();
            this.pnlPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMontPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaPagos)).BeginInit();
            this.SuspendLayout();
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
            this.lblServicio.Location = new System.Drawing.Point(10, 62);
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
            this.lblTotal.Location = new System.Drawing.Point(10, 116);
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
            this.lblITBIS.Location = new System.Drawing.Point(10, 89);
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
            this.lblDescuento.Location = new System.Drawing.Point(10, 34);
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
            this.lblSubTotal.Location = new System.Drawing.Point(10, 5);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(106, 23);
            this.lblSubTotal.TabIndex = 37;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // pnlResumen
            // 
            this.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResumen.Controls.Add(this.txtDevolver);
            this.pnlResumen.Controls.Add(this.lblDevolver);
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
            this.pnlResumen.Location = new System.Drawing.Point(12, 23);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(497, 190);
            this.pnlResumen.TabIndex = 31;
            // 
            // pnlPago
            // 
            this.pnlPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPago.Controls.Add(this.btnAdd);
            this.pnlPago.Controls.Add(this.txtInfoPago);
            this.pnlPago.Controls.Add(this.numMontPago);
            this.pnlPago.Controls.Add(this.cboFormaPago);
            this.pnlPago.Location = new System.Drawing.Point(12, 219);
            this.pnlPago.Name = "pnlPago";
            this.pnlPago.Size = new System.Drawing.Size(497, 30);
            this.pnlPago.TabIndex = 32;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(3, 3);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(98, 21);
            this.cboFormaPago.TabIndex = 0;
            // 
            // numMontPago
            // 
            this.numMontPago.Location = new System.Drawing.Point(107, 4);
            this.numMontPago.Name = "numMontPago";
            this.numMontPago.Size = new System.Drawing.Size(120, 21);
            this.numMontPago.TabIndex = 1;
            // 
            // txtInfoPago
            // 
            this.txtInfoPago.Location = new System.Drawing.Point(233, 4);
            this.txtInfoPago.Name = "txtInfoPago";
            this.txtInfoPago.Size = new System.Drawing.Size(225, 21);
            this.txtInfoPago.TabIndex = 2;
            // 
            // dgvFacturaPagos
            // 
            this.dgvFacturaPagos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFacturaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFormaPagoID,
            this.ColFormaPago,
            this.ColMonto,
            this.ColInfoPago,
            this.ColMontoDevolver});
            this.dgvFacturaPagos.Location = new System.Drawing.Point(12, 261);
            this.dgvFacturaPagos.Name = "dgvFacturaPagos";
            this.dgvFacturaPagos.RowHeadersVisible = false;
            this.dgvFacturaPagos.Size = new System.Drawing.Size(497, 203);
            this.dgvFacturaPagos.TabIndex = 33;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(462, -1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(515, 389);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(82, 75);
            this.btnPagar.TabIndex = 34;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // ColFormaPagoID
            // 
            this.ColFormaPagoID.DataPropertyName = "FormaPagoId";
            this.ColFormaPagoID.HeaderText = "Forma Pago ID";
            this.ColFormaPagoID.Name = "ColFormaPagoID";
            this.ColFormaPagoID.ReadOnly = true;
            this.ColFormaPagoID.Visible = false;
            // 
            // ColFormaPago
            // 
            this.ColFormaPago.DataPropertyName = "FormaPago";
            this.ColFormaPago.HeaderText = "Forma Pago";
            this.ColFormaPago.Name = "ColFormaPago";
            this.ColFormaPago.ReadOnly = true;
            this.ColFormaPago.Width = 150;
            // 
            // ColMonto
            // 
            this.ColMonto.DataPropertyName = "MontoPago";
            this.ColMonto.HeaderText = "Monto Pago";
            this.ColMonto.Name = "ColMonto";
            this.ColMonto.ReadOnly = true;
            this.ColMonto.Width = 150;
            // 
            // ColInfoPago
            // 
            this.ColInfoPago.DataPropertyName = "InfoPago";
            this.ColInfoPago.HeaderText = "Inf. Pago";
            this.ColInfoPago.Name = "ColInfoPago";
            this.ColInfoPago.ReadOnly = true;
            this.ColInfoPago.Width = 190;
            // 
            // ColMontoDevolver
            // 
            this.ColMontoDevolver.DataPropertyName = "MontoDevolver";
            this.ColMontoDevolver.HeaderText = "Monto Devolver";
            this.ColMontoDevolver.Name = "ColMontoDevolver";
            this.ColMontoDevolver.ReadOnly = true;
            this.ColMontoDevolver.Visible = false;
            // 
            // txtDevolver
            // 
            this.txtDevolver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevolver.Enabled = false;
            this.txtDevolver.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolver.ForeColor = System.Drawing.Color.Red;
            this.txtDevolver.Location = new System.Drawing.Point(167, 149);
            this.txtDevolver.Name = "txtDevolver";
            this.txtDevolver.ReadOnly = true;
            this.txtDevolver.Size = new System.Drawing.Size(155, 30);
            this.txtDevolver.TabIndex = 48;
            this.txtDevolver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDevolver
            // 
            this.lblDevolver.AutoSize = true;
            this.lblDevolver.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolver.ForeColor = System.Drawing.Color.Red;
            this.lblDevolver.Location = new System.Drawing.Point(10, 155);
            this.lblDevolver.Name = "lblDevolver";
            this.lblDevolver.Size = new System.Drawing.Size(133, 29);
            this.lblDevolver.TabIndex = 47;
            this.lblDevolver.Text = "Devolver";
            // 
            // frmFacturaPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 474);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dgvFacturaPagos);
            this.Controls.Add(this.pnlPago);
            this.Controls.Add(this.pnlResumen);
            this.Name = "frmFacturaPayment";
            this.Text = "Pago de Factura";
            this.Load += new System.EventHandler(this.frmFacturaPayment_Load);
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.pnlPago.ResumeLayout(false);
            this.pnlPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMontPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Panel pnlPago;
        private System.Windows.Forms.TextBox txtInfoPago;
        private System.Windows.Forms.NumericUpDown numMontPago;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.DataGridView dgvFacturaPagos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormaPagoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInfoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMontoDevolver;
        private System.Windows.Forms.TextBox txtDevolver;
        private System.Windows.Forms.Label lblDevolver;
    }
}