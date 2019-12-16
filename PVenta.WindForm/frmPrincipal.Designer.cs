namespace PVenta.WindForm
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.operativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mesasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tipoInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menAdministrativo = new System.Windows.Forms.MenuStrip();
            this.menCajeros = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menAdministrativo.SuspendLayout();
            this.menCajeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // operativoToolStripMenuItem
            // 
            this.operativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.operativoToolStripMenuItem.Name = "operativoToolStripMenuItem";
            this.operativoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.operativoToolStripMenuItem.Text = "Operativo";
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            this.ordenesToolStripMenuItem.Click += new System.EventHandler(this.ordenesToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monedasToolStripMenuItem,
            this.mesasToolStripMenuItem,
            this.toolStripSeparator2,
            this.mesasToolStripMenuItem1,
            this.toolStripSeparator3,
            this.categoriasToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // monedasToolStripMenuItem
            // 
            this.monedasToolStripMenuItem.Name = "monedasToolStripMenuItem";
            this.monedasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.monedasToolStripMenuItem.Text = "Monedas";
            this.monedasToolStripMenuItem.Click += new System.EventHandler(this.monedasToolStripMenuItem_Click);
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mesasToolStripMenuItem.Text = "Forma Pago";
            this.mesasToolStripMenuItem.Click += new System.EventHandler(this.mesasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // mesasToolStripMenuItem1
            // 
            this.mesasToolStripMenuItem1.Name = "mesasToolStripMenuItem1";
            this.mesasToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.mesasToolStripMenuItem1.Text = "Mesas";
            this.mesasToolStripMenuItem1.Click += new System.EventHandler(this.mesasToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.opcionesSistemaToolStripMenuItem,
            this.toolStripSeparator4,
            this.tipoInformaciónToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Text = "Opciones Sistema";
            // 
            // opcionesSistemaToolStripMenuItem
            // 
            this.opcionesSistemaToolStripMenuItem.Name = "opcionesSistemaToolStripMenuItem";
            this.opcionesSistemaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.opcionesSistemaToolStripMenuItem.Text = "Permisos Roles";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // tipoInformaciónToolStripMenuItem
            // 
            this.tipoInformaciónToolStripMenuItem.Name = "tipoInformaciónToolStripMenuItem";
            this.tipoInformaciónToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tipoInformaciónToolStripMenuItem.Text = "Tipo Información";
            this.tipoInformaciónToolStripMenuItem.Click += new System.EventHandler(this.tipoInformaciónToolStripMenuItem_Click);
            // 
            // menAdministrativo
            // 
            this.menAdministrativo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operativoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menAdministrativo.Location = new System.Drawing.Point(0, 0);
            this.menAdministrativo.Name = "menAdministrativo";
            this.menAdministrativo.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menAdministrativo.Size = new System.Drawing.Size(933, 24);
            this.menAdministrativo.TabIndex = 0;
            this.menAdministrativo.Visible = false;
            // 
            // menCajeros
            // 
            this.menCajeros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.menCajeros.Location = new System.Drawing.Point(0, 0);
            this.menCajeros.Name = "menCajeros";
            this.menCajeros.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menCajeros.Size = new System.Drawing.Size(933, 24);
            this.menCajeros.TabIndex = 1;
            this.menCajeros.Visible = false;
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesToolStripMenuItem1});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // ordenesToolStripMenuItem1
            // 
            this.ordenesToolStripMenuItem1.Name = "ordenesToolStripMenuItem1";
            this.ordenesToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.ordenesToolStripMenuItem1.Text = "Ordenes";
            this.ordenesToolStripMenuItem1.Click += new System.EventHandler(this.ordenesToolStripMenuItem1_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.menAdministrativo);
            this.Controls.Add(this.menCajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menAdministrativo;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menAdministrativo.ResumeLayout(false);
            this.menAdministrativo.PerformLayout();
            this.menCajeros.ResumeLayout(false);
            this.menCajeros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem operativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem opcionesSistemaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menAdministrativo;
        private System.Windows.Forms.MenuStrip menCajeros;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tipoInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
    }
}

