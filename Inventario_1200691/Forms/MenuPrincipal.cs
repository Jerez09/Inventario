using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_1200691
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true; // Afirmando que este elemento va a ser padre de otros componentes
        }

        private void BotonMantenimientoClientes_Click(object sender, EventArgs e)
        {
           Forms.Mantenimientos.MantenimientoClientes obj = new Forms.Mantenimientos.MantenimientoClientes();
            obj.MdiParent = this;
            obj.Show();
        }

        private void BotonReporteClientes_Click(object sender, EventArgs e)
        {
            Forms.Reportes.ReporteClientes obj = new Forms.Reportes.ReporteClientes();
            obj.MdiParent = this;
            obj.Show();
        }

        private void BotonMantenimientoSuplidores_Click(object sender, EventArgs e)
        {
            Forms.Mantenimientos.MantenimientoSuplidores obj = new Forms.Mantenimientos.MantenimientoSuplidores();
            obj.MdiParent = this;
            obj.Show();
        }

        private void BotonReporteSuplidores_Click(object sender, EventArgs e)
        {
            Forms.Reportes.ReporteSuplidores obj = new Forms.Reportes.ReporteSuplidores();
            obj.MdiParent = this;
            obj.Show();
        }

        private void BotonMantenimientoProductos_Click(object sender, EventArgs e)
        {
            Forms.Mantenimientos.MantenimientoProductos obj = new Forms.Mantenimientos.MantenimientoProductos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void BotonReporteProductos_Click(object sender, EventArgs e)
        {
            Forms.Reportes.ReporteProductos obj = new Forms.Reportes.ReporteProductos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void BotonMantenimientoDepartamentos_Click(object sender, EventArgs e)
        {
            Forms.Mantenimientos.MantenimientoDepartamentos obj = new Forms.Mantenimientos.MantenimientoDepartamentos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void BotonReporteDepartamentos_Click(object sender, EventArgs e)
        {
            Forms.Reportes.ReporteDepartamentos obj = new Forms.Reportes.ReporteDepartamentos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Procesos.FormVentas obj = new Forms.Procesos.FormVentas();
            obj.MdiParent = this;
            obj.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Procesos.FormCompras obj = new Forms.Procesos.FormCompras();
            obj.MdiParent = this;
            obj.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Mantenimientos.MantenimientoUsuarios obj = new Forms.Mantenimientos.MantenimientoUsuarios();
            obj.MdiParent = this;
            obj.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.Reportes.ReporteUsuarios obj = new Forms.Reportes.ReporteUsuarios();
            obj.MdiParent = this;
            obj.Show();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
