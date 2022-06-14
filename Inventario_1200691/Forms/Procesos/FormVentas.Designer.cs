namespace Inventario_1200691.Forms.Procesos
{
    partial class FormVentas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.detallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet = new Inventario_1200691.inventarioDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet1 = new Inventario_1200691.inventarioDataSet();
            this.ReportViewerVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.detallesTableAdapter();
            this.suplidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.productoTableAdapter();
            this.clienteTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.clienteTableAdapter();
            this.facturasTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.facturasTableAdapter();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ReportViewerVentas);
            this.panel5.Controls.SetChildIndex(this.ReportViewerVentas, 0);
            // 
            // detallesBindingSource
            // 
            this.detallesBindingSource.DataMember = "detalles";
            this.detallesBindingSource.DataSource = this.inventarioDataSetBindingSource;
            // 
            // inventarioDataSetBindingSource
            // 
            this.inventarioDataSetBindingSource.DataSource = this.inventarioDataSet;
            this.inventarioDataSetBindingSource.Position = 0;
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "inventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.inventarioDataSet;
            // 
            // facturasBindingSource1
            // 
            this.facturasBindingSource1.DataMember = "facturas";
            this.facturasBindingSource1.DataSource = this.inventarioDataSet1;
            // 
            // inventarioDataSet1
            // 
            this.inventarioDataSet1.DataSetName = "inventarioDataSet";
            this.inventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportViewerVentas
            // 
            reportDataSource1.Name = "DataSetDetalles";
            reportDataSource1.Value = this.detallesBindingSource;
            reportDataSource2.Name = "DataSetClientes";
            reportDataSource2.Value = this.clienteBindingSource;
            reportDataSource3.Name = "DataSetFacturas";
            reportDataSource3.Value = this.facturasBindingSource1;
            this.ReportViewerVentas.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerVentas.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewerVentas.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportViewerVentas.LocalReport.ReportEmbeddedResource = "Inventario_1200691.ReporteFactura.rdlc";
            this.ReportViewerVentas.Location = new System.Drawing.Point(142, 54);
            this.ReportViewerVentas.Name = "ReportViewerVentas";
            this.ReportViewerVentas.ServerReport.BearerToken = null;
            this.ReportViewerVentas.Size = new System.Drawing.Size(396, 246);
            this.ReportViewerVentas.TabIndex = 1;
            this.ReportViewerVentas.Visible = false;
            this.ReportViewerVentas.Load += new System.EventHandler(this.ReportViewerVentas_Load);
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "facturas";
            this.facturasBindingSource.DataSource = this.inventarioDataSet;
            // 
            // detallesTableAdapter
            // 
            this.detallesTableAdapter.ClearBeforeFill = true;
            // 
            // suplidorBindingSource
            // 
            this.suplidorBindingSource.DataMember = "suplidor";
            this.suplidorBindingSource.DataSource = this.inventarioDataSet;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.inventarioDataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private inventarioDataSet inventarioDataSet;
        private System.Windows.Forms.BindingSource inventarioDataSetBindingSource;
        private System.Windows.Forms.BindingSource detallesBindingSource;
        private inventarioDataSetTableAdapters.detallesTableAdapter detallesTableAdapter;
        private System.Windows.Forms.BindingSource suplidorBindingSource;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private inventarioDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerVentas;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private inventarioDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private inventarioDataSet inventarioDataSet1;
        private System.Windows.Forms.BindingSource facturasBindingSource1;
        private inventarioDataSetTableAdapters.facturasTableAdapter facturasTableAdapter;
    }
}