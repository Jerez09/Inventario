using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Procesos
{
    public partial class FormVentas : Proceso
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.inventarioDataSet.cliente);
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.inventarioDataSet.producto);
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.inventarioDataSet.facturas);

            this.ReportViewerVentas.RefreshReport();
            this.ReportViewerVentas.RefreshReport();
            this.ReportViewerVentas.RefreshReport();
        }

        public override void Guardar()
        {
            if(DataGridViewProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para guardadr");
                return;
            }

            string numero_factura = "";
            string fecha = "";
            string codigo_cliente = TextBoxCliente.Text.Trim();
            string nombre_cliente = TextBoxNombreCliente.Text.Trim();
            bool estado = false;

            string comando = $"EXEC Actualizar_Factura '{numero_factura}', '{fecha}', '{codigo_cliente}', '{estado}', {Convert.ToDouble(TextBoxTotal.Text.Trim())}";

            DataSet dataSet = EjecutarProcedimiento(comando);

            if(!TieneDatos(dataSet))
            {
                MessageBox.Show("Error al registrar la factura");
                return;
            }

            numero_factura = dataSet.Tables[0].Rows[0]["numfac"].ToString().Trim();

            foreach (DataGridViewRow row in DataGridViewProductos.Rows)
            {
                string codigo_prod = row.Cells[0].Value.ToString();
                string nombre_prod = row.Cells[1].Value.ToString();
                double cantidad_vendida = Convert.ToDouble(row.Cells[2].Value);
                double precio = Convert.ToDouble(row.Cells[3].Value);
                double importe = Convert.ToDouble(row.Cells[4].Value);

                comando = $"EXEC Actualizar_Detalles {numero_factura}, {codigo_prod}, '{nombre_prod}', {cantidad_vendida}, {precio}, {importe}";

                dataSet = EjecutarProcedimiento(comando);

                if(!TieneDatos(dataSet))
                {
                    MessageBox.Show("Error al registrar los detalles de la factura");
                    return;
                }
            }

            dataSet = EjecutarProcedimiento($"EXEC Obtener_Factura {numero_factura}");
            fecha = dataSet.Tables[0].Rows[0]["fecfac"].ToString().Trim();

            if(!TieneDatos(dataSet))
            {
                MessageBox.Show("La factura no tiene datos");
                return;
            }

            dataSet = EjecutarProcedimiento($"EXEC Obtener_Detalles_Factura {numero_factura}");
            DataSet dataSetFactura = EjecutarProcedimiento($"EXEC Obtener_Factura_Simple {numero_factura}");
            DataSet dataSetCliente = EjecutarProcedimiento($"EXEC Obtener_Cliente {codigo_cliente}");

            if (!TieneDatos(dataSet)) { MessageBox.Show("No hay detalles para mostrar"); }

            // Imprimir reporte
            ReportDataSource reportDataSourceDetalles = new ReportDataSource("DataSetDetalles", dataSet.Tables[0]);
            ReportDataSource reportDataSourceFacturas = new ReportDataSource("DataSetFacturas", dataSetFactura.Tables[0]);
            ReportDataSource reportDataSourceClientes = new ReportDataSource("DataSetClientes", dataSetCliente.Tables[0]);

            ReportViewerVentas.LocalReport.DataSources.Clear();
            ReportViewerVentas.LocalReport.DataSources.Add(reportDataSourceDetalles);
            ReportViewerVentas.LocalReport.DataSources.Add(reportDataSourceFacturas);
            ReportViewerVentas.LocalReport.DataSources.Add(reportDataSourceClientes);
            ReportViewerVentas.Refresh();

            ReportViewerVentas.PrintDialog();

            LimpiarInputs();
        }

        private void ReportViewerVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
