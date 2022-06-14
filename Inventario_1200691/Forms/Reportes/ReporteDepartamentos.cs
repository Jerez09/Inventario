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
    public partial class ReporteDepartamentos : Reportes
    {
        public ReporteDepartamentos()
        {
            InitializeComponent();
        }

        private void ReporteDepartamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet1.departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.inventarioDataSet1.departamento);
            this.ReportViewerDepartamentos.RefreshReport();
        }

        public override void Buscar()
        {
            DataGridViewDep.DataSource = null;

            string comando = "EXEC Obtener_Departamentos";

            if (String.IsNullOrEmpty(TextBoxNombre.Text) == false)
                comando = $"EXEC Obtener_Departamento_Nombre {TextBoxNombre.Text.Trim()}";

            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                DataGridViewDep.DataSource = DataSet.Tables[0];
                ReportDataSource rds = new ReportDataSource("DataSetDepartamentos", DataSet.Tables[0]);
                ReportViewerDepartamentos.LocalReport.DataSources.Clear();
                ReportViewerDepartamentos.LocalReport.DataSources.Add(rds);
                ReportViewerDepartamentos.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias");
            }
        }

        public override void Imprimir()
        {
            ReportViewerDepartamentos.PrintDialog();
        }
    }
}
