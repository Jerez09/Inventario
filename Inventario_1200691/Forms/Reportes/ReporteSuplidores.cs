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
    public partial class ReporteSuplidores : Reportes
    {
        public ReporteSuplidores()
        {
            InitializeComponent();
        }

        private void ReporteSuplidores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet1.suplidor' Puede moverla o quitarla según sea necesario.
            this.suplidorTableAdapter.Fill(this.inventarioDataSet1.suplidor);
            this.ReportViewerSuplidores.RefreshReport();
        }

        public override void Buscar()
        {
            DataGridViewSuplidores.DataSource = null;

            string comando = "EXEC Obtener_Suplidores";

            if (String.IsNullOrEmpty(TextBoxNombre.Text) == false)
                comando = $"EXEC Obtener_Suplidor_Nombre {TextBoxNombre.Text.Trim()}";

            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                DataGridViewSuplidores.DataSource = DataSet.Tables[0];
                ReportDataSource rds = new ReportDataSource("DataSetSuplidores", DataSet.Tables[0]);
                ReportViewerSuplidores.LocalReport.DataSources.Clear();
                ReportViewerSuplidores.LocalReport.DataSources.Add(rds);
                ReportViewerSuplidores.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias");
            }
        }

        public override void Imprimir()
        {
            this.ReportViewerSuplidores.PrintDialog();
        }
    }
}
