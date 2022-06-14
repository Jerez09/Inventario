namespace Inventario_1200691.Forms.Reportes
{
    partial class ReporteProductos
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
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet1 = new Inventario_1200691.inventarioDataSet();
            this.ReportViewerProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.productoTableAdapter();
            this.DataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preccompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelReportes
            // 
            this.PanelReportes.Controls.Add(this.DataGridViewProductos);
            this.PanelReportes.Controls.Add(this.ReportViewerProductos);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.inventarioDataSet1;
            // 
            // inventarioDataSet1
            // 
            this.inventarioDataSet1.DataSetName = "inventarioDataSet";
            this.inventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportViewerProductos
            // 
            reportDataSource1.Name = "DataSetProductos";
            reportDataSource1.Value = this.productoBindingSource;
            this.ReportViewerProductos.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerProductos.LocalReport.ReportEmbeddedResource = "Inventario_1200691.ReporteProductos.rdlc";
            this.ReportViewerProductos.Location = new System.Drawing.Point(145, 122);
            this.ReportViewerProductos.Name = "ReportViewerProductos";
            this.ReportViewerProductos.ServerReport.BearerToken = null;
            this.ReportViewerProductos.Size = new System.Drawing.Size(396, 246);
            this.ReportViewerProductos.TabIndex = 7;
            this.ReportViewerProductos.Visible = false;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "producto";
            this.productoBindingSource1.DataSource = this.inventarioDataSet1;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridViewProductos
            // 
            this.DataGridViewProductos.AllowUserToAddRows = false;
            this.DataGridViewProductos.AllowUserToDeleteRows = false;
            this.DataGridViewProductos.AutoGenerateColumns = false;
            this.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.precventaDataGridViewTextBoxColumn,
            this.preccompraDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn});
            this.DataGridViewProductos.DataSource = this.productoBindingSource;
            this.DataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewProductos.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewProductos.Name = "DataGridViewProductos";
            this.DataGridViewProductos.ReadOnly = true;
            this.DataGridViewProductos.Size = new System.Drawing.Size(688, 419);
            this.DataGridViewProductos.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // precventaDataGridViewTextBoxColumn
            // 
            this.precventaDataGridViewTextBoxColumn.DataPropertyName = "precventa";
            this.precventaDataGridViewTextBoxColumn.HeaderText = "precventa";
            this.precventaDataGridViewTextBoxColumn.Name = "precventaDataGridViewTextBoxColumn";
            this.precventaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preccompraDataGridViewTextBoxColumn
            // 
            this.preccompraDataGridViewTextBoxColumn.DataPropertyName = "preccompra";
            this.preccompraDataGridViewTextBoxColumn.HeaderText = "preccompra";
            this.preccompraDataGridViewTextBoxColumn.Name = "preccompraDataGridViewTextBoxColumn";
            this.preccompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ReporteProductos";
            this.Text = "Reporte Productos";
            this.Load += new System.EventHandler(this.ReporteProductos_Load);
            this.PanelReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private inventarioDataSet inventarioDataSet;
        private inventarioDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerProductos;
        private inventarioDataSet inventarioDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private inventarioDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.DataGridView DataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preccompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}