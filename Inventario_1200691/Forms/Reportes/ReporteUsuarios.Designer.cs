namespace Inventario_1200691.Forms.Reportes
{
    partial class ReporteUsuarios
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
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet1 = new Inventario_1200691.inventarioDataSet();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet = new Inventario_1200691.inventarioDataSet();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewerUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuarioTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.usuarioTableAdapter();
            this.suplidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelReportes
            // 
            this.PanelReportes.Controls.Add(this.DataGridViewUsuarios);
            this.PanelReportes.Controls.Add(this.ReportViewerUsuarios);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.inventarioDataSet1;
            // 
            // inventarioDataSet1
            // 
            this.inventarioDataSet1.DataSetName = "inventarioDataSet";
            this.inventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.inventarioDataSetBindingSource;
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
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "usuario";
            this.usuarioBindingSource2.DataSource = this.inventarioDataSet1;
            // 
            // ReportViewerUsuarios
            // 
            reportDataSource1.Name = "DataSetUsuarios";
            reportDataSource1.Value = this.usuarioBindingSource;
            this.ReportViewerUsuarios.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerUsuarios.LocalReport.ReportEmbeddedResource = "Inventario_1200691.ReporteUsuarios.rdlc";
            this.ReportViewerUsuarios.Location = new System.Drawing.Point(140, 101);
            this.ReportViewerUsuarios.Name = "ReportViewerUsuarios";
            this.ReportViewerUsuarios.ServerReport.BearerToken = null;
            this.ReportViewerUsuarios.Size = new System.Drawing.Size(396, 246);
            this.ReportViewerUsuarios.TabIndex = 1;
            this.ReportViewerUsuarios.Visible = false;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // suplidorBindingSource
            // 
            this.suplidorBindingSource.DataMember = "suplidor";
            this.suplidorBindingSource.DataSource = this.inventarioDataSet;
            // 
            // DataGridViewUsuarios
            // 
            this.DataGridViewUsuarios.AllowUserToAddRows = false;
            this.DataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.DataGridViewUsuarios.AutoGenerateColumns = false;
            this.DataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.DataGridViewUsuarios.DataSource = this.usuarioBindingSource;
            this.DataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewUsuarios.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewUsuarios.Name = "DataGridViewUsuarios";
            this.DataGridViewUsuarios.ReadOnly = true;
            this.DataGridViewUsuarios.Size = new System.Drawing.Size(688, 419);
            this.DataGridViewUsuarios.TabIndex = 2;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ReporteUsuarios";
            this.Text = "Reporte Usuarios";
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            this.PanelReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource inventarioDataSetBindingSource;
        private inventarioDataSet inventarioDataSet;
        private inventarioDataSet inventarioDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private inventarioDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.BindingSource suplidorBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private System.Windows.Forms.DataGridView DataGridViewUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
    }
}