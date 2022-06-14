using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventario_1200691.Forms
{
    public partial class FormReporte : FormBase
    {
        string ReportName;
        string DataSource; 
        DataSet ds;

        public FormReporte()
        {
            InitializeComponent();
        }

        public FormReporte(string ReportName, string DataSource, DataSet ds) 
        {
            this.ReportName = ReportName;
            this.DataSource = DataSource;
            this.ds = ds;

            InitializeComponent();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {

            ReportViewerMain.LocalReport.ReportEmbeddedResource = $"~/{ReportName}";
            ReportViewerMain.LocalReport.DataSources.Clear();

            if (TieneDatos(ds))
            {
                ReportDataSource dataSource = new ReportDataSource($"{DataSource}", ds.Tables[0]);
                ReportViewerMain.LocalReport.DataSources.Add(dataSource);
            }
                
            ReportViewerMain.RefreshReport();
        }
    }
}
