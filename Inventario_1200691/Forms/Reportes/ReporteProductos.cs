using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Reportes
{
    public partial class ReporteProductos : Reportes
    {
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet1.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.inventarioDataSet1.producto);
            this.ReportViewerProductos.RefreshReport();
        }

        public override void Buscar()
        {
            DataGridViewProductos.DataSource = null;

            string comando = "EXEC Obtener_Productos";

            if (String.IsNullOrEmpty(TextBoxNombre.Text) == false)
                comando = $"EXEC Obtener_Producto_Nombre {TextBoxNombre.Text.Trim()}";

            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                DataGridViewProductos.DataSource = DataSet.Tables[0];
                ReportDataSource rds = new ReportDataSource("DataSetProductos", DataSet.Tables[0]);
                ReportViewerProductos.LocalReport.DataSources.Clear();
                ReportViewerProductos.LocalReport.DataSources.Add(rds);
                ReportViewerProductos.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias");
            }
        }

        public override void Imprimir()
        {
            ReportViewerProductos.PrintDialog();
        }
    }
}
