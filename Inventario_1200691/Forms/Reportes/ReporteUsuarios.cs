using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Reportes
{
    public partial class ReporteUsuarios : Reportes
    {
        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet1.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.inventarioDataSet1.usuario);
            this.ReportViewerUsuarios.RefreshReport();
        }

        public override void Buscar()
        {
            DataGridViewUsuarios.DataSource = null;

            string comando = "EXEC Obtener_Usuarios";

            if (String.IsNullOrEmpty(TextBoxNombre.Text) == false)
                comando = $"EXEC Obtener_Usuario_Nombre {TextBoxNombre.Text.Trim()}";

            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                DataGridViewUsuarios.DataSource = DataSet.Tables[0];
                ReportDataSource rds = new ReportDataSource("DataSetUsuarios", DataSet.Tables[0]);
                ReportViewerUsuarios.LocalReport.DataSources.Clear();
                ReportViewerUsuarios.LocalReport.DataSources.Add(rds);
                ReportViewerUsuarios.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias");
            }
        }

        public override void Imprimir()
        {
            this.ReportViewerUsuarios.PrintDialog();
        }
    }
}
