namespace Inventario_1200691.Forms.Reportes
{
    partial class ReporteDepartamentos
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
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet1 = new Inventario_1200691.inventarioDataSet();
            this.ReportViewerDepartamentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataGridViewDep = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departamentoTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.departamentoTableAdapter();
            this.PanelReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDep)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelReportes
            // 
            this.PanelReportes.Controls.Add(this.ReportViewerDepartamentos);
            this.PanelReportes.Controls.Add(this.DataGridViewDep);
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "departamento";
            this.departamentoBindingSource.DataSource = this.inventarioDataSet1;
            // 
            // inventarioDataSet1
            // 
            this.inventarioDataSet1.DataSetName = "inventarioDataSet";
            this.inventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportViewerDepartamentos
            // 
            reportDataSource1.Name = "DataSetDepartamentos";
            reportDataSource1.Value = this.departamentoBindingSource;
            this.ReportViewerDepartamentos.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerDepartamentos.LocalReport.ReportEmbeddedResource = "Inventario_1200691.ReporteDepartamentos.rdlc";
            this.ReportViewerDepartamentos.Location = new System.Drawing.Point(111, 80);
            this.ReportViewerDepartamentos.Name = "ReportViewerDepartamentos";
            this.ReportViewerDepartamentos.ServerReport.BearerToken = null;
            this.ReportViewerDepartamentos.Size = new System.Drawing.Size(396, 246);
            this.ReportViewerDepartamentos.TabIndex = 0;
            this.ReportViewerDepartamentos.Visible = false;
            // 
            // DataGridViewDep
            // 
            this.DataGridViewDep.AllowUserToAddRows = false;
            this.DataGridViewDep.AllowUserToDeleteRows = false;
            this.DataGridViewDep.AutoGenerateColumns = false;
            this.DataGridViewDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDep.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.DataGridViewDep.DataSource = this.departamentoBindingSource;
            this.DataGridViewDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewDep.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewDep.Name = "DataGridViewDep";
            this.DataGridViewDep.ReadOnly = true;
            this.DataGridViewDep.Size = new System.Drawing.Size(688, 419);
            this.DataGridViewDep.TabIndex = 9;
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
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ReporteDepartamentos";
            this.Text = "Reportes Departamentos";
            this.Load += new System.EventHandler(this.ReporteDepartamentos_Load);
            this.PanelReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGridViewDepartamentos;
        private inventarioDataSet inventarioDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private inventarioDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerClientes;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerDepartamentos;
        private System.Windows.Forms.DataGridView DataGridViewDep;
        private inventarioDataSet inventarioDataSet1;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private inventarioDataSetTableAdapters.departamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}