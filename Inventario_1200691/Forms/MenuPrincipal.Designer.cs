namespace Inventario_1200691
{
    partial class MenuPrincipal
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
            this.BarraMenu = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonMantenimientoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonMantenimientoSuplidores = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonMantenimientoProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonMantenimientoDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonReporteSuplidores = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonReporteProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonReporteDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraMenu
            // 
            this.BarraMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(845, 24);
            this.BarraMenu.TabIndex = 1;
            this.BarraMenu.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BotonMantenimientoClientes,
            this.BotonMantenimientoSuplidores,
            this.BotonMantenimientoProductos,
            this.BotonMantenimientoDepartamentos,
            this.usuariosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // BotonMantenimientoClientes
            // 
            this.BotonMantenimientoClientes.Name = "BotonMantenimientoClientes";
            this.BotonMantenimientoClientes.Size = new System.Drawing.Size(155, 22);
            this.BotonMantenimientoClientes.Text = "Clientes";
            this.BotonMantenimientoClientes.Click += new System.EventHandler(this.BotonMantenimientoClientes_Click);
            // 
            // BotonMantenimientoSuplidores
            // 
            this.BotonMantenimientoSuplidores.Name = "BotonMantenimientoSuplidores";
            this.BotonMantenimientoSuplidores.Size = new System.Drawing.Size(155, 22);
            this.BotonMantenimientoSuplidores.Text = "Suplidores";
            this.BotonMantenimientoSuplidores.Click += new System.EventHandler(this.BotonMantenimientoSuplidores_Click);
            // 
            // BotonMantenimientoProductos
            // 
            this.BotonMantenimientoProductos.Name = "BotonMantenimientoProductos";
            this.BotonMantenimientoProductos.Size = new System.Drawing.Size(155, 22);
            this.BotonMantenimientoProductos.Text = "Productos";
            this.BotonMantenimientoProductos.Click += new System.EventHandler(this.BotonMantenimientoProductos_Click);
            // 
            // BotonMantenimientoDepartamentos
            // 
            this.BotonMantenimientoDepartamentos.Name = "BotonMantenimientoDepartamentos";
            this.BotonMantenimientoDepartamentos.Size = new System.Drawing.Size(155, 22);
            this.BotonMantenimientoDepartamentos.Text = "Departamentos";
            this.BotonMantenimientoDepartamentos.Click += new System.EventHandler(this.BotonMantenimientoDepartamentos_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BotonReporteClientes,
            this.BotonReporteSuplidores,
            this.BotonReporteProductos,
            this.BotonReporteDepartamentos,
            this.usuariosToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // BotonReporteClientes
            // 
            this.BotonReporteClientes.Name = "BotonReporteClientes";
            this.BotonReporteClientes.Size = new System.Drawing.Size(155, 22);
            this.BotonReporteClientes.Text = "Clientes";
            this.BotonReporteClientes.Click += new System.EventHandler(this.BotonReporteClientes_Click);
            // 
            // BotonReporteSuplidores
            // 
            this.BotonReporteSuplidores.Name = "BotonReporteSuplidores";
            this.BotonReporteSuplidores.Size = new System.Drawing.Size(155, 22);
            this.BotonReporteSuplidores.Text = "Suplidores";
            this.BotonReporteSuplidores.Click += new System.EventHandler(this.BotonReporteSuplidores_Click);
            // 
            // BotonReporteProductos
            // 
            this.BotonReporteProductos.Name = "BotonReporteProductos";
            this.BotonReporteProductos.Size = new System.Drawing.Size(155, 22);
            this.BotonReporteProductos.Text = "Productos";
            this.BotonReporteProductos.Click += new System.EventHandler(this.BotonReporteProductos_Click);
            // 
            // BotonReporteDepartamentos
            // 
            this.BotonReporteDepartamentos.Name = "BotonReporteDepartamentos";
            this.BotonReporteDepartamentos.Size = new System.Drawing.Size(155, 22);
            this.BotonReporteDepartamentos.Text = "Departamentos";
            this.BotonReporteDepartamentos.Click += new System.EventHandler(this.BotonReporteDepartamentos_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 540);
            this.Controls.Add(this.BarraMenu);
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.BarraMenu.ResumeLayout(false);
            this.BarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraMenu;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BotonMantenimientoClientes;
        private System.Windows.Forms.ToolStripMenuItem BotonMantenimientoSuplidores;
        private System.Windows.Forms.ToolStripMenuItem BotonMantenimientoProductos;
        private System.Windows.Forms.ToolStripMenuItem BotonMantenimientoDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BotonReporteClientes;
        private System.Windows.Forms.ToolStripMenuItem BotonReporteSuplidores;
        private System.Windows.Forms.ToolStripMenuItem BotonReporteProductos;
        private System.Windows.Forms.ToolStripMenuItem BotonReporteDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
    }
}