namespace Inventario_1200691.Forms.Reportes
{
    partial class Reportes
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
            this.PanelReportes = new System.Windows.Forms.Panel();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet = new Inventario_1200691.inventarioDataSet();
            this.clienteTableAdapter = new Inventario_1200691.inventarioDataSetTableAdapters.clienteTableAdapter();
            this.BotonImprimir = new System.Windows.Forms.Button();
            this.PanelBusqueda = new System.Windows.Forms.Panel();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            this.PanelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BotonBuscar);
            this.panel1.Controls.Add(this.BotonImprimir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(688, 0);
            this.panel1.Size = new System.Drawing.Size(112, 450);
            this.panel1.Controls.SetChildIndex(this.BotonImprimir, 0);
            this.panel1.Controls.SetChildIndex(this.BotonBuscar, 0);
            // 
            // PanelReportes
            // 
            this.PanelReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelReportes.Location = new System.Drawing.Point(0, 31);
            this.PanelReportes.Name = "PanelReportes";
            this.PanelReportes.Size = new System.Drawing.Size(688, 419);
            this.PanelReportes.TabIndex = 1;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.inventarioDataSet;
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "inventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // BotonImprimir
            // 
            this.BotonImprimir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonImprimir.Location = new System.Drawing.Point(0, 340);
            this.BotonImprimir.Name = "BotonImprimir";
            this.BotonImprimir.Size = new System.Drawing.Size(112, 59);
            this.BotonImprimir.TabIndex = 3;
            this.BotonImprimir.Text = "Imprimir";
            this.BotonImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonImprimir.UseVisualStyleBackColor = true;
            this.BotonImprimir.Click += new System.EventHandler(this.BotonImprimir_Click);
            // 
            // PanelBusqueda
            // 
            this.PanelBusqueda.Controls.Add(this.TextBoxNombre);
            this.PanelBusqueda.Controls.Add(this.LabelNombre);
            this.PanelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.PanelBusqueda.Name = "PanelBusqueda";
            this.PanelBusqueda.Size = new System.Drawing.Size(688, 31);
            this.PanelBusqueda.TabIndex = 7;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(85, 6);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(587, 20);
            this.TextBoxNombre.TabIndex = 1;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.BackColor = System.Drawing.SystemColors.Control;
            this.LabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(3, 6);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(76, 20);
            this.LabelNombre.TabIndex = 0;
            this.LabelNombre.Text = "Nombre:";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonBuscar.Location = new System.Drawing.Point(0, 281);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(112, 59);
            this.BotonBuscar.TabIndex = 3;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelReportes);
            this.Controls.Add(this.PanelBusqueda);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.PanelBusqueda, 0);
            this.Controls.SetChildIndex(this.PanelReportes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            this.PanelBusqueda.ResumeLayout(false);
            this.PanelBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private inventarioDataSet inventarioDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private inventarioDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button BotonImprimir;
        private System.Windows.Forms.Panel PanelBusqueda;
        public System.Windows.Forms.Panel PanelReportes;
        private System.Windows.Forms.Button BotonBuscar;
        public System.Windows.Forms.TextBox TextBoxNombre;
        public System.Windows.Forms.Label LabelNombre;
    }
}