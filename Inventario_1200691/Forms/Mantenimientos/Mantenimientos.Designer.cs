namespace Inventario_1200691.Forms.Mantenimientos
{
    partial class Mantenimientos
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
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonConsultar = new System.Windows.Forms.Button();
            this.PanelMantenimiento = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BotonConsultar);
            this.panel1.Controls.Add(this.BotonGuardar);
            this.panel1.Controls.Add(this.BotonEliminar);
            this.panel1.Location = new System.Drawing.Point(696, 0);
            this.panel1.Size = new System.Drawing.Size(109, 457);
            this.panel1.Controls.SetChildIndex(this.BotonEliminar, 0);
            this.panel1.Controls.SetChildIndex(this.BotonGuardar, 0);
            this.panel1.Controls.SetChildIndex(this.BotonConsultar, 0);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonEliminar.Location = new System.Drawing.Point(0, 347);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(109, 59);
            this.BotonEliminar.TabIndex = 2;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonGuardar.Location = new System.Drawing.Point(0, 288);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(109, 59);
            this.BotonGuardar.TabIndex = 2;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonConsultar
            // 
            this.BotonConsultar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonConsultar.Location = new System.Drawing.Point(0, 229);
            this.BotonConsultar.Name = "BotonConsultar";
            this.BotonConsultar.Size = new System.Drawing.Size(109, 59);
            this.BotonConsultar.TabIndex = 2;
            this.BotonConsultar.Text = "Consultar";
            this.BotonConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonConsultar.UseVisualStyleBackColor = true;
            this.BotonConsultar.Click += new System.EventHandler(this.BotonConsultar_Click);
            // 
            // PanelMantenimiento
            // 
            this.PanelMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.PanelMantenimiento.Name = "PanelMantenimiento";
            this.PanelMantenimiento.Size = new System.Drawing.Size(696, 457);
            this.PanelMantenimiento.TabIndex = 1;
            // 
            // Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 457);
            this.Controls.Add(this.PanelMantenimiento);
            this.Name = "Mantenimientos";
            this.Text = "Mantenimientos";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.PanelMantenimiento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonEliminar;
        public System.Windows.Forms.Button BotonConsultar;
        public System.Windows.Forms.Panel PanelMantenimiento;
    }
}