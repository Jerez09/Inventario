namespace Inventario_1200691.Forms.Reportes
{
    partial class ReporteSuplidores
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
            this.suplidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet1 = new Inventario_1200691.inventarioDataSet();
            this.ReportViewerSuplidores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataGridViewSuplidores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.suplidorTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.suplidorTableAdapter();
            this.PanelReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSuplidores)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelReportes
            // 
            this.PanelReportes.Controls.Add(this.ReportViewerSuplidores);
            this.PanelReportes.Controls.Add(this.DataGridViewSuplidores);
            // 
            // suplidorBindingSource
            // 
            this.suplidorBindingSource.DataMember = "suplidor";
            this.suplidorBindingSource.DataSource = this.inventarioDataSet1;
            // 
            // inventarioDataSet1
            // 
            this.inventarioDataSet1.DataSetName = "inventarioDataSet";
            this.inventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportViewerSuplidores
            // 
            reportDataSource1.Name = "DataSetSuplidores";
            reportDataSource1.Value = this.suplidorBindingSource;
            this.ReportViewerSuplidores.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerSuplidores.LocalReport.ReportEmbeddedResource = "Inventario_1200691.ReporteSuplidores.rdlc";
            this.ReportViewerSuplidores.Location = new System.Drawing.Point(137, 82);
            this.ReportViewerSuplidores.Name = "ReportViewerSuplidores";
            this.ReportViewerSuplidores.ServerReport.BearerToken = null;
            this.ReportViewerSuplidores.Size = new System.Drawing.Size(396, 246);
            this.ReportViewerSuplidores.TabIndex = 7;
            this.ReportViewerSuplidores.Visible = false;
            // 
            // DataGridViewSuplidores
            // 
            this.DataGridViewSuplidores.AllowUserToAddRows = false;
            this.DataGridViewSuplidores.AllowUserToDeleteRows = false;
            this.DataGridViewSuplidores.AutoGenerateColumns = false;
            this.DataGridViewSuplidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewSuplidores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSuplidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.DataGridViewSuplidores.DataSource = this.suplidorBindingSource;
            this.DataGridViewSuplidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewSuplidores.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewSuplidores.Name = "DataGridViewSuplidores";
            this.DataGridViewSuplidores.ReadOnly = true;
            this.DataGridViewSuplidores.Size = new System.Drawing.Size(688, 419);
            this.DataGridViewSuplidores.TabIndex = 11;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn3.HeaderText = "email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // suplidorTableAdapter
            // 
            this.suplidorTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ReporteSuplidores";
            this.Text = "Reporte Suplidores";
            this.Load += new System.EventHandler(this.ReporteSuplidores_Load);
            this.PanelReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSuplidores)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerSuplidores;
        private System.Windows.Forms.DataGridView DataGridViewSuplidores;
        private inventarioDataSet inventarioDataSet1;
        private System.Windows.Forms.BindingSource suplidorBindingSource;
        private inventarioDataSetTableAdapters.suplidorTableAdapter suplidorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}