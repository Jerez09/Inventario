using Inventario_1200691.inventarioDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Reportes
{
    public partial class ReporteClientes : Reportes
    {
        public ReporteClientes()
        {
            InitializeComponent();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter1.Fill(this.inventarioDataSet1.cliente);
            this.ReportViewerClientes.RefreshReport();
            
        }

        public override void Buscar()
        {
            DataGridViewClientes.DataSource = null;

            string comando = "EXEC Obtener_Clientes";

            if (String.IsNullOrEmpty(TextBoxNombre.Text) == false)
                comando = $"EXEC Obtener_Cliente_Nombre {TextBoxNombre.Text.Trim()}";

            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                DataGridViewClientes.DataSource = DataSet.Tables[0];
                ReportDataSource rds = new ReportDataSource("DataSetClientes", DataSet.Tables[0]);
                ReportViewerClientes.LocalReport.DataSources.Clear();
                ReportViewerClientes.LocalReport.DataSources.Add(rds);
                ReportViewerClientes.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias");
            }
        }

        // Imprimir reporte
        public override void Imprimir()
        {
            this.ReportViewerClientes.PrintDialog();
        }
    }
}
